using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TennisSchema
{
    public static class Calendar
    {
        #region Field Region

        private readonly static List<DateTime> spring2016 = new List<DateTime>();
        private readonly static List<Match> matches = new List<Match>();

        #endregion

        #region Property Region

        public static List<Match> Matches
        {
            get { return matches; }
        }

        public static List<DateTime> Spring2016
        {
            get { return spring2016; }
        }

        #endregion

        #region Constructor Region

        static Calendar()
        {
            Spring2016.Add(new DateTime(2016, 1, 7, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 7, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 1, 10, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 10, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 10, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 10, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 10, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 10, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 1, 14, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 14, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 1, 17, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 17, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 17, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 17, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 17, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 17, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 1, 21, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 21, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 1, 24, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 24, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 24, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 24, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 24, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 24, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 1, 28, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 28, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 1, 31, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 31, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 31, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 31, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 31, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 1, 31, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 2, 4, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 4, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 2, 7, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 7, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 7, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 7, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 7, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 7, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 2, 11, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 11, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 2, 14, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 14, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 14, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 14, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 14, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 14, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 2, 18, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 18, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 2, 21, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 21, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 21, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 21, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 21, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 21, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 2, 25, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 25, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 2, 29, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 29, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 29, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 29, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 29, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 2, 29, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 3, 3, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 3, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 3, 6, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 6, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 6, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 6, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 6, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 6, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 3, 10, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 10, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 3, 13, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 13, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 13, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 13, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 13, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 13, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 3, 17, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 17, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 3, 20, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 20, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 20, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 20, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 20, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 20, 21, 0, 0));

            //OBS: Påskhelg
            Spring2016.Add(new DateTime(2016, 3, 24, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 24, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 3, 27, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 27, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 27, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 27, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 27, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 27, 21, 0, 0));
            //Slut på påskhelgen

            Spring2016.Add(new DateTime(2016, 3, 31, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 3, 31, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 4, 3, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 3, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 3, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 3, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 3, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 3, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 4, 7, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 7, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 4, 10, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 10, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 10, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 10, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 10, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 10, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 4, 14, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 14, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 4, 17, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 17, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 17, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 17, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 17, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 17, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 4, 21, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 21, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 4, 24, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 24, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 24, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 24, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 24, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 24, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 4, 28, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 4, 28, 20, 0, 0));

            //OBS: Första Maj
            Spring2016.Add(new DateTime(2016, 5, 1, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 1, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 1, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 1, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 1, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 1, 21, 0, 0));
            //Slut på Första Maj

            //OBS: Kristi Himmelfärdsdag och helg
            Spring2016.Add(new DateTime(2016, 5, 5, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 5, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 5, 8, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 8, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 8, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 8, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 8, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 8, 21, 0, 0));
            //Slut på Kristi himmelfärdsdag och helg

            Spring2016.Add(new DateTime(2016, 5, 12, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 12, 20, 0, 0));

            //OBS: Pingstafton och pingstdagen
            Spring2016.Add(new DateTime(2016, 5, 15, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 15, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 15, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 15, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 15, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 15, 21, 0, 0));
            //Slut på pingsthelgen

            Spring2016.Add(new DateTime(2016, 5, 19, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 19, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 5, 22, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 22, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 22, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 22, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 22, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 22, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 5, 26, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 26, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 5, 29, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 29, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 29, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 29, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 29, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 5, 29, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 6, 2, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 2, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 6, 5, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 5, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 5, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 5, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 5, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 5, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 6, 9, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 9, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 6, 12, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 12, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 12, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 12, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 12, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 12, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 6, 16, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 16, 20, 0, 0));

            Spring2016.Add(new DateTime(2016, 6, 19, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 19, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 19, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 19, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 19, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 19, 21, 0, 0));

            Spring2016.Add(new DateTime(2016, 6, 23, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 23, 20, 0, 0));

            //OBS: Dagen efter midsommardagen
            Spring2016.Add(new DateTime(2016, 6, 26, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 26, 17, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 26, 19, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 26, 20, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 26, 21, 0, 0));
            Spring2016.Add(new DateTime(2016, 6, 26, 21, 0, 0));
            //Slut
        }

        #endregion

        #region Method Region

        #endregion

        #region Virtual Method Region
        #endregion
    }
}
