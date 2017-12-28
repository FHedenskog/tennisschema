using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSchema
{
    public class DoublePair
    {
        #region Field Region

        public string FirstPlayer;
        public string SecondPlayer;
        public int Ranking;

        #endregion

        #region Property Region

        public string Name
        {
            get { return FirstPlayer + ", " + SecondPlayer; }
        }

        #endregion

        #region Constructor Region

        public DoublePair()
        {
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

        public string FormatCSV()
        {
            string csv = "";
            csv += FirstPlayer + ",";
            csv += SecondPlayer + ",";
            csv += Ranking;

            return csv;
        }

        public void CopyCSVData(string csv)
        {
            string[] parts = csv.Split(',');
            FirstPlayer = parts[0];
            SecondPlayer = parts[1];
            Ranking = int.Parse(parts[2]);
        }

        #endregion

        #region Virtual Method Region
        #endregion
    }
}