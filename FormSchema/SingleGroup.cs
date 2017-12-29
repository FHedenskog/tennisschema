using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSchema
{
    public class SingleGroup : Group
    {
        readonly List<SinglePlayer> players = new List<SinglePlayer>();
        bool doubleRoundRobin;

        public List<SinglePlayer> Players
        {
            get { return players; }
        }

        public SingleGroup(int allowedSize, int index, bool playDoubleRoundRobin)
            : base(allowedSize, index)
        {
            PercentageFinished = 0f;
            doubleRoundRobin = playDoubleRoundRobin;
        }

        public void AddPlayer(SinglePlayer player)
        {
            players.Add(player);
        }

        public override void GenerateSchedule()
        {
            Schedule.Clear();

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
            else if (players.Count == 7)
                CreateScheduleOfSeven();
            else if (players.Count == 8)
                CreateScheduleOfEight();
            else if (players.Count == 9)
                CreateScheduleOfNine();
            else if (players.Count == 10)
                CreateScheduleOfTen();

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

        private void CreateScheduleOfTwo()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));

                if (!doubleRoundRobin)
                    break;

                round++;
            }
        }

        private void CreateScheduleOfThree()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));
                Schedule.Add(new SingleMatch(Players[0], Players[2], null));
                Schedule.Add(new SingleMatch(Players[1], Players[2], null));

                if (!doubleRoundRobin)
                    break;

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

                if (!doubleRoundRobin)
                    break;

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

                if (!doubleRoundRobin)
                    break;

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

                if (!doubleRoundRobin)
                    break;

                round++;
            }
        }

        private void CreateScheduleOfSeven()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[0], Players[3], null));
                Schedule.Add(new SingleMatch(Players[1], Players[4], null));
                Schedule.Add(new SingleMatch(Players[2], Players[5], null));
                Schedule.Add(new SingleMatch(Players[0], Players[6], null));
                Schedule.Add(new SingleMatch(Players[3], Players[4], null));
                Schedule.Add(new SingleMatch(Players[1], Players[2], null));
                Schedule.Add(new SingleMatch(Players[5], Players[6], null));
                Schedule.Add(new SingleMatch(Players[0], Players[4], null));
                Schedule.Add(new SingleMatch(Players[2], Players[3], null));
                Schedule.Add(new SingleMatch(Players[1], Players[5], null));
                Schedule.Add(new SingleMatch(Players[4], Players[6], null));
                Schedule.Add(new SingleMatch(Players[0], Players[2], null));
                Schedule.Add(new SingleMatch(Players[3], Players[5], null));
                Schedule.Add(new SingleMatch(Players[1], Players[6], null));
                Schedule.Add(new SingleMatch(Players[2], Players[4], null));
                Schedule.Add(new SingleMatch(Players[0], Players[5], null));
                Schedule.Add(new SingleMatch(Players[1], Players[3], null));
                Schedule.Add(new SingleMatch(Players[2], Players[6], null));
                Schedule.Add(new SingleMatch(Players[4], Players[5], null));
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));
                Schedule.Add(new SingleMatch(Players[3], Players[6], null));

                if (!doubleRoundRobin)
                    break;

                round++;
            }
        }

        private void CreateScheduleOfEight()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[1], Players[2], null));
                Schedule.Add(new SingleMatch(Players[0], Players[4], null));
                Schedule.Add(new SingleMatch(Players[3], Players[6], null));
                Schedule.Add(new SingleMatch(Players[5], Players[7], null));
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));
                Schedule.Add(new SingleMatch(Players[2], Players[3], null));
                Schedule.Add(new SingleMatch(Players[4], Players[5], null));
                Schedule.Add(new SingleMatch(Players[6], Players[7], null));
                Schedule.Add(new SingleMatch(Players[0], Players[3], null));
                Schedule.Add(new SingleMatch(Players[1], Players[4], null));
                Schedule.Add(new SingleMatch(Players[2], Players[7], null));
                Schedule.Add(new SingleMatch(Players[5], Players[6], null));
                Schedule.Add(new SingleMatch(Players[1], Players[3], null));
                Schedule.Add(new SingleMatch(Players[0], Players[7], null));
                Schedule.Add(new SingleMatch(Players[4], Players[6], null));
                Schedule.Add(new SingleMatch(Players[2], Players[5], null));
                Schedule.Add(new SingleMatch(Players[1], Players[7], null));
                Schedule.Add(new SingleMatch(Players[3], Players[4], null));
                Schedule.Add(new SingleMatch(Players[0], Players[5], null));
                Schedule.Add(new SingleMatch(Players[2], Players[6], null));
                Schedule.Add(new SingleMatch(Players[3], Players[7], null));
                Schedule.Add(new SingleMatch(Players[1], Players[5], null));
                Schedule.Add(new SingleMatch(Players[2], Players[4], null));
                Schedule.Add(new SingleMatch(Players[0], Players[6], null));
                Schedule.Add(new SingleMatch(Players[3], Players[5], null));
                Schedule.Add(new SingleMatch(Players[4], Players[7], null));
                Schedule.Add(new SingleMatch(Players[1], Players[6], null));
                Schedule.Add(new SingleMatch(Players[0], Players[2], null));

                if (!doubleRoundRobin)
                    break;

                round++;
            }
        }

        private void CreateScheduleOfNine()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[0], Players[8], null));
                Schedule.Add(new SingleMatch(Players[1], Players[7], null));
                Schedule.Add(new SingleMatch(Players[2], Players[6], null));
                Schedule.Add(new SingleMatch(Players[3], Players[5], null));
                Schedule.Add(new SingleMatch(Players[0], Players[4], null));
                Schedule.Add(new SingleMatch(Players[1], Players[8], null));
                Schedule.Add(new SingleMatch(Players[2], Players[7], null));
                Schedule.Add(new SingleMatch(Players[3], Players[6], null));
                Schedule.Add(new SingleMatch(Players[4], Players[5], null));
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));
                Schedule.Add(new SingleMatch(Players[2], Players[8], null));
                Schedule.Add(new SingleMatch(Players[3], Players[7], null));
                Schedule.Add(new SingleMatch(Players[4], Players[6], null));
                Schedule.Add(new SingleMatch(Players[0], Players[5], null));
                Schedule.Add(new SingleMatch(Players[1], Players[2], null));
                Schedule.Add(new SingleMatch(Players[3], Players[8], null));
                Schedule.Add(new SingleMatch(Players[4], Players[7], null));
                Schedule.Add(new SingleMatch(Players[5], Players[6], null));
                Schedule.Add(new SingleMatch(Players[0], Players[2], null));
                Schedule.Add(new SingleMatch(Players[1], Players[3], null));
                Schedule.Add(new SingleMatch(Players[4], Players[8], null));
                Schedule.Add(new SingleMatch(Players[5], Players[7], null));
                Schedule.Add(new SingleMatch(Players[0], Players[6], null));
                Schedule.Add(new SingleMatch(Players[2], Players[3], null));
                Schedule.Add(new SingleMatch(Players[1], Players[4], null));
                Schedule.Add(new SingleMatch(Players[5], Players[8], null));
                Schedule.Add(new SingleMatch(Players[6], Players[7], null));
                Schedule.Add(new SingleMatch(Players[0], Players[3], null));
                Schedule.Add(new SingleMatch(Players[2], Players[4], null));
                Schedule.Add(new SingleMatch(Players[1], Players[5], null));
                Schedule.Add(new SingleMatch(Players[6], Players[8], null));
                Schedule.Add(new SingleMatch(Players[0], Players[7], null));
                Schedule.Add(new SingleMatch(Players[3], Players[4], null));
                Schedule.Add(new SingleMatch(Players[2], Players[5], null));
                Schedule.Add(new SingleMatch(Players[1], Players[6], null));
                Schedule.Add(new SingleMatch(Players[7], Players[8], null));

                if (!doubleRoundRobin)
                    break;

                round++;
            }
        }

        private void CreateScheduleOfTen()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new SingleMatch(Players[0], Players[3], null));
                Schedule.Add(new SingleMatch(Players[5], Players[8], null));
                Schedule.Add(new SingleMatch(Players[1], Players[4], null));
                Schedule.Add(new SingleMatch(Players[6], Players[9], null));
                Schedule.Add(new SingleMatch(Players[0], Players[2], null));
                Schedule.Add(new SingleMatch(Players[5], Players[7], null));
                Schedule.Add(new SingleMatch(Players[3], Players[4], null));
                Schedule.Add(new SingleMatch(Players[8], Players[9], null));
                Schedule.Add(new SingleMatch(Players[1], Players[2], null));
                Schedule.Add(new SingleMatch(Players[6], Players[7], null));
                Schedule.Add(new SingleMatch(Players[0], Players[4], null));
                Schedule.Add(new SingleMatch(Players[5], Players[9], null));
                Schedule.Add(new SingleMatch(Players[1], Players[3], null));
                Schedule.Add(new SingleMatch(Players[6], Players[8], null));
                Schedule.Add(new SingleMatch(Players[2], Players[4], null));
                Schedule.Add(new SingleMatch(Players[7], Players[9], null));
                Schedule.Add(new SingleMatch(Players[0], Players[1], null));
                Schedule.Add(new SingleMatch(Players[5], Players[6], null));
                Schedule.Add(new SingleMatch(Players[2], Players[3], null));
                Schedule.Add(new SingleMatch(Players[7], Players[8], null));
                Schedule.Add(new SingleMatch(Players[4], Players[9], null));
                Schedule.Add(new SingleMatch(Players[0], Players[5], null));
                Schedule.Add(new SingleMatch(Players[1], Players[6], null));
                Schedule.Add(new SingleMatch(Players[2], Players[7], null));
                Schedule.Add(new SingleMatch(Players[3], Players[8], null));
                Schedule.Add(new SingleMatch(Players[4], Players[5], null));
                Schedule.Add(new SingleMatch(Players[1], Players[9], null));
                Schedule.Add(new SingleMatch(Players[0], Players[7], null));
                Schedule.Add(new SingleMatch(Players[3], Players[6], null));
                Schedule.Add(new SingleMatch(Players[2], Players[8], null));
                Schedule.Add(new SingleMatch(Players[1], Players[5], null));
                Schedule.Add(new SingleMatch(Players[4], Players[7], null));
                Schedule.Add(new SingleMatch(Players[3], Players[9], null));
                Schedule.Add(new SingleMatch(Players[0], Players[8], null));
                Schedule.Add(new SingleMatch(Players[2], Players[6], null));
                Schedule.Add(new SingleMatch(Players[1], Players[7], null));
                Schedule.Add(new SingleMatch(Players[3], Players[5], null));
                Schedule.Add(new SingleMatch(Players[4], Players[8], null));
                Schedule.Add(new SingleMatch(Players[2], Players[9], null));
                Schedule.Add(new SingleMatch(Players[0], Players[6], null));
                Schedule.Add(new SingleMatch(Players[3], Players[7], null));
                Schedule.Add(new SingleMatch(Players[1], Players[8], null));
                Schedule.Add(new SingleMatch(Players[2], Players[5], null));
                Schedule.Add(new SingleMatch(Players[4], Players[6], null));
                Schedule.Add(new SingleMatch(Players[0], Players[9], null));

                if (!doubleRoundRobin)
                    break;

                round++;
            }
        }

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
    }
}
