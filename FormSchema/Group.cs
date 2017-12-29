using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSchema
{
    public class Group
    {
        protected readonly List<Match> schedule = new List<Match>();
        protected Match nextMatch;

        protected int allowedSize;
        protected int matchesLeft;
        protected float percentageFinished;
        protected int index;
        protected string name;

        public List<Match> Schedule
        {
            get { return schedule; }
        }

        public Match NextMatch
        {
            get { return nextMatch; }
            protected set { nextMatch = value; }
        }

        public int AllowedSize
        {
            get { return allowedSize; }
            protected set { allowedSize = value; }
        }

        public int MatchesLeft
        {
            get { return matchesLeft; }
            protected set
            {
                if (value >= schedule.Count)
                    matchesLeft = schedule.Count;
                else if (value < 0)
                    matchesLeft = 0;
                else
                    matchesLeft = value;
            }
        }

        public float PercentageFinished
        {
            get { return percentageFinished; }
            set
            {
                if (value >= 1f)
                    percentageFinished = 1f;
                else if (value < 0f)
                    percentageFinished = 0f;
                else
                    percentageFinished = value;
            }
        }

        public int Index
        {
            get { return index; }
            private set { index = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public Group(int allowedSize, int index)
        {
            AllowedSize = allowedSize;
            Index = index;
            Name = "Group " + Index.ToString();
        }

        public virtual void AddToGroup(object entry)
        {
        }

        public virtual void GenerateSchedule()
        {
        }

        public virtual void PrintGroupMembers()
        {
        }

        public virtual void PrintMatchOrder()
        {
        }

        public virtual void SetNextMatch()
        {
        }

        public virtual bool AddToCalendar(DateTime matchDate)
        {
            return false;
        }

        public override string ToString()
        {
            string toString = Name;

            return toString;
        }
    }
}