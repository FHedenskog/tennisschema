using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using GemBox.Spreadsheet;

namespace TennisSchema.Views
{
    public partial class TennisSchemaGeneratorForm : Form
    {
        int currentDay;
        int previousDay;

        public TennisSchemaGeneratorForm()
        {
            InitializeComponent();

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            this.Load += new EventHandler(OnTennisSchemaGeneratorFormLoad);

            btnAddPlayer.Click += new EventHandler(OnAddPlayerButtonClick);
            btnRemovePlayer.Click += new EventHandler(OnRemovePlayerButtonClick);
            btnEditPlayer.Click += new EventHandler(OnEditPlayerButtonClick);

            btnAddDoublePair.Click += new EventHandler(OnAddDoublePairButtonClick);
            btnRemoveDoublePair.Click += new EventHandler(OnRemoveDoublePairButtonClick);

            btnSavePlayers.Click += new EventHandler(OnSavePlayersButtonClick);

            btnGenerateSingleGroups.Click += new EventHandler(OnGenerateSingleGroupsButtonClick);
            cbSingleGroups.SelectedValueChanged += new EventHandler(OnSingleGroupsSelectedValueChanged);
            btnClearSingles.Click += new EventHandler(OnClearSinglesButtonClick);

            btnGenerateDoubleGroups.Click += new EventHandler(OnGenerateDoublePairGroupsButtonClick);
            cbDoubleGroups.SelectedValueChanged += new EventHandler(OnDoublePairGroupsSelectedValueChanged);
            btnClearDoubles.Click += new EventHandler(OnClearDoublesButtonClick);

            btnGenerateCalendar.Click += new EventHandler(OnGenerateCalendarClick);
            btnClearCalendar.Click += new EventHandler(OnClearCalendarButtonClick);
            btnAddTimeSlot.Click += new EventHandler(OnAddDateButtonClick);
            btnRemoveTimeSlot.Click += new EventHandler(OnRemoveDateButtonClick);

            btnSaveCalendar.Click += new EventHandler(OnSaveCalendarButtonClick);

            btnGenerateSchedule.Click += new EventHandler(OnGenerateScheduleButtonClick);
        }

        private void OnTennisSchemaGeneratorFormLoad(object sender, EventArgs e)
        {
            PlayerManager.Instance.LoadPlayersCSV();

            foreach (DoublePair pair in PlayerManager.Instance.DoubleData)
            {
                PlayerManager.Instance.SetTeamStatus(pair, true);
            }

            PlayerManager.Instance.LoadCalendarCSV();

            for (int i = 0; i < 24; i++)
            {
                cbHours.Items.Add(i);
            }

            cbMinutes.Items.Add("00");
            cbMinutes.Items.Add(10);
            cbMinutes.Items.Add(20);
            cbMinutes.Items.Add(30);
            cbMinutes.Items.Add(40);
            cbMinutes.Items.Add(50);

            cbHours.SelectedIndex = 0;
            cbMinutes.SelectedIndex = 0;

            FillSinglesListBox(0);

            FillTeamsListBox(0);

            FillCalendarListBox(null);
        }

        private void OnAddPlayerButtonClick(object sender, EventArgs e)
        {
            using (NewPlayerForm newPlayerForm = new NewPlayerForm())
            {
                DialogResult result = newPlayerForm.ShowDialog();

                if (result == DialogResult.OK && newPlayerForm.SinglePlayer != null)
                {
                    if (PlayerManager.Instance.PlayerData.Contains(newPlayerForm.SinglePlayer))
                    {
                        MessageBox.Show("Entry already exists. Use Edit to modify the existing entry.");
                        return;
                    }
                    PlayerManager.Instance.PlayerData.Add(newPlayerForm.SinglePlayer);
                    FillSinglesListBox(null);
                }
            }
        }

        private void OnRemovePlayerButtonClick(object sender, EventArgs e)
        {
            if (lbPlayers.SelectedItem != null)
            {
                string name = lbPlayers.SelectedItem.ToString();
                SinglePlayer selectedPlayer = PlayerManager.Instance.GetPlayer(name);

                if (selectedPlayer.IsInTeam)
                {
                    MessageBox.Show("You cannot remove a player that is already in a team.");
                    return;
                }

                PlayerManager.Instance.PlayerData.Remove(selectedPlayer);

                int selectedIndex = lbPlayers.SelectedIndex;

                if (selectedIndex == 0 && lbPlayers.Items.Count != 1)
                {
                    selectedIndex = 0;
                }

                else if (selectedIndex == lbPlayers.Items.Count - 1)
                {
                    selectedIndex = lbPlayers.Items.Count - 2;
                }

                FillSinglesListBox(selectedIndex);
            }
        }

