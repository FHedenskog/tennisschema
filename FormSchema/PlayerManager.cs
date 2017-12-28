using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace FormSchema
{
    public class PlayerManager
    {
        #region Field Region

        private static PlayerManager instance;

        List<SinglePlayer> playerData = new List<SinglePlayer>();
        List<DoublePair> doubleData = new List<DoublePair>();
        List<string> playersPlayingDouble = new List<string>();

        List<Match> matches = new List<Match>();

        List<Group> groups = new List<Group>();

        List<DateTime> calendar = new List<DateTime>();

        const string CSV_FILENAME_MEMBERS = "memberlist.csv";
        const string CSV_FILENAME_TEAMS = "teamlist.csv";
        const string CSV_FILENAME_CALENDAR = "calendar.csv";

        public const string DATETIME_PERSISENCE_FORMAT = "yyyy-MM-dd HH:mm";
        public const string DATETIME_DISPLAY_FORMAT = "ddd dd MMM yyyy-MM-dd HH:mm";

        #endregion

        #region Property Region

        public static PlayerManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlayerManager();
                }

                return instance;
            }
        }

        public List<SinglePlayer> PlayerData
        {
            get { return playerData; }
        }

        public List<DoublePair> DoubleData
        {
            get { return doubleData; }
        }

        public List<string> PlayersPlayingDouble
        {
            get { return playersPlayingDouble; }
        }

        public List<Group> Groups
        {
            get { return groups; }
        }

        public List<DateTime> Calendar
        {
            get { return calendar; }
        }

        public List<Match> Matches
        {
            get { return matches; }
        }

        #endregion

        #region Constructor Region

        public PlayerManager()
        {
        }

        #endregion

        #region Method Region

        public void SetTeamStatus(DoublePair pair, bool status)
        {
            foreach (SinglePlayer player in PlayerData)
            {
                if (pair.FirstPlayer == player.Name)
                {
                    player.IsInTeam = status;
                }

                if (pair.SecondPlayer == player.Name)
                {
                    player.IsInTeam = status;
                }
            }
        }

        public SinglePlayer GetPlayer(string name)
        {
            foreach (SinglePlayer player in PlayerData)
            {
                if (name == player.Name)
                {
                    return player;
                }
            }
            return null;
        }

        public DoublePair GetPair(string name)
        {
            foreach (DoublePair pair in DoubleData)
            {
                if (name == pair.Name)
                {
                    return pair;
                }
            }
            return null;
        }

        public DateTime GetDate(string id)
        {
            foreach (DateTime date in Calendar)
            {
                if (date.ToString(DATETIME_DISPLAY_FORMAT) == id)
                {
                    return date;
                }
            }
            return new DateTime();
        }

        #endregion

        #region CSV Load and Save region

        public void SavePlayersCSV()
        {
            using (StreamWriter writer = new StreamWriter(CSV_FILENAME_MEMBERS))
            {
                foreach (SinglePlayer player in PlayerData)
                {
                    writer.WriteLine(player.FormatCSV());
                }
            }

            using (StreamWriter writer = new StreamWriter(CSV_FILENAME_TEAMS))
            {
                foreach (DoublePair pair in DoubleData)
                {
                    writer.WriteLine(pair.FormatCSV());
                }
            }
        }

        public void SaveCalendarCSV()
        {
            using (StreamWriter writer = new StreamWriter(CSV_FILENAME_CALENDAR))
            {
                foreach (DateTime date in Calendar)
                {
                    writer.WriteLine(date.ToString(DATETIME_PERSISENCE_FORMAT));
                }
            }
        }

        public void LoadPlayersCSV()
        {
            if (File.Exists(CSV_FILENAME_MEMBERS))
            {
                using (StreamReader reader = new StreamReader(CSV_FILENAME_MEMBERS))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        SinglePlayer temp = new SinglePlayer();
                        temp.CopyCSVData(line);
                        PlayerData.Add(temp);
                    }
                }
            }

            if (File.Exists(CSV_FILENAME_TEAMS))
            {
                using (StreamReader reader = new StreamReader(CSV_FILENAME_TEAMS))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        DoublePair temp = new DoublePair();
                        temp.CopyCSVData(line);
                        DoubleData.Add(temp);
                    }
                }
            }
        }

        public void LoadCalendarCSV()
        {
            if (File.Exists(CSV_FILENAME_CALENDAR))
            {
                using (StreamReader reader = new StreamReader(CSV_FILENAME_CALENDAR))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        DateTime temp = DateTime.ParseExact(line, DATETIME_PERSISENCE_FORMAT, CultureInfo.InvariantCulture);
                        Calendar.Add(temp);
                    }
                }
            }
        }

        #endregion

        #region Serializer Region

        public void Serialize<T>(string filename, T data)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextWriter writer = new XmlTextWriter(filename,
                System.Text.Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            ser.Serialize(writer, data);
        }

        public T Deserialize<T>(string filename)
        {
            T data;
            XmlSerializer ser = new XmlSerializer(typeof(T));

            XmlTextReader reader = new XmlTextReader(filename);
            data = (T)ser.Deserialize(reader);

            return data;
        }

        #endregion
    }
}