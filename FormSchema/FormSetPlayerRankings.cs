﻿using System;
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
    public partial class FormSetPlayerRankings : Form
    {
        public FormSetPlayerRankings()
        {
            InitializeComponent();

            this.Load += new EventHandler(FormSetPlayerRankings_Load);
            this.FormClosing += new FormClosingEventHandler(FormSetPlayerRankings_FormClosing);

            lbRankings.SelectedIndexChanged += new EventHandler(FormSetPlayerRankings_SelectedIndexChanged);
            btnIncrease.Click += new EventHandler(btnIncrease_Click);
            btnDecrease.Click += new EventHandler(btnDecrease_Click);
            btnOK.Click += new EventHandler(btnOK_Click);
        }

        private void FormSetPlayerRankings_Load(object sender, EventArgs e)
        {
            lbRankings.Items.Clear();
            int currentRank = 1;

            foreach (SinglePlayer player in PlayerManager.Instance.PlayerData)
            {
                if (player.PlayingSingle)
                {
                    player.Ranking = currentRank;
                    lbRankings.Items.Add(player.ToStringWithRank());
                    currentRank++;
                }
                else
                {
                    player.Ranking = 999;
                }
            }
        }

        private void FormSetPlayerRankings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void FormSetPlayerRankings_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (lbRankings.SelectedItem != null)
            {
                string promotedFullName = lbRankings.SelectedItem.ToString();
                string[] promotedParts = promotedFullName.Split(',');
                string promotedName = promotedParts[0].Trim();
                SinglePlayer promotedPlayer = PlayerManager.Instance.GetPlayer(promotedName);
                promotedPlayer.Ranking -= 1;

                string demotedFullName = lbRankings.Items[lbRankings.SelectedIndex - 1].ToString();
                string[] demotedParts = demotedFullName.Split(',');
                string demotedName = demotedParts[0].Trim();
                SinglePlayer demotedPlayer = PlayerManager.Instance.GetPlayer(demotedName);
                demotedPlayer.Ranking += 1;

                int newSelectedIndex = lbRankings.SelectedIndex - 1;
                

                FillRankingListBox(newSelectedIndex);
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (lbRankings.SelectedItem != null)
            {
                string demotedFullName = lbRankings.SelectedItem.ToString();
                string[] demotedParts = demotedFullName.Split(',');
                string demotedName = demotedParts[0].Trim();
                SinglePlayer demotedPlayer = PlayerManager.Instance.GetPlayer(demotedName);
                demotedPlayer.Ranking += 1;

                string promotedFullName = lbRankings.Items[lbRankings.SelectedIndex + 1].ToString();
                string[] promotedParts = promotedFullName.Split(',');
                string promotedName = promotedParts[0].Trim();
                SinglePlayer promotedPlayer = PlayerManager.Instance.GetPlayer(promotedName);
                promotedPlayer.Ranking -= 1;

                int newSelectedIndex = lbRankings.SelectedIndex + 1;

                FillRankingListBox(newSelectedIndex);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.FormClosing -= FormSetPlayerRankings_FormClosing;
            this.Close();
        }

        private void FillRankingListBox(int newSelectedIndex)
        {
            int playerCount = lbRankings.Items.Count;
            lbRankings.Items.Clear();

            int currentRank = 1;
            while (currentRank <= playerCount)
            {
                foreach (SinglePlayer player in PlayerManager.Instance.PlayerData)
                {
                    if (player.Ranking == currentRank)
                    {
                        lbRankings.Items.Add(player.ToStringWithRank());
                        break;
                    }
                }
                currentRank++;
            }

            lbRankings.SetSelected(newSelectedIndex, true);
        }
    }
}