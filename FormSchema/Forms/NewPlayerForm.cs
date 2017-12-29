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
    public partial class NewPlayerForm : Form
    {
        #region Field Region

        SinglePlayer singlePlayer;

        #endregion

        #region Property Region

        public SinglePlayer SinglePlayer
        {
            get { return singlePlayer; }
            set { singlePlayer = value; }
        }

        #endregion

        public NewPlayerForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormNewPlayer_Load);
            this.FormClosing += new FormClosingEventHandler(FormNewPlayer_FormClosing);

            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        private void FormNewPlayer_Load(object sender, EventArgs e)
        {
            if (SinglePlayer != null)
            {
                tbName.Text = SinglePlayer.Name;
                cboPlayingSingle.Checked = SinglePlayer.PlayingSingle;
                cboPlayingDouble.Checked = SinglePlayer.PlayingDouble;

                if (SinglePlayer.IsInTeam)
                {
                    cboPlayingDouble.Enabled = false;
                }
                else
                {
                    cboPlayingDouble.Enabled = true;
                }
            }
        }

        private void FormNewPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("You must enter a name for the player.", "Error");
                return;
            }

            if (!cboPlayingSingle.Checked && !cboPlayingDouble.Checked)
            {
                MessageBox.Show("A player must sign up for either the singles competition, doubles competition or both.");
                return;
            }

            singlePlayer = new SinglePlayer();
            singlePlayer.Name = tbName.Text;
            singlePlayer.PlayingSingle = cboPlayingSingle.Checked;
            singlePlayer.PlayingDouble = cboPlayingDouble.Checked;
            singlePlayer.CanPlay = true;

            if (!cboPlayingDouble.Enabled)
                singlePlayer.IsInTeam = true;
            else
                singlePlayer.IsInTeam = false;
            
            
            this.FormClosing -= FormNewPlayer_FormClosing;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            singlePlayer = null;

            this.FormClosing -= FormNewPlayer_FormClosing;
            this.Close();
        }
    }
}