        private void OnEditPlayerButtonClick(object sender, EventArgs e)
        {
            if (lbPlayers.SelectedItem != null)
            {
                string name = lbPlayers.SelectedItem.ToString();
                SinglePlayer selectedPlayer = PlayerManager.Instance.GetPlayer(name);
                SinglePlayer player = new SinglePlayer();
                player.CopyStats(selectedPlayer);

                using (var newPlayerForm = new NewPlayerForm())
                {
                    newPlayerForm.SinglePlayer = player;
                    newPlayerForm.ShowDialog();

                    if (newPlayerForm.SinglePlayer == null)
                        return;

                    if (newPlayerForm.SinglePlayer.Name == selectedPlayer.Name)
                    {
                        selectedPlayer.CopyStats(newPlayerForm.SinglePlayer);
                        FillSinglesListBox(lbPlayers.SelectedIndex);
                        return;
                    }

                    player = newPlayerForm.SinglePlayer;
                }

                DialogResult result = MessageBox.Show(
                    "Name has changed. Do you want to add a new entry?",
                    "New Entry",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                    return;

                if (lbPlayers.Items.Contains(player.Name))
                {
                    MessageBox.Show("Entry already exists. Use Edit to modify the entry.");
                    return;
                }

                PlayerManager.Instance.PlayerData.Add(player);
                FillSinglesListBox(lbPlayers.SelectedIndex);
                return;
            }
        }

        private void OnAddDoublePairButtonClick(object sender, EventArgs e)
        {
            using (var newDoublePairForm = new NewDoublePairForm())
            {
                DialogResult result = newDoublePairForm.ShowDialog();

                if (result == DialogResult.OK && newDoublePairForm.DoublePair != null)
                {
                    if (PlayerManager.Instance.DoubleData.Contains(newDoublePairForm.DoublePair))
                    {
                        MessageBox.Show("Entry already exists. Use Edit to modify the existing entry.");
                        return;
                    }
                    PlayerManager.Instance.DoubleData.Add(newDoublePairForm.DoublePair);
                    PlayerManager.Instance.SetTeamStatus(newDoublePairForm.DoublePair, true);
                    FillTeamsListBox(null);
                }
            }
        }

        private void OnRemoveDoublePairButtonClick(object sender, EventArgs e)
        {
            if (lbTeams.SelectedItem != null)
            {
                string name = lbTeams.SelectedItem.ToString();
                DoublePair pair = PlayerManager.Instance.GetPair(name);

                PlayerManager.Instance.SetTeamStatus(pair, false);
                PlayerManager.Instance.DoubleData.Remove(pair);

                int selectedIndex = lbTeams.SelectedIndex;

                if (selectedIndex == 0 && lbTeams.Items.Count != 1)
                {
                    selectedIndex = 0;
                }

                else if (selectedIndex == lbTeams.Items.Count - 1)
                {
                    selectedIndex = lbTeams.Items.Count - 2;
                }

                FillTeamsListBox(selectedIndex);
            }
        }

        private void OnSavePlayersButtonClick(object sender, EventArgs e)
        {
            PlayerManager.Instance.SavePlayersCSV();

            MessageBox.Show("Saved settings.", "Success", MessageBoxButtons.OK);
        }

        private void OnSaveCalendarButtonClick(object sender, EventArgs e)
        {
            PlayerManager.Instance.SaveCalendarCSV();

            MessageBox.Show("Saved calendar.", "Success", MessageBoxButtons.OK);
        }

        private void OnGenerateCalendarClick(object sender, EventArgs e)
        {
            using (var newCalendarForm = new NewCalendarForm())
            {
                DialogResult result = newCalendarForm.ShowDialog();

                if (result == DialogResult.OK && newCalendarForm.TimeSlots != null)
                {
                    PlayerManager.Instance.Calendar.Clear();
                    DateTime currentDate = newCalendarForm.StartDate;
                    bool excludedDateFound = false;

                    while (currentDate <= newCalendarForm.EndDate)
                    {
                        excludedDateFound = false;

                        foreach (DateTime excludedDate in newCalendarForm.ExcludedDates)
                        {
                            if (excludedDate == currentDate)
                            {
                                excludedDateFound = true;
                            }
                        }

                        if (excludedDateFound)
                        {
                            currentDate = currentDate.AddDays(1);
                            continue;
                        }
                        
                        foreach (TimeSlot slot in newCalendarForm.TimeSlots)
                        {
                            if ((int)currentDate.DayOfWeek == slot.Weekday)
                            {
                                DateTime temp = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, slot.Hours, slot.Minutes, 0);
                                PlayerManager.Instance.Calendar.Add(temp);
                            }
                        }
                        currentDate = currentDate.AddDays(1);
                    }
                    FillCalendarListBox(0);
                }
            }
        }

