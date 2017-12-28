using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchema
{
    public class SinglePlayer
    {
        #region Field Region

        private string name;

        private bool canPlay;

        private bool playingSingle;

        private bool playingDouble;

        private bool isInTeam;

        private int ranking;

        #endregion

        #region Property Region

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public bool CanPlay
        {
            get { return canPlay; }
            set { canPlay = value; }
        }

        public bool PlayingSingle
        {
            get { return playingSingle; }
            private set { playingSingle = value; }
        }

        public bool PlayingDouble
        {
            get { return playingDouble; }
             set { playingDouble = value; }
        }

        public bool IsInTeam
        {
            get { return isInTeam; }
            set { isInTeam = value; }
        }

        public int Ranking
        {
            get { return ranking; }
            set { ranking = value; }
        }

        #endregion

        #region Constructor Region

        public SinglePlayer(string name, bool playingSingle, bool playingDouble)
        {
            Name = name;

            canPlay = true;
            PlayingSingle = playingSingle;
            PlayingDouble = playingDouble;
            IsInTeam = false;
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
            toString += ", Rank: " + Ranking;

            return toString;
        }

        public void CopyStats(SinglePlayer otherPlayer)
        {
            this.Name = otherPlayer.Name;
            this.PlayingSingle = otherPlayer.PlayingSingle;
            this.PlayingDouble = otherPlayer.PlayingDouble;
        }

        #endregion
    }
}