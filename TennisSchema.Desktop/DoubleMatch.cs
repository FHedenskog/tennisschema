using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchema
{
    public class DoubleMatch : Match
    {
        private DoublePair pair1;
        private DoublePair pair2;

        public DoublePair Pair1 { get { return pair1; } private set { pair1 = value; } }

        public DoublePair Pair2 { get { return pair2; } private set { pair2 = value; } }

        public DoubleMatch(DoublePair pair1, DoublePair pair2, DateTime? date)
            : base()
        {
            Pair1 = pair1;
            Pair2 = pair2;

            Setup = pair1.Name + " - " + pair2.Name;

            if (date.HasValue)
                Date = date.Value;
        }

        public override bool PlayersReady()
        {
            SinglePlayer pair1player1 = PlayerManager.Instance.GetPlayer(pair1.FirstPlayer);
            SinglePlayer pair1player2 = PlayerManager.Instance.GetPlayer(pair1.SecondPlayer);
            SinglePlayer pair2player1 = PlayerManager.Instance.GetPlayer(pair2.FirstPlayer);
            SinglePlayer pair2player2 = PlayerManager.Instance.GetPlayer(pair2.SecondPlayer);

            if (pair1player1.CanPlay &&
                pair1player2.CanPlay &&
                pair2player1.CanPlay &&
                pair2player2.CanPlay)
            {
                return true;
            }
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
            SinglePlayer pair1player1 = PlayerManager.Instance.GetPlayer(pair1.FirstPlayer);
            SinglePlayer pair1player2 = PlayerManager.Instance.GetPlayer(pair1.SecondPlayer);
            SinglePlayer pair2player1 = PlayerManager.Instance.GetPlayer(pair2.FirstPlayer);
            SinglePlayer pair2player2 = PlayerManager.Instance.GetPlayer(pair2.SecondPlayer);

            pair1player1.CanPlay = false;
            pair1player2.CanPlay = false;
            pair2player1.CanPlay = false;
            pair2player2.CanPlay = false;
        }
    }
}