        private void OnClearCalendarButtonClick(object sender, EventArgs e)
        {
            lbCalendar.Items.Clear();
            PlayerManager.Instance.Calendar.Clear();
        }

        private void OnAddDateButtonClick(object sender, EventArgs e)
        {
            if (monthCalendar.SelectionStart != null)
            {
                string strMinutes = cbMinutes.SelectedItem.ToString();
                int minutes = int.Parse(strMinutes);

                DateTime newDate = new DateTime(monthCalendar.SelectionStart.Year, monthCalendar.SelectionStart.Month, monthCalendar.SelectionStart.Day, (int)cbHours.SelectedItem, minutes, 0);
                PlayerManager.Instance.Calendar.Add(newDate);

                FillCalendarListBox(0);
            }
        }

        private void OnRemoveDateButtonClick(object sender, EventArgs e)
        {
            if (lbCalendar.SelectedItem != null)
            {
                int selectedIndex = lbCalendar.SelectedIndex;

                if (selectedIndex == 0 && lbCalendar.Items.Count != 1)
                {
                    selectedIndex = 0;
                }

                else if (selectedIndex == lbCalendar.Items.Count - 1)
                {
                    selectedIndex = lbCalendar.Items.Count - 2;
                }

                string date = lbCalendar.SelectedItem.ToString();
                DateTime selectedDate = PlayerManager.Instance.GetDate(date);
                PlayerManager.Instance.Calendar.Remove(selectedDate);
                FillCalendarListBox(selectedIndex);
            }
        }

        public void FillSinglesListBox(int? selectedIndex)
        {
            lbPlayers.Items.Clear();
            foreach (SinglePlayer player in PlayerManager.Instance.PlayerData)
            {
                lbPlayers.Items.Add(player.ToString());
            }

            if (lbPlayers.Items.Count != 0 && selectedIndex.HasValue)
            {
                lbPlayers.SetSelected(selectedIndex.Value, true);
            }

            else if (lbPlayers.Items.Count != 0)
            {
                lbPlayers.SetSelected(lbPlayers.Items.Count - 1, true);
            }

            UpdateSinglePlayerSettings();
        }

        public void FillTeamsListBox(int? selectedIndex)
        {
            lbTeams.Items.Clear();
            foreach (DoublePair pair in PlayerManager.Instance.DoubleData)
            {
                lbTeams.Items.Add(pair.ToString());
            }

            if (lbTeams.Items.Count != 0 && selectedIndex.HasValue)
            {
                lbTeams.SetSelected(selectedIndex.Value, true);
            }

            else if (lbTeams.Items.Count != 0)
            {
                lbTeams.SetSelected(lbTeams.Items.Count - 1, true);
            }

            UpdateDoubleTeamsSettings();
        }

        public void FillCalendarListBox(int? selectedIndex)
        {
            var sortedList = PlayerManager.Instance.Calendar.OrderBy(x => x).ToList();

            lbCalendar.Items.Clear();

            foreach (DateTime date in sortedList)
            {
                lbCalendar.Items.Add(date.ToString(PlayerManager.DATETIME_DISPLAY_FORMAT));
            }
        }

        public void UpdateSinglePlayerSettings()
        {
            int count = 0;
            foreach (SinglePlayer player in PlayerManager.Instance.PlayerData)
            {
                if (player.PlayingSingle)
                {
                    count++;
                }
            }

            lblPlayersPlayingSingle.Text = count.ToString();

            if (count >= 3)
            {
                btnGenerateSingleGroups.Enabled = true;
                nudSinglesGroupSize.Enabled = true;

                UpdateNudSinglesLimits(count);
            }
            else
            {
                btnGenerateSingleGroups.Enabled = false;
                nudSinglesGroupSize.Enabled = false;
                cbSingleGroups.Enabled = false;
            }
        }

