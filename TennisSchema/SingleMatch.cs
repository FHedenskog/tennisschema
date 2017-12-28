using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchema
{
    public class SingleMatch : Match
    {
        #region Field Region

        private SinglePlayer player1;
        private SinglePlayer player2;

        #endregion

        #region Property Region

        public SinglePlayer Player1
        {
            get { return player1; }
            private set { player1 = value; }
        }

        public SinglePlayer Player2
        {
            get { return player2; }
            private set { player2 = value; }
        }

        #endregion

        #region Constructor Region

        public SingleMatch(SinglePlayer player1, SinglePlayer player2, DateTime? date)
            : base()
        {
            Player1 = player1;
            Player2 = player2;

            Setup = player1.Name + " - " + player2.Name;

            if (date.HasValue)
                Date = date.Value;
        }

        #endregion

        #region Method Region
        #endregion

        #region Virtual Method Region

        public override bool PlayersReady()
        {
            if (player1.CanPlay && player2.CanPlay)
                return true;
            else
                return false;
        }

        public override void AddToCalendar()
        {
            base.AddToCalendar();
            RestPlayers();
        }

        public override void RestPlayers()
        {
            player1.CanPlay = false;
            player2.CanPlay = false;
        }

        #endregion
    }
}