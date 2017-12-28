using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSchema
{
    public class Match
    {
        #region Field Region

        protected bool isInCalendar;
        protected string setup;
        protected DateTime date;

        #endregion

        #region Property Region

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

        #endregion

        #region Constructor Region

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

        #endregion

        #region Method Region

        public string GetDate()
        {
            string tempDate;

            if (Date == DateTime.MinValue)
                tempDate = "Date not specified. ";
            else
                tempDate = Date.ToString(PlayerManager.DATETIME_DISPLAY_FORMAT);

            return tempDate;
        }

        #endregion

        #region Virtual Method Region

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

        #endregion
    }
}