        public void UpdateDoubleTeamsSettings()
        {
            lblTeamsPlayingDouble.Text = lbTeams.Items.Count.ToString();
            int count = lbTeams.Items.Count;

            if (count >= 3)
            {
                btnGenerateDoubleGroups.Enabled = true;
                nudDoublesGroupSize.Enabled = true;

                UpdateNudDoublesLimits(count);
            }
            else
            {
                btnGenerateDoubleGroups.Enabled = false;
                nudDoublesGroupSize.Enabled = false;
                cbDoubleGroups.Enabled = false;
            }
        }

        public void UpdateNudSinglesLimits(int count)
        {
            if (count <= 5)
            {
                nudSinglesGroupSize.Minimum = count;
            }
            else
            {
                nudSinglesGroupSize.Minimum = 3;
            }

            if (count <= 10)
                nudSinglesGroupSize.Maximum = count;
            else
                nudSinglesGroupSize.Maximum = 10;
        }

        public void UpdateNudDoublesLimits(int count)
        {
            if (count <= 5)
            {
                nudDoublesGroupSize.Minimum = count;
            }
            else
            {
                nudDoublesGroupSize.Minimum = 3;
            }

            if (lbTeams.Items.Count <= 10)
                nudDoublesGroupSize.Maximum = count;
            else
                nudDoublesGroupSize.Maximum = 10;
        }

        private void OnGenerateSingleGroupsButtonClick(object sender, EventArgs e)
        {
            using (var setPlayerRankingsForm = new SetPlayerRankingsForm())
            {
                DialogResult result = setPlayerRankingsForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int count = 0;
                    int preferredGroupSize = (int)nudSinglesGroupSize.Value;

                    foreach (SinglePlayer player in PlayerManager.Instance.PlayerData)
                    {
                        if (player.PlayingSingle)
                        {
                            count++;
                        }
                    }
                    int currentNumberOfGroups = count / (int)preferredGroupSize;

                    if (count % preferredGroupSize != 0)
                    {
                        currentNumberOfGroups++;
                    }

                    int chosenGroupSize = 0;
                    int currentGroupSize = preferredGroupSize;
                    int it = 1;
                    bool groupSizesFound = false;

                    while (!groupSizesFound)
                    {
                        int maxPlayerCount = currentGroupSize * currentNumberOfGroups;
                        if (maxPlayerCount < count)
                        {
                            currentGroupSize = preferredGroupSize - it;
                            it++;
                            currentNumberOfGroups++;
                            if (currentGroupSize == 0)
                            {
                                MessageBox.Show("Unable to generate group. Please try with a different maximum group size or with a different number of players.");
                                return;
                            }
                        }
                        if (count >= maxPlayerCount - currentNumberOfGroups + 1 && count <= maxPlayerCount)
                        {
                            groupSizesFound = true;
                            chosenGroupSize = currentGroupSize;
                        }
                        else
                        {
                            currentGroupSize--;
                            if (currentGroupSize < 3)
                            {
                                MessageBox.Show("Unable to generate group. Please try with a different maximum group size or with a different number of players.");
                                return;
                            }
                        }
                    }

                    CreateSingleGroups(count, chosenGroupSize);

                    AddPlayers(count);
                }
            }

        }

        private void CreateSingleGroups(int count, int groupSize)
        {
            int numberOfGroups = count / (int)groupSize;

            if (count % groupSize != 0)
            {
                numberOfGroups++;
            }
            int remainder = groupSize * numberOfGroups - count;

            int groupIndex = 1;

            for (int i = 0; i < numberOfGroups; i++)
            {
                if (i < numberOfGroups - remainder)
                {
                    SingleGroup newGroup = new SingleGroup(groupSize, groupIndex, cboSingleDouble.Checked);
                    PlayerManager.Instance.Groups.Add(newGroup);
                    cbSingleGroups.Items.Add(newGroup.ToString());
                }
                else
                {
                    SingleGroup newGroup = new SingleGroup(groupSize - 1, groupIndex, cboSingleDouble.Checked);
                    PlayerManager.Instance.Groups.Add(newGroup);
                    cbSingleGroups.Items.Add(newGroup.ToString());
                }
                groupIndex++;
            }
        }

