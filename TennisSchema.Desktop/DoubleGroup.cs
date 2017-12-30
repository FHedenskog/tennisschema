using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchema
{
    public class DoubleGroup : Group
    {
        readonly List<DoublePair> pairs = new List<DoublePair>();
        bool doubleRoundRobin;

        public List<DoublePair> Pairs { get { return pairs; } }

        public DoubleGroup(int allowedSize, int index, bool playDoubleRoundRobin)
            : base(allowedSize, index)
        {
            doubleRoundRobin = playDoubleRoundRobin;
        }

        public override void AddToGroup(object entry)
        {
            DoublePair pair = (DoublePair)entry;
            pairs.Add(pair);
        }

        public override void GenerateSchedule()
        {
            Schedule.Clear();

            if (Pairs.Count == 2)
                CreateScheduleOfTwo();
            else if (Pairs.Count == 3)
                CreateScheduleOfThree();
            else if (Pairs.Count == 4)
                CreateScheduleOfFour();
            else if (Pairs.Count == 5)
                CreateScheduleOfFive();
            else if (Pairs.Count == 6)
                CreateScheduleOfSix();
            else if (Pairs.Count == 7)
                CreateScheduleOfSeven();
            else if (Pairs.Count == 8)
                CreateScheduleOfEight();
            else if (Pairs.Count == 9)
                CreateScheduleOfNine();
            else if (Pairs.Count == 10)
                CreateScheduleOfTen();

            NextMatch = Schedule[0];
            MatchesLeft = Schedule.Count;
        }

        public override void PrintGroupMembers()
        {
            for (int i = 0; i < Pairs.Count; i++)
            {
                Console.WriteLine(Pairs[i].Name);
            }
        }

        public override void PrintMatchOrder()
        {
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine(schedule[i].Setup);
            }
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

        private void CreateScheduleOfTwo()
        {
            int round = 1;

            while (round < 3)
            {
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[1], null));

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
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[1], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[2], null));

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
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[1], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[3], null));

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
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[1], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[4], null));

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
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[1], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[5], null));

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
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[1], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[6], null));

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
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[1], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[6], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[2], null));

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
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[1], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[6], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[6], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[7], Pairs[8], null));

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
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[6], Pairs[9], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[8], Pairs[9], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[2], null));
                Schedule.Add(new DoubleMatch(Pairs[6], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[9], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[6], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[4], null));
                Schedule.Add(new DoubleMatch(Pairs[7], Pairs[9], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[1], null));
                Schedule.Add(new DoubleMatch(Pairs[5], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[3], null));
                Schedule.Add(new DoubleMatch(Pairs[7], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[9], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[9], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[9], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[9], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[3], Pairs[7], null));
                Schedule.Add(new DoubleMatch(Pairs[1], Pairs[8], null));
                Schedule.Add(new DoubleMatch(Pairs[2], Pairs[5], null));
                Schedule.Add(new DoubleMatch(Pairs[4], Pairs[6], null));
                Schedule.Add(new DoubleMatch(Pairs[0], Pairs[9], null));

                if (!doubleRoundRobin)
                    break;

                round++;
            }
        }
    }
}