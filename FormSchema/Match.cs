using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSchema
{
    public class Match
    {
        protected bool isInCalendar;
        protected string setup;
        protected DateTime date;

        public bool IsInCalendar
        {
            get { return isInCalendar; }
            set { isInCalendar = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Setup
        {
            get { return setup; }
            protected set { setup = value; }
        }

        public Match()
        {
            IsInCalendar = false;
            Date = new DateTime();
        }

        public Match(DateTime date)
        {
            IsInCalendar = false;
            setup = "Empty Slot.";
            Date = date;
        }

        public string GetDate()
        {
            string tempDate;

            if (Date == DateTime.MinValue)
                tempDate = "Date not specified. ";
            else
                tempDate = Date.ToString(PlayerManager.DATETIME_DISPLAY_FORMAT);

            return tempDate;
        }

        public virtual bool PlayersReady()
        {
            throw new NotImplementedException();
        }

        public virtual void RestPlayers()
        {
            throw new NotImplementedException();
        }

        public virtual void AddToCalendar()
        {
            PlayerManager.Instance.Matches.Add(this);
            IsInCalendar = true;
        }
    }
}