        private void AddPlayers(int count)
        {
            int currentRank = 1;
            SingleGroup singleGroup;

            foreach (Group group in PlayerManager.Instance.Groups)
            {
                if (group is SingleGroup)
                {
                    singleGroup = group as SingleGroup;

                    while (singleGroup.Players.Count < singleGroup.AllowedSize)
                    {
                        foreach (SinglePlayer player in PlayerManager.Instance.PlayerData)
                        {
                            if (!player.PlayingSingle)
                                continue;

                            if (player.Ranking == currentRank)
                            {
                                singleGroup.AddToGroup(player);
                                currentRank++;
                                break;
                            }
                        }
                    }
                }
            }
            btnAddPlayer.Enabled = false;
            btnRemovePlayer.Enabled = false;
            btnEditPlayer.Enabled = false;

            cbSingleGroups.Enabled = true;
            lblSelectSingleGroups.Enabled = true;
            btnGenerateSingleGroups.Enabled = false;
            btnClearSingles.Enabled = true;
            cboSingleDouble.Enabled = false;
            cbSingleGroups.SelectedIndex = 0;
        }

        private void OnSingleGroupsSelectedValueChanged(object sender, EventArgs e)
        {
            lbSingleGroups.Items.Clear();
            if (cbSingleGroups.SelectedItem != null)
            {
                SingleGroup singleGroup;
                foreach (Group group in PlayerManager.Instance.Groups)
                {
                    if (group is SingleGroup)
                    {
                        singleGroup = group as SingleGroup;
                        if (singleGroup.Name == cbSingleGroups.SelectedItem.ToString())
                        {
                            foreach (SinglePlayer player in singleGroup.Players)
                            {
                                lbSingleGroups.Items.Add(player);
                            }
                        }
                    }
                }
            }
        }

