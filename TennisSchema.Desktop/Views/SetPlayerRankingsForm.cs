using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisSchema.Views
{
    public partial class SetPlayerRankingsForm : Form
    {
        public SetPlayerRankingsForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(OnSetPlayerRankingsFormLoad);
            this.FormClosing += new FormClosingEventHandler(OnSetPlayerRankingsFormClosing);

            lbRankings.SelectedIndexChanged += new EventHandler(OnSetPlayerRankingsSelectedIndexChanged);
            btnIncrease.Click += new EventHandler(OnIncreaseButtonClick);
            btnDecrease.Click += new EventHandler(OnDecreaseButtonClick);
            btnOK.Click += new EventHandler(OnOKButtonClick);
        }

        private void OnSetPlayerRankingsFormLoad(object sender, EventArgs e)
        {
            lbRankings.Items.Clear();
            int currentRank = 1;

            foreach (Player player in PlayerManager.Instance.PlayerData)
            {
                if (player.PlayingSingle)
                {
                    player.Ranking = currentRank;
                    lbRankings.Items.Add(player.ToStringWithRank());
                    currentRank++;
                }
                else
                {
                    player.Ranking = 999;
                }
            }
        }

        private void OnSetPlayerRankingsFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void OnSetPlayerRankingsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRankings.SelectedIndex == 0)
                btnIncrease.Enabled = false;
            else
                btnIncrease.Enabled = true;

            if (lbRankings.SelectedIndex == lbRankings.Items.Count - 1)
                btnDecrease.Enabled = false;
            else
                btnDecrease.Enabled = true;
        }

        private void OnIncreaseButtonClick(object sender, EventArgs e)
        {
            if (lbRankings.SelectedItem != null)
            {
                string promotedFullName = lbRankings.SelectedItem.ToString();
                string[] promotedParts = promotedFullName.Split(',');
                string promotedName = promotedParts[0].Trim();
                Player promotedPlayer = PlayerManager.Instance.GetPlayer(promotedName);
                promotedPlayer.Ranking -= 1;

                string demotedFullName = lbRankings.Items[lbRankings.SelectedIndex - 1].ToString();
                string[] demotedParts = demotedFullName.Split(',');
                string demotedName = demotedParts[0].Trim();
                Player demotedPlayer = PlayerManager.Instance.GetPlayer(demotedName);
                demotedPlayer.Ranking += 1;

                int newSelectedIndex = lbRankings.SelectedIndex - 1;
                

                FillRankingListBox(newSelectedIndex);
            }
        }

        private void OnDecreaseButtonClick(object sender, EventArgs e)
        {
            if (lbRankings.SelectedItem != null)
            {
                string demotedFullName = lbRankings.SelectedItem.ToString();
                string[] demotedParts = demotedFullName.Split(',');
                string demotedName = demotedParts[0].Trim();
                Player demotedPlayer = PlayerManager.Instance.GetPlayer(demotedName);
                demotedPlayer.Ranking += 1;

                string promotedFullName = lbRankings.Items[lbRankings.SelectedIndex + 1].ToString();
                string[] promotedParts = promotedFullName.Split(',');
                string promotedName = promotedParts[0].Trim();
                Player promotedPlayer = PlayerManager.Instance.GetPlayer(promotedName);
                promotedPlayer.Ranking -= 1;

                int newSelectedIndex = lbRankings.SelectedIndex + 1;

                FillRankingListBox(newSelectedIndex);
            }
        }

        private void OnOKButtonClick(object sender, EventArgs e)
        {
            this.FormClosing -= OnSetPlayerRankingsFormClosing;
            this.Close();
        }

        private void FillRankingListBox(int newSelectedIndex)
        {
            int playerCount = lbRankings.Items.Count;
            lbRankings.Items.Clear();

            int currentRank = 1;
            while (currentRank <= playerCount)
            {
                foreach (Player player in PlayerManager.Instance.PlayerData)
                {
                    if (player.Ranking == currentRank)
                    {
                        lbRankings.Items.Add(player.ToStringWithRank());
                        break;
                    }
                }
                currentRank++;
            }

            lbRankings.SetSelected(newSelectedIndex, true);
        }
    }
}
