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
    public partial class NewPlayerForm : Form
    {
        private SinglePlayer _singlePlayer;

        public SinglePlayer SinglePlayer { get { return _singlePlayer; } set { _singlePlayer = value; } }

        public NewPlayerForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(OnNewPlayerFormLoad);
            this.FormClosing += new FormClosingEventHandler(OnNewPlayerFormClosing);

            btnOK.Click += new EventHandler(OnOKButtonClick);
            btnCancel.Click += new EventHandler(OnCancelButtonClick);
        }

        private void OnNewPlayerFormLoad(object sender, EventArgs e)
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

        private void OnNewPlayerFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void OnOKButtonClick(object sender, EventArgs e)
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

            _singlePlayer = new SinglePlayer();
            _singlePlayer.Name = tbName.Text;
            _singlePlayer.PlayingSingle = cboPlayingSingle.Checked;
            _singlePlayer.PlayingDouble = cboPlayingDouble.Checked;
            _singlePlayer.CanPlay = true;

            if (!cboPlayingDouble.Enabled)
                _singlePlayer.IsInTeam = true;
            else
                _singlePlayer.IsInTeam = false;
            
            
            this.FormClosing -= OnNewPlayerFormClosing;
            this.Close();
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            _singlePlayer = null;

            this.FormClosing -= OnNewPlayerFormClosing;
            this.Close();
        }
    }
}
