namespace TennisSchema.Views
{
    partial class SetPlayerRankingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRankings = new System.Windows.Forms.ListBox();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRankings
            // 
            this.lbRankings.FormattingEnabled = true;
            this.lbRankings.Location = new System.Drawing.Point(12, 12);
            this.lbRankings.Name = "lbRankings";
            this.lbRankings.Size = new System.Drawing.Size(221, 212);
            this.lbRankings.TabIndex = 0;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(12, 230);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(105, 23);
            this.btnIncrease.TabIndex = 3;
            this.btnIncrease.Text = "Increase Ranking";
            this.btnIncrease.UseVisualStyleBackColor = true;
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(128, 230);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(105, 23);
            this.btnDecrease.TabIndex = 4;
            this.btnDecrease.Text = "Decrease Ranking";
            this.btnDecrease.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(11, 259);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(221, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormSetPlayerRankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 291);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.lbRankings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetPlayerRankings";
            this.Text = "Set Player Rankings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRankings;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnOK;
    }
}