        private void OnGenerateDoublePairGroupsButtonClick(object sender, EventArgs e)
        {
            using (var setDoublesRankingsForm = new SetDoublesRankingsForm())
            {
                DialogResult result = setDoublesRankingsForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int count = PlayerManager.Instance.DoubleData.Count;
                    int preferredGroupSize = (int)nudDoublesGroupSize.Value;

                    int currentNumberOfGroups = count / (int)preferredGroupSize;

                    if (count % preferredGroupSize != 0)
                    {
                        currentNumberOfGroups++;
                    }

                    int chosenGroupSize = 0;
                    int currentGroupSize = preferredGroupSize;
                    int it = 1;
                    bool groupSizesFound = false;

                    while (!groupSizesFound)
                    {
                        int maxTeamsCount = currentGroupSize * currentNumberOfGroups;
                        if (maxTeamsCount < count)
                        {
                            currentGroupSize = preferredGroupSize - it;
                            it++;
                            currentNumberOfGroups++;
                            if (currentGroupSize == 0)
                            {
                                MessageBox.Show("Unable to generate group. Please try with a different maximum group size or with a different number of players.");
                                return;
                            }
                        }
                        if (count >= maxTeamsCount - currentNumberOfGroups + 1 && count <= maxTeamsCount)
                        {
                            groupSizesFound = true;
                            chosenGroupSize = currentGroupSize;
                        }
                        else
                        {
                            currentGroupSize--;
                            if (currentGroupSize < 3)
                            {
                                MessageBox.Show("Unable to generate group. Please try with a different maximum group size or with a different number of players.");
                                return;
                            }
                        }
                    }

                    CreateDoubleGroups(count, chosenGroupSize);

                    AddPairs(count);
                }
            }
        }

        private void CreateDoubleGroups(int count, int groupSize)
        {
            int numberOfGroups = count / (int)groupSize;

            if (count % groupSize != 0)
            {
                numberOfGroups++;
            }
            int remainder = groupSize * numberOfGroups - count;

            int groupIndex = 1;

            for (int i = 0; i < numberOfGroups; i++)
            {
                if (i < numberOfGroups - remainder)
                {
                    DoubleGroup newGroup = new DoubleGroup(groupSize, groupIndex, cboDoubleDouble.Checked);
                    PlayerManager.Instance.Groups.Add(newGroup);
                    cbDoubleGroups.Items.Add(newGroup.ToString());
                }
                else
                {
                    DoubleGroup newGroup = new DoubleGroup(groupSize - 1, groupIndex, cboDoubleDouble.Checked);
                    PlayerManager.Instance.Groups.Add(newGroup);
                    cbDoubleGroups.Items.Add(newGroup.ToString());
                }
                groupIndex++;
            }
        }

        private void AddPairs(int count)
        {
            int currentRank = 1;
            DoubleGroup doubleGroup;

            foreach (Group group in PlayerManager.Instance.Groups)
            {
                if (group is DoubleGroup)
                {
                    doubleGroup = group as DoubleGroup;

                    while (doubleGroup.Pairs.Count < doubleGroup.AllowedSize)
                    {
                        foreach (DoublePair pair in PlayerManager.Instance.DoubleData)
                        {
                            if (pair.Ranking == currentRank)
                            {
                                doubleGroup.AddToGroup(pair);
                                currentRank++;
                                break;
                            }
                        }
                    }
                }
            }

            btnAddDoublePair.Enabled = false;
            btnRemoveDoublePair.Enabled = false;

            cbDoubleGroups.Enabled = true;
            lblSelectDoubleGroups.Enabled = true;
            btnGenerateDoubleGroups.Enabled = false;
            btnClearDoubles.Enabled = true;
            cbDoubleGroups.SelectedIndex = 0;
            cboDoubleDouble.Enabled = false;
        }

        private void OnDoublePairGroupsSelectedValueChanged(object sender, EventArgs e)
        {
            lbDoubleGroups.Items.Clear();
            if (cbDoubleGroups.SelectedItem != null)
            {
                DoubleGroup doubleGroup;
                foreach (Group group in PlayerManager.Instance.Groups)
                {
                    if (group is DoubleGroup)
                    {
                        doubleGroup = group as DoubleGroup;
                        if (doubleGroup.Name == cbDoubleGroups.SelectedItem.ToString())
                        {
                            foreach (DoublePair pair in doubleGroup.Pairs)
                            {
                                lbDoubleGroups.Items.Add(pair);
                            }
                        }
                    }
                }
            }
        }

        private void OnClearSinglesButtonClick(object sender, EventArgs e)
        {
            lbSingleGroups.Items.Clear();
            cbSingleGroups.Items.Clear();

            SingleGroup singleGroup;
            bool allGroupsRemoved = false;
            bool groupFound = false;

            while (!allGroupsRemoved)
            {
                groupFound = false;
                foreach (Group group in PlayerManager.Instance.Groups)
                {
                    if (group is SingleGroup)
                    {
                        groupFound = true;
                        singleGroup = group as SingleGroup;
                        PlayerManager.Instance.Groups.Remove(singleGroup);
                        break;
                    }

                    groupFound = false;
                }
                if (!groupFound)
                    break;
            }

            foreach (SinglePlayer player in PlayerManager.Instance.PlayerData)
                player.Ranking = 0;

            btnAddPlayer.Enabled = true;
            btnEditPlayer.Enabled = true;
            btnRemovePlayer.Enabled = true;

            cbSingleGroups.Enabled = false;
            lblSelectSingleGroups.Enabled = false;
            btnGenerateSingleGroups.Enabled = true;
            btnClearSingles.Enabled = false;
            cboSingleDouble.Enabled = true;
        }

        private void OnClearDoublesButtonClick(object sender, EventArgs e)
        {
            lbDoubleGroups.Items.Clear();
            cbDoubleGroups.Items.Clear();

            DoubleGroup doubleGroup;
            bool allGroupsRemoved = false;
            bool groupFound = false;

            while (!allGroupsRemoved)
            {
                groupFound = false;
                foreach (Group group in PlayerManager.Instance.Groups)
                {
                    if (group is DoubleGroup)
                    {
                        groupFound = true;
                        doubleGroup = group as DoubleGroup;
                        PlayerManager.Instance.Groups.Remove(doubleGroup);
                        break;
                    }
                }
                if (!groupFound)
                    break;
            }

            foreach (DoublePair pair in PlayerManager.Instance.DoubleData)
                pair.Ranking = 99;

            btnAddDoublePair.Enabled = true;
            btnRemoveDoublePair.Enabled = true;

            cbDoubleGroups.Enabled = false;
            lblSelectDoubleGroups.Enabled = false;
            btnGenerateDoubleGroups.Enabled = true;
            btnClearDoubles.Enabled = false;
            cboDoubleDouble.Enabled = true;
        }

        private void OnGenerateScheduleButtonClick(object sender, EventArgs e)
        {
            if (PlayerManager.Instance.Matches.Count != 0)
            {
                ResetSettings();
            }

            if (PlayerManager.Instance.Groups.Count < 1)
            {
                MessageBox.Show("Unable to generate schedule since there are no players that have been assigned to any groups. Go to the \'Settings\' tab in order to generate groups.");
                return;
            }

            if (PlayerManager.Instance.Calendar.Count < 1)
            {
                MessageBox.Show("Unable to generate schedule since there are no time slots. Generate a calendar or add time slots before generating the schedule.");
                return;
            }

            foreach (Group group in PlayerManager.Instance.Groups)
            {
                group.GenerateSchedule();
            }

            if (File.Exists(Application.StartupPath + @"\schedule.xls"))
            {
                File.Delete(Application.StartupPath + @"\schedule.xls");
            }

            GenerateSchedule();

            int totalMatchesLeft = 0;

            foreach (Group group in PlayerManager.Instance.Groups)
            {
                totalMatchesLeft += group.MatchesLeft;
            }

            ExcelFile ef = new ExcelFile();

            ExcelWorksheet ws = ef.Worksheets.Add("Schedule");


            int currentRow = 0;
            int shift = 0;
            int count = 0;

            for (int i = 0; i < PlayerManager.Instance.Matches.Count; i++)
            {
                ws.Cells[currentRow, shift].Value = PlayerManager.Instance.Matches[i].GetDate();
                ws.Cells[currentRow, shift + 1].Value = PlayerManager.Instance.Matches[i].Setup;

                currentRow++;
                count++;
                if (count == 100)
                {
                    currentRow = 0;
                    shift += 8;
                    count = 0;
                }
            }

            ef.Save(Application.StartupPath + @"\schedule.xls");
            if (totalMatchesLeft > 0)
            {
                MessageBox.Show("Created schedule.xls. Note however that " + totalMatchesLeft + " matches are not assinged to any time slot. Consider changing settings or add more time slots and retry.", "More Time Slots Required", MessageBoxButtons.OK);
            }
            else
            { 
                MessageBox.Show("Created schedule.xls.", "Success", MessageBoxButtons.OK);
            }
        }

        private void ResetSettings()
        {
            ActivatePlayers();
            PlayerManager.Instance.Matches.Clear();
            foreach (Group group in PlayerManager.Instance.Groups)
            {
                group.PercentageFinished = 0f;
            }
        }

        private void GenerateSchedule()
        {
            currentDay = PlayerManager.Instance.Calendar[0].Day;

            for (int i = 0; i < PlayerManager.Instance.Calendar.Count; i++)
            {
                previousDay = currentDay;
                currentDay = PlayerManager.Instance.Calendar[i].Day;

                if (currentDay != previousDay)
                    ActivatePlayers();

                int[] matchesLeft = new int[PlayerManager.Instance.Groups.Count];
                float[] percentageFinished = new float[PlayerManager.Instance.Groups.Count];

                for (int j = 0; j < PlayerManager.Instance.Groups.Count; j++)
                {
                    PlayerManager.Instance.Groups[j].SetNextMatch();

                    matchesLeft[j] = PlayerManager.Instance.Groups[j].MatchesLeft;
                    percentageFinished[j] = PlayerManager.Instance.Groups[j].PercentageFinished;
                }
                if (matchesLeft.Max() <= 0)
                    return;

                int currentIndex = Array.IndexOf(percentageFinished, percentageFinished.Min());
                int attempts = 0;

                while (attempts < PlayerManager.Instance.Groups.Count)
                {
                    if (PlayerManager.Instance.Groups[currentIndex].AddToCalendar(PlayerManager.Instance.Calendar[i]))
                        break;
                    else
                    {
                        percentageFinished[currentIndex] = 1f;
                        currentIndex = Array.IndexOf(percentageFinished, percentageFinished.Min());
                    }

                    attempts++;

                    if (attempts == PlayerManager.Instance.Groups.Count)
                    {
                        Match nextMatch = new Match(PlayerManager.Instance.Calendar[i]);
                        nextMatch.AddToCalendar();
                    }
                }
            }
        }

        private void ActivatePlayers()
        {
            foreach (SinglePlayer player in PlayerManager.Instance.PlayerData)
                player.CanPlay = true;
        }
    }
}
