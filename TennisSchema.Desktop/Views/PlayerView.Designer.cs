namespace TennisSchema.Desktop.Views
{
    partial class PlayerView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listViewPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPlayers.Location = new System.Drawing.Point(0, 0);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(150, 150);
            this.listViewPlayers.TabIndex = 1;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewPlayers);
            this.Name = "PlayerView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPlayers;
    }
}
