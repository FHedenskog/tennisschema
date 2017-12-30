using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchema
{
    public class Player
    {
        public int PlayerId;
        public string Name;

        public bool CanPlay;

        public bool PlayingSingle;

        public bool PlayingDouble;

        public bool IsInTeam;

        public int Ranking;

        public Player()
        {
        }

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

        public void CopyStats(Player otherPlayer)
        {
            this.Name = otherPlayer.Name;
            this.CanPlay = otherPlayer.CanPlay;
            this.PlayingSingle = otherPlayer.PlayingSingle;
            this.PlayingDouble = otherPlayer.PlayingDouble;
            this.IsInTeam = otherPlayer.IsInTeam;
            this.Ranking = otherPlayer.Ranking;
        }

        public string FormatCSV()
        {
            string csv = "";

            csv += Name + ",";
            csv += CanPlay + ",";
            csv += PlayingSingle + ",";
            csv += PlayingDouble + ",";
            csv += IsInTeam + ",";
            csv += Ranking;

            return csv;
        }

        public void CopyCSVData(string csv)
        {
            string[] parts = csv.Split(',');
            Name = parts[0];
            CanPlay = bool.Parse(parts[1]);
            PlayingSingle = bool.Parse(parts[2]);
            PlayingDouble = bool.Parse(parts[3]);
            IsInTeam = bool.Parse(parts[4]);
            Ranking = int.Parse(parts[5]);
        }
    }
}