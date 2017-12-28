using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchema
{
    public class SingleGroup : Group
    {
        #region Field Region

        readonly List<SinglePlayer> players = new List<SinglePlayer>();

        #endregion

        #region Property Region

        public List<SinglePlayer> Players
        {
            get { return players; }
        }

        #endregion

        #region Constructor Region

        public SingleGroup(int allowedSize, int index)
            : base(allowedSize, index)
        {
            PercentageFinished = 0f;
        }

        #endregion

        #region Public Method Region

        public void AddPlayer(SinglePlayer player)
        {
            players.Add(player);
        }

        public override void GenerateSchedule()
        {
            if (players.Count == 2)
                CreateScheduleOfTwo();
            else if (players.Count == 3)
                CreateScheduleOfThree();
            else if (players.Count == 4)
                CreateScheduleOfFour();
            else if (players.Count == 5)
                CreateScheduleOfFive();
            else if (players.Count == 6)
                CreateScheduleOfSix();

            NextMatch = Schedule[0];
            MatchesLeft = Schedule.Count;
        }

        public override void PrintGroupMembers()
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine(players[i].Name);
            }
        }

        public override void PrintMatchOrder()
        {
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine(schedule[i].Setup);
            }
        }

        #endregion

        #region Schedule Method Region

        private void CreateScheduleOfTwo()
        {
            Schedule.Add(new SingleMatch(Players[0], Players[1], null));
            Schedule.Add(new SingleMatch(Players[0], Players[1], null));
        }

        private void CreateScheduleOfThree()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));
                Schedule.Add(new SingleMatch(Players[0], Players[2], null));
                Schedule.Add(new SingleMatch(Players[1], Players[2], null));

                round++;
            }
        }

        private void CreateScheduleOfFour()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));
                Schedule.Add(new SingleMatch(Players[2], Players[3], null));
                Schedule.Add(new SingleMatch(Players[1], Players[2], null));
                Schedule.Add(new SingleMatch(Players[0], Players[3], null));
                Schedule.Add(new SingleMatch(Players[0], Players[2], null));
                Schedule.Add(new SingleMatch(Players[1], Players[3], null));

                round++;
            }
        }

        private void CreateScheduleOfFive()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));
                Schedule.Add(new SingleMatch(Players[2], Players[3], null));
                Schedule.Add(new SingleMatch(Players[0], Players[4], null));
                Schedule.Add(new SingleMatch(Players[1], Players[2], null));
                Schedule.Add(new SingleMatch(Players[3], Players[4], null));
                Schedule.Add(new SingleMatch(Players[0], Players[2], null));
                Schedule.Add(new SingleMatch(Players[1], Players[3], null));
                Schedule.Add(new SingleMatch(Players[2], Players[4], null));
                Schedule.Add(new SingleMatch(Players[0], Players[3], null));
                Schedule.Add(new SingleMatch(Players[1], Players[4], null));

                round++;
            }
        }

        private void CreateScheduleOfSix()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));
                Schedule.Add(new SingleMatch(Players[2], Players[3], null));
                Schedule.Add(new SingleMatch(Players[4], Players[5], null));
                Schedule.Add(new SingleMatch(Players[0], Players[3], null));
                Schedule.Add(new SingleMatch(Players[1], Players[4], null));
                Schedule.Add(new SingleMatch(Players[2], Players[5], null));
                Schedule.Add(new SingleMatch(Players[1], Players[3], null));
                Schedule.Add(new SingleMatch(Players[0], Players[5], null));
                Schedule.Add(new SingleMatch(Players[2], Players[4], null));
                Schedule.Add(new SingleMatch(Players[1], Players[5], null));
                Schedule.Add(new SingleMatch(Players[0], Players[2], null));
                Schedule.Add(new SingleMatch(Players[3], Players[4], null));
                Schedule.Add(new SingleMatch(Players[1], Players[2], null));
                Schedule.Add(new SingleMatch(Players[0], Players[4], null));
                Schedule.Add(new SingleMatch(Players[3], Players[5], null));

                round++;
            }
        }

        #endregion

        #region Private Method Region

        #endregion

        #region Virtual Method Region

        public override void AddToGroup(object entry)
        {
            SinglePlayer player = (SinglePlayer)entry;
            players.Add(player);
        }

        public override void SetNextMatch()
        {
            if (MatchesLeft <= 0)
                return;

            if (NextMatch.PlayersReady())
                return;

            foreach (Match match in Schedule)
            {
                if (!match.IsInCalendar && match.PlayersReady())
                {
                    NextMatch = match;
                    return;
                }
            }
        }

        public override bool AddToCalendar(DateTime matchDate)
        {
            bool success = false;

            if (!NextMatch.PlayersReady())
                return success;

            if (MatchesLeft <= 0)
                return success;

            NextMatch.Date = matchDate;
            NextMatch.AddToCalendar();
            success = true;

            MatchesLeft -= 1;
            PercentageFinished = ((float)Schedule.Count - (float)MatchesLeft) / (float)Schedule.Count;

            if (MatchesLeft <= 0)
                return success;

            foreach (Match match in Schedule)
            {
                if (!match.IsInCalendar)
                {
                    NextMatch = match;
                    break;
                }
            }
            return success;
        }

        #endregion
    }
}
