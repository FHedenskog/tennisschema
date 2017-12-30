using PersistenceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisSchema.Views
{
    public partial class NewPairForm : Form
    {
        Pair _pair;

        public Pair Pair
        {
            get { return _pair; }
            set { _pair = value; }
        }

        public NewPairForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(OnNewPairFormLoad);
            this.FormClosing += new FormClosingEventHandler(OnNewPairFormClosing);

            btnOK.Click += new EventHandler(OnOKButtonClick);
            btnCancel.Click += new EventHandler(OnCancelButtonClick);
        }

        private void OnNewPairFormLoad(object sender, EventArgs e)
        {
            foreach (var player in PlayerManager.Instance.Players)
            {
                if (player.PlayingDouble && player.PairId == default(int))
                {
                    cbPlayer1.Items.Add(player.ToString());
                    cbPlayer2.Items.Add(player.ToString());
                }
            }
        }

        private void OnNewPairFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void OnOKButtonClick(object sender, EventArgs e)
        {
            if (cbPlayer1.SelectedItem == null || cbPlayer2.SelectedItem == null)
            {
                MessageBox.Show("You must select two players in order to create a pair.", "Error");
                return;
            }

            if (cbPlayer1.SelectedItem == cbPlayer2.SelectedItem)
            {
                MessageBox.Show("A player cannot form a pair with itself.");
                return;
            }

            string player1name = cbPlayer1.SelectedItem.ToString();
            string player2name = cbPlayer2.SelectedItem.ToString();
            var pair = new Pair();
            pair.PairId = PlayerManager.Instance.Pairs.Max(x => x.PairId) + 1;
            var player1 = PlayerManager.Instance.Players.Single(x => x.Name == player1name);
            player1.PairId = pair.PairId;
            var player2 = PlayerManager.Instance.Players.Single(x => x.Name == player2name);
            player2.PairId = pair.PairId;
            pair.Players.Add(player1);
            pair.Players.Add(player2);
            pair.Ranking = 99;
            Pair = pair;

            this.FormClosing -= OnNewPairFormClosing;
            this.Close();

        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            Pair = null;

            this.FormClosing -= OnNewPairFormClosing;
            this.Close();
        }
    }
}
