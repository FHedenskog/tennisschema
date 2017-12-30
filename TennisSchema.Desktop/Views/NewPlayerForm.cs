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
        private Player _player;

        public Player Player { get { return _player; } set { _player = value; } }

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
            if (Player != null)
            {
                tbName.Text = Player.Name;
                cboPlayingSingle.Checked = Player.PlayingSingle;
                cboPlayingDouble.Checked = Player.PlayingDouble;

                if (Player.IsInTeam)
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

            _player = new Player();
            _player.Name = tbName.Text;
            _player.PlayingSingle = cboPlayingSingle.Checked;
            _player.PlayingDouble = cboPlayingDouble.Checked;
            _player.CanPlay = true;

            if (!cboPlayingDouble.Enabled)
                _player.IsInTeam = true;
            else
                _player.IsInTeam = false;
            
            
            this.FormClosing -= OnNewPlayerFormClosing;
            this.Close();
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            _player = null;

            this.FormClosing -= OnNewPlayerFormClosing;
            this.Close();
        }
    }
}
