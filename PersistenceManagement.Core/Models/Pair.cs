using PersistenceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceManagement.Core.Models
{
    public class Pair
    {
        public int PairId { get; set; }
        public List<Player> Players { get; set; }
        public int Ranking { get; set; }
        public bool CanPlay
        {
            get
            {
                return Players.All(x => x.CanPlay);
            }
        }

        public string Name
        {
            get
            {
                return string.Join(", ", Players.Select(x => x.Name));
            }
        }

        public Pair()
        {
            Players = new List<Player>();
        }

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

        public void Rest()
        {
            foreach (var player in Players)
            {

                player.CanPlay = false;
            }
        }

        public string FormatCSV()
        {
            string csv = "";
            csv += PairId + ",";
            csv += string.Join(",", Players.Select(x => x.PlayerId)) + ",";
            csv += Ranking;

            return csv;
        }

        public void CopyCSVData(string csv, IEnumerable<Player> players)
        {
            string[] parts = csv.Split(',');
            PairId = int.Parse(parts[0]);
            Players.Add(players.Single(x => x.PlayerId == int.Parse(parts[1])));
            Players.Add(players.Single(x => x.PlayerId == int.Parse(parts[1])));
            Ranking = int.Parse(parts[3]);
        }
    }
}