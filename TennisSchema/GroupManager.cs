using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchema
{
    public class GroupManager
    {
        #region Field Region

        static List<SinglePlayer> players;
        static List<DoublePair> doublePairs;

        int playersPlayingSingle;
        
        readonly List<Group> groups = new List<Group>();

        int singleGroupsCap;
        int numberOfSingleGroups;

        int maxSingleGroupCount;
        int minSingleGroupCount;

        readonly List<DoubleGroup> doubleGroups = new List<DoubleGroup>();

        int doubleGroupsCap;
        int numberOfDoubleGroups;

        int maxDoubleGroupCount;
        int minDoubleGroupCount;

        int currentDay;
        int previousDay;

        #endregion

        #region Property Region

        public static List<SinglePlayer> Players
        {
            get { return players; }
            private set { players = value; }
        }

        public static List<DoublePair> DoublePairs
        {
            get { return doublePairs; }
            private set { doublePairs = value; }
        }

        public List<Group> Groups
        {
            get { return groups; }
        }

        public List<DoubleGroup> DoubleGroups
        {
            get { return doubleGroups; }
        }

        #endregion

        #region Constructor Region

        public GroupManager(List<SinglePlayer> players, List<DoublePair> doublePairs)
        {
            Players = players;
            DoublePairs = doublePairs;

            int singlePlayersCount = 0;
            foreach (SinglePlayer player in Players)
            {
                if (player.PlayingSingle)
                    singlePlayersCount++;
            }

            playersPlayingSingle = singlePlayersCount;

            Initialize();
        }

        #endregion

        #region Public Method Region

        private void Initialize()
        {
            InitializeValues();

            FineTuneSingleGroupValues();

            if (DoublePairs.Count > 0)
                FineTuneDoubleGroupValues();

            CreateGroups();

            AddPlayers();

            GenerateSchedule();

            PrintGroupMembers();

            PrintMatchOrder();

            AddToCalendar();

            PrintSchedule();
        }

        #endregion

        #region Private Method Region

        private void InitializeValues()
        {
            if (playersPlayingSingle <= 7)
            {
                singleGroupsCap = 2;
                maxSingleGroupCount = 5;
                minSingleGroupCount = 3;
            }

            else if (playersPlayingSingle <= 11)
            {
                singleGroupsCap = 2;
                maxSingleGroupCount = 6;
                minSingleGroupCount = 4;
            }

            else if (playersPlayingSingle >= 12)
            {
                singleGroupsCap = 5;
                maxSingleGroupCount = 5;
                minSingleGroupCount = 4;
            }

            //Doublepairs initialize group values
            if (DoublePairs.Count <= 10)
            {
                doubleGroupsCap = 1;
                maxDoubleGroupCount = 10;
                minDoubleGroupCount = 3;
            }

            else if (DoublePairs.Count <= 20)
            {
                doubleGroupsCap = 2;
                maxDoubleGroupCount = 10;
                minDoubleGroupCount = 5;
            }

            else if (DoublePairs.Count <= 30)
            {
                doubleGroupsCap = 3;
                maxDoubleGroupCount = 10;
                minDoubleGroupCount = 5;
            }
        }

        private void FineTuneSingleGroupValues()
        {
            int currentMaxGroupCount = minSingleGroupCount;

            int currentNumberOfGroups = 1;

            while (currentNumberOfGroups <= singleGroupsCap)
            {
                while (currentMaxGroupCount <= maxSingleGroupCount)
                {
                    if (currentMaxGroupCount * currentNumberOfGroups >= playersPlayingSingle)
                    {
                        maxSingleGroupCount = currentMaxGroupCount;
                        numberOfSingleGroups = currentNumberOfGroups;
                        return;
                    }

                    currentMaxGroupCount++;
                }

                currentNumberOfGroups++;
                currentMaxGroupCount = minSingleGroupCount;
            }
        }

        private void FineTuneDoubleGroupValues()
        {
            int currentMaxGroupCount = minDoubleGroupCount;

            int currentNumberOfGroups = 1;

            while (currentNumberOfGroups <= doubleGroupsCap)
            {
                while (currentMaxGroupCount <= maxDoubleGroupCount)
                {
                    if (currentMaxGroupCount * currentNumberOfGroups >= DoublePairs.Count)
                    {
                        maxDoubleGroupCount = currentMaxGroupCount;
                        numberOfDoubleGroups = currentNumberOfGroups;
                        return;
                    }

                    currentMaxGroupCount++;
                }

                currentNumberOfGroups++;
                currentMaxGroupCount = minDoubleGroupCount;
            }
        }

        private void CreateGroups()
        {
            int numberOfRemainderGroups = maxSingleGroupCount * numberOfSingleGroups - playersPlayingSingle;
            int singleGroupIndex = 1;
            for (int i = 0; i < numberOfSingleGroups; i++)
            {
                if (i < numberOfSingleGroups - numberOfRemainderGroups)
                    Groups.Add(new SingleGroup(maxSingleGroupCount, singleGroupIndex));
                else
                    Groups.Add(new SingleGroup(maxSingleGroupCount - 1, singleGroupIndex));

                singleGroupIndex++;
            }

            numberOfRemainderGroups = maxDoubleGroupCount * numberOfDoubleGroups - DoublePairs.Count;
            int doubleGroupIndex = 1;
            for (int i = 0; i < numberOfDoubleGroups; i++)
            {
                if (i < numberOfDoubleGroups - numberOfRemainderGroups)
                    Groups.Add(new DoubleGroup(maxDoubleGroupCount, doubleGroupIndex));
                else
                    Groups.Add(new DoubleGroup(maxDoubleGroupCount - 1, doubleGroupIndex));

                doubleGroupIndex++;
            }
        }

        private void AddPlayers()
        {
            int playerIdx = 0;
            SingleGroup singleGroup;

            foreach (Group group in Groups)
            {
                if (group is SingleGroup)
                {
                    singleGroup = group as SingleGroup;
                    while (playerIdx < Players.Count)
                    {
                        if (!Players[playerIdx].PlayingSingle)
                        {
                            playerIdx++;
                            continue;
                        }

                        if (singleGroup.Players.Count >= singleGroup.AllowedSize)
                            break;

                        singleGroup.AddToGroup(Players[playerIdx]);
                        playerIdx++;
                    }
                }
            }

            int pairIdx = 0;
            DoubleGroup doubleGroup;

            foreach (Group group in Groups)
            {
                if (group is DoubleGroup)
                {
                    doubleGroup = group as DoubleGroup;
                    while (pairIdx < DoublePairs.Count)
                    {
                        if (doubleGroup.Pairs.Count >= doubleGroup.AllowedSize)
                            break;

                        doubleGroup.AddToGroup(DoublePairs[pairIdx]);
                        pairIdx++;
                    }
                }
            }
        }

        private void GenerateSchedule()
        {
            foreach (Group group in Groups)
            {
                group.GenerateSchedule();
            }
        }

        private void PrintGroupMembers()
        {
            foreach (Group group in Groups)
            {
                Console.WriteLine("Members in group {0}", (Groups.IndexOf(group)) + 1);
                group.PrintGroupMembers();
            }

            Console.WriteLine();
        }

        private void PrintMatchOrder()
        {
            foreach (Group group in Groups)
            {
                Console.WriteLine("Match order in group {0}", (groups.IndexOf(group)) + 1);
                group.PrintMatchOrder();
            }
        }

        private void AddToCalendar()
        {
            currentDay = Calendar.Spring2016[0].Day;

            for (int i = 0; i < Calendar.Spring2016.Count; i++)
            {
                previousDay = currentDay;
                currentDay = Calendar.Spring2016[i].Day;

                if (currentDay != previousDay)
                    ActivatePlayers();

                int[] matchesLeft = new int[Groups.Count];
                float[] percentageFinished = new float[Groups.Count];

                for (int j = 0; j < Groups.Count; j++)
                {                       
                    Groups[j].SetNextMatch();

                    matchesLeft[j] = Groups[j].MatchesLeft;
                    percentageFinished[j] = Groups[j].PercentageFinished;
                }
                if (matchesLeft.Max() <= 0)
                    return;

                int currentIndex = Array.IndexOf(percentageFinished, percentageFinished.Min());
                int attempts = 0;

                while (attempts < Groups.Count)
                {
                    if (Groups[currentIndex].AddToCalendar(Calendar.Spring2016[i]))
                        break;
                    else
                    {
                        percentageFinished[currentIndex] = 1f;
                        currentIndex = Array.IndexOf(percentageFinished, percentageFinished.Min());
                    }

                    attempts++;

                    if (attempts == Groups.Count)
                    {
                        Match nextMatch = new Match(Calendar.Spring2016[i]);
                        nextMatch.AddToCalendar();
                    }
                }
            }
        }

        private void ActivatePlayers()
        {
            foreach (SinglePlayer player in Players)
                player.CanPlay = true;
        }

        private void PrintSchedule()
        {
            Console.WriteLine("Schedule for Spring of 2016.");
            foreach (Match match in Calendar.Matches)
            {
                string currentMatch = match.GetDate() + match.Setup;
                Console.WriteLine(currentMatch);

            }
        }

        public static SinglePlayer GetPlayer(string name)
        {
            foreach (SinglePlayer player in Players)
            {
                if (player.Name == name)
                    return player;
            }

            return null;
        }

        #endregion

        #region Virtual Method Region
        #endregion
    }
}