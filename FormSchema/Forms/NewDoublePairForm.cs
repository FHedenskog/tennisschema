using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSchema
{
    public partial class NewDoublePairForm : Form
    {
        DoublePair doublePair;

        public DoublePair DoublePair
        {
            get { return doublePair; }
            set { doublePair = value; }
        }

        public NewDoublePairForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(OnNewDoublePairFormLoad);
            this.FormClosing += new FormClosingEventHandler(OnNewDoublePairFormClosing);

            btnOK.Click += new EventHandler(OnOKButtonClick);
            btnCancel.Click += new EventHandler(OnCancelButtonClick);
        }

        private void OnNewDoublePairFormLoad(object sender, EventArgs e)
        {
            foreach (SinglePlayer player in PlayerManager.Instance.PlayerData)
            {
                if (player.PlayingDouble && !player.IsInTeam)
                {
                    cbPlayer1.Items.Add(player.ToString());
                    cbPlayer2.Items.Add(player.ToString());
                }
            }
        }

        private void OnNewDoublePairFormClosing(object sender, FormClosingEventArgs e)
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
                MessageBox.Show("You must select two players in order to create a double\'s team.", "Error");
                return;
            }

            if (cbPlayer1.SelectedItem == cbPlayer2.SelectedItem)
            {
                MessageBox.Show("A player cannot form a team with itself.");
                return;
            }

            string player1name = cbPlayer1.SelectedItem.ToString();
            string player2name = cbPlayer2.SelectedItem.ToString();
            DoublePair = new DoublePair();
            DoublePair.FirstPlayer = player1name;
            DoublePair.SecondPlayer = player2name;
            DoublePair.Ranking = 99;

            this.FormClosing -= OnNewDoublePairFormClosing;
            this.Close();

        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            DoublePair = null;

            this.FormClosing -= OnNewDoublePairFormClosing;
            this.Close();
        }
    }
}
