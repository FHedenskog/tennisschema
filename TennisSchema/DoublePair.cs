using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchema
{
    public class DoublePair
    {
        #region Field Region

        private string firstPlayer;
        private string secondPlayer;
        private string name;
        private int ranking;

        #endregion

        #region Property Region

        public string FirstPlayer
        {
            get { return firstPlayer; }
            private set { firstPlayer = value; }
        }

        public string SecondPlayer
        {
            get { return secondPlayer; }
            private set { secondPlayer = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Ranking
        {
            get { return ranking; }
            set { ranking = value; }
        }

        #endregion

        #region Constructor Region

        public DoublePair(string player1, string player2)
        {
            FirstPlayer = player1;
            SecondPlayer = player2;
            Name = player1 + ", " + player2;
            Ranking = 99;
        }

        #endregion

        #region Method Region

        public override string ToString()
        {
            string toString = Name;

            return toString;
        }

        public string ToStringWithRank()
        {
            string toString = Name;
            toString += ". Rank: " + Ranking;

            return toString;
        }

        #endregion

        #region Virtual Method Region
        #endregion
    }
}