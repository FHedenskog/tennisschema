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
    public partial class SetDoublesRankingsForm : Form
    {
        public SetDoublesRankingsForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(OnSetDoublesRankingsFormLoad);
            this.FormClosing += new FormClosingEventHandler(OnSetDoublesRankingsFormClosing);

            lbRankings.SelectedIndexChanged += new EventHandler(OnSetDublesRankingsSelectedIndexChanged);
            btnIncrease.Click += new EventHandler(OnIncreaseButtonClick);
            btnDecrease.Click += new EventHandler(OnDecreaseButtonClick);
            btnOK.Click += new EventHandler(OnOKButtonClick);
        }

        private void OnSetDoublesRankingsFormLoad(object sender, EventArgs e)
        {
            lbRankings.Items.Clear();
            int currentRank = 1;

            foreach (DoublePair pair in PlayerManager.Instance.DoubleData)
            {
                pair.Ranking = currentRank;
                lbRankings.Items.Add(pair.ToStringWithRank());
                currentRank++;
            }
        }

        private void OnSetDoublesRankingsFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void OnSetDublesRankingsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRankings.SelectedIndex == 0)
                btnIncrease.Enabled = false;
            else
                btnIncrease.Enabled = true;

            if (lbRankings.SelectedIndex == lbRankings.Items.Count - 1)
                btnDecrease.Enabled = false;
            else
                btnDecrease.Enabled = true;
        }

        private void OnIncreaseButtonClick(object sender, EventArgs e)
        {
            if (lbRankings.SelectedItem != null)
            {
                string promotedFullName = lbRankings.SelectedItem.ToString();
                string[] promotedParts = promotedFullName.Split('.');
                string promotedName = promotedParts[0].Trim();
                DoublePair promotedPair = PlayerManager.Instance.GetPair(promotedName);
                promotedPair.Ranking -= 1;

                string demotedFullName = lbRankings.Items[lbRankings.SelectedIndex - 1].ToString();
                string[] demotedParts = demotedFullName.Split('.');
                string demotedName = demotedParts[0].Trim();
                DoublePair demotedPair = PlayerManager.Instance.GetPair(demotedName);
                demotedPair.Ranking += 1;

                int newSelectedIndex = lbRankings.SelectedIndex - 1;


                FillRankingListBox(newSelectedIndex);
            }
        }

        private void OnDecreaseButtonClick(object sender, EventArgs e)
        {
            if (lbRankings.SelectedItem != null)
            {
                string demotedFullName = lbRankings.SelectedItem.ToString();
                string[] demotedParts = demotedFullName.Split('.');
                string demotedName = demotedParts[0].Trim();
                DoublePair demotedPair = PlayerManager.Instance.GetPair(demotedName);
                demotedPair.Ranking += 1;

                string promotedFullName = lbRankings.Items[lbRankings.SelectedIndex + 1].ToString();
                string[] promotedParts = promotedFullName.Split('.');
                string promotedName = promotedParts[0].Trim();
                DoublePair promotedPair = PlayerManager.Instance.GetPair(promotedName);
                promotedPair.Ranking -= 1;

                int newSelectedIndex = lbRankings.SelectedIndex + 1;

                FillRankingListBox(newSelectedIndex);
            }
        }

        private void OnOKButtonClick(object sender, EventArgs e)
        {
            this.FormClosing -= OnSetDoublesRankingsFormClosing;
            this.Close();
        }

        private void FillRankingListBox(int newSelectedIndex)
        {
            int pairCount = lbRankings.Items.Count;
            lbRankings.Items.Clear();

            int currentRank = 1;
            while (currentRank <= pairCount)
            {
                foreach (DoublePair pair in PlayerManager.Instance.DoubleData)
                {
                    if (pair.Ranking == currentRank)
                    {
                        lbRankings.Items.Add(pair.ToStringWithRank());
                        break;
                    }
                }
                currentRank++;
            }

            lbRankings.SetSelected(newSelectedIndex, true);
        }
    }
}
