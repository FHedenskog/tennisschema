namespace FormSchema
{
    partial class TennisSchemaGeneratorForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgPlayers = new System.Windows.Forms.TabPage();
            this.btnSavePlayers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.tpgSettings = new System.Windows.Forms.TabPage();
            this.btnClearDoubles = new System.Windows.Forms.Button();
            this.btnClearSingles = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboDoubleDouble = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSelectDoubleGroups = new System.Windows.Forms.Label();
            this.nudDoublesGroupSize = new System.Windows.Forms.NumericUpDown();
            this.lbDoubleGroups = new System.Windows.Forms.ListBox();
            this.cbDoubleGroups = new System.Windows.Forms.ComboBox();
            this.btnGenerateDoubleGroups = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTeamsPlayingDouble = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboSingleDouble = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelectSingleGroups = new System.Windows.Forms.Label();
            this.nudSinglesGroupSize = new System.Windows.Forms.NumericUpDown();
            this.lbSingleGroups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSingleGroups = new System.Windows.Forms.ComboBox();
            this.lblPlayersPlayingSingle = new System.Windows.Forms.Label();
            this.btnGenerateSingleGroups = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tpgCalendar = new System.Windows.Forms.TabPage();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnClearCalendar = new System.Windows.Forms.Button();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.btnRemoveTimeSlot = new System.Windows.Forms.Button();
            this.btnAddTimeSlot = new System.Windows.Forms.Button();
            this.lbCalendar = new System.Windows.Forms.ListBox();
            this.btnGenerateCalendar = new System.Windows.Forms.Button();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.cbHours = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveCalendar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpgPlayers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpgSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoublesGroupSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinglesGroupSize)).BeginInit();
            this.tpgCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgPlayers);
            this.tabControl1.Controls.Add(this.tpgSettings);
            this.tabControl1.Controls.Add(this.tpgCalendar);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tpgPlayers
            // 
            this.tpgPlayers.Controls.Add(this.btnSavePlayers);
            this.tpgPlayers.Controls.Add(this.groupBox2);
            this.tpgPlayers.Controls.Add(this.groupBox1);
            this.tpgPlayers.Location = new System.Drawing.Point(4, 22);
            this.tpgPlayers.Name = "tpgPlayers";
            this.tpgPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPlayers.Size = new System.Drawing.Size(568, 311);
            this.tpgPlayers.TabIndex = 0;
            this.tpgPlayers.Text = "Players";
            this.tpgPlayers.UseVisualStyleBackColor = true;
            // 
            // btnSavePlayers
            // 
            this.btnSavePlayers.Location = new System.Drawing.Point(470, 23);
            this.btnSavePlayers.Name = "btnSavePlayers";
            this.btnSavePlayers.Size = new System.Drawing.Size(92, 23);
            this.btnSavePlayers.TabIndex = 13;
            this.btnSavePlayers.Text = "Save Players";
            this.btnSavePlayers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTeams);
            this.groupBox2.Controls.Add(this.btnRemoveTeam);
            this.groupBox2.Controls.Add(this.btnAddTeam);
            this.groupBox2.Location = new System.Drawing.Point(242, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 297);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Teams";
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.Location = new System.Drawing.Point(6, 16);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(209, 251);
            this.lbTeams.TabIndex = 7;
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Location = new System.Drawing.Point(115, 275);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveTeam.TabIndex = 10;
            this.btnRemoveTeam.Text = "Remove Team";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(6, 275);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(100, 23);
            this.btnAddTeam.TabIndex = 8;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPlayers);
            this.groupBox1.Controls.Add(this.btnRemovePlayer);
            this.groupBox1.Controls.Add(this.btnEditPlayer);
            this.groupBox1.Controls.Add(this.btnAddPlayer);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 308);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of All Players";
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.Location = new System.Drawing.Point(6, 16);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(215, 251);
            this.lbPlayers.TabIndex = 2;
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(150, 275);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(71, 23);
            this.btnRemovePlayer.TabIndex = 1;
            this.btnRemovePlayer.Text = "Remove";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(78, 275);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(71, 23);
            this.btnEditPlayer.TabIndex = 3;
            this.btnEditPlayer.Text = "Edit";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(6, 275);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(71, 23);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // tpgSettings
            // 
            this.tpgSettings.Controls.Add(this.btnClearDoubles);
            this.tpgSettings.Controls.Add(this.btnClearSingles);
            this.tpgSettings.Controls.Add(this.groupBox4);
            this.tpgSettings.Controls.Add(this.groupBox3);
            this.tpgSettings.Location = new System.Drawing.Point(4, 22);
            this.tpgSettings.Name = "tpgSettings";
            this.tpgSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSettings.Size = new System.Drawing.Size(568, 311);
            this.tpgSettings.TabIndex = 1;
            this.tpgSettings.Text = "Settings";
            this.tpgSettings.UseVisualStyleBackColor = true;
            // 
            // btnClearDoubles
            // 
            this.btnClearDoubles.Enabled = false;
            this.btnClearDoubles.Location = new System.Drawing.Point(408, 45);
            this.btnClearDoubles.Name = "btnClearDoubles";
            this.btnClearDoubles.Size = new System.Drawing.Size(154, 23);
            this.btnClearDoubles.TabIndex = 9;
            this.btnClearDoubles.Text = "Clear Double Groups";
            this.btnClearDoubles.UseVisualStyleBackColor = true;
            // 
            // btnClearSingles
            // 
            this.btnClearSingles.Enabled = false;
            this.btnClearSingles.Location = new System.Drawing.Point(408, 16);
            this.btnClearSingles.Name = "btnClearSingles";
            this.btnClearSingles.Size = new System.Drawing.Size(154, 23);
            this.btnClearSingles.TabIndex = 8;
            this.btnClearSingles.Text = "Clear Single Groups";
            this.btnClearSingles.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboDoubleDouble);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblSelectDoubleGroups);
            this.groupBox4.Controls.Add(this.nudDoublesGroupSize);
            this.groupBox4.Controls.Add(this.lbDoubleGroups);
            this.groupBox4.Controls.Add(this.cbDoubleGroups);
            this.groupBox4.Controls.Add(this.btnGenerateDoubleGroups);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblTeamsPlayingDouble);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(210, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 299);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Double Group Settings";
            // 
            // cboDoubleDouble
            // 
            this.cboDoubleDouble.AutoSize = true;
            this.cboDoubleDouble.Location = new System.Drawing.Point(149, 61);
            this.cboDoubleDouble.Name = "cboDoubleDouble";
            this.cboDoubleDouble.Size = new System.Drawing.Size(15, 14);
            this.cboDoubleDouble.TabIndex = 11;
            this.cboDoubleDouble.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Double round-robin format:";
            // 
            // lblSelectDoubleGroups
            // 
            this.lblSelectDoubleGroups.AutoSize = true;
            this.lblSelectDoubleGroups.Enabled = false;
            this.lblSelectDoubleGroups.Location = new System.Drawing.Point(6, 113);
            this.lblSelectDoubleGroups.Name = "lblSelectDoubleGroups";
            this.lblSelectDoubleGroups.Size = new System.Drawing.Size(72, 13);
            this.lblSelectDoubleGroups.TabIndex = 9;
            this.lblSelectDoubleGroups.Text = "Select Group:";
            // 
            // nudDoublesGroupSize
            // 
            this.nudDoublesGroupSize.Enabled = false;
            this.nudDoublesGroupSize.Location = new System.Drawing.Point(148, 35);
            this.nudDoublesGroupSize.Name = "nudDoublesGroupSize";
            this.nudDoublesGroupSize.Size = new System.Drawing.Size(33, 20);
            this.nudDoublesGroupSize.TabIndex = 7;
            // 
            // lbDoubleGroups
            // 
            this.lbDoubleGroups.FormattingEnabled = true;
            this.lbDoubleGroups.Location = new System.Drawing.Point(9, 137);
            this.lbDoubleGroups.Name = "lbDoubleGroups";
            this.lbDoubleGroups.Size = new System.Drawing.Size(172, 160);
            this.lbDoubleGroups.TabIndex = 6;
            // 
            // cbDoubleGroups
            // 
            this.cbDoubleGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoubleGroups.Enabled = false;
            this.cbDoubleGroups.FormattingEnabled = true;
            this.cbDoubleGroups.Location = new System.Drawing.Point(83, 110);
            this.cbDoubleGroups.Name = "cbDoubleGroups";
            this.cbDoubleGroups.Size = new System.Drawing.Size(98, 21);
            this.cbDoubleGroups.TabIndex = 5;
            // 
            // btnGenerateDoubleGroups
            // 
            this.btnGenerateDoubleGroups.Enabled = false;
            this.btnGenerateDoubleGroups.Location = new System.Drawing.Point(9, 81);
            this.btnGenerateDoubleGroups.Name = "btnGenerateDoubleGroups";
            this.btnGenerateDoubleGroups.Size = new System.Drawing.Size(172, 23);
            this.btnGenerateDoubleGroups.TabIndex = 4;
            this.btnGenerateDoubleGroups.Text = "Generate Groups";
            this.btnGenerateDoubleGroups.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maximum Group Size:";
            // 
            // lblTeamsPlayingDouble
            // 
            this.lblTeamsPlayingDouble.AutoSize = true;
            this.lblTeamsPlayingDouble.Location = new System.Drawing.Point(147, 17);
            this.lblTeamsPlayingDouble.Name = "lblTeamsPlayingDouble";
            this.lblTeamsPlayingDouble.Size = new System.Drawing.Size(13, 13);
            this.lblTeamsPlayingDouble.TabIndex = 1;
            this.lblTeamsPlayingDouble.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teams in Doubles:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboSingleDouble);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblSelectSingleGroups);
            this.groupBox3.Controls.Add(this.nudSinglesGroupSize);
            this.groupBox3.Controls.Add(this.lbSingleGroups);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbSingleGroups);
            this.groupBox3.Controls.Add(this.lblPlayersPlayingSingle);
            this.groupBox3.Controls.Add(this.btnGenerateSingleGroups);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 299);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Single Group Settings";
            // 
            // cboSingleDouble
            // 
            this.cboSingleDouble.AutoSize = true;
            this.cboSingleDouble.Location = new System.Drawing.Point(151, 61);
            this.cboSingleDouble.Name = "cboSingleDouble";
            this.cboSingleDouble.Size = new System.Drawing.Size(15, 14);
            this.cboSingleDouble.TabIndex = 10;
            this.cboSingleDouble.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Double round-robin format:";
            // 
            // lblSelectSingleGroups
            // 
            this.lblSelectSingleGroups.AutoSize = true;
            this.lblSelectSingleGroups.Enabled = false;
            this.lblSelectSingleGroups.Location = new System.Drawing.Point(6, 113);
            this.lblSelectSingleGroups.Name = "lblSelectSingleGroups";
            this.lblSelectSingleGroups.Size = new System.Drawing.Size(72, 13);
            this.lblSelectSingleGroups.TabIndex = 8;
            this.lblSelectSingleGroups.Text = "Select Group:";
            // 
            // nudSinglesGroupSize
            // 
            this.nudSinglesGroupSize.Enabled = false;
            this.nudSinglesGroupSize.Location = new System.Drawing.Point(149, 35);
            this.nudSinglesGroupSize.Name = "nudSinglesGroupSize";
            this.nudSinglesGroupSize.Size = new System.Drawing.Size(33, 20);
            this.nudSinglesGroupSize.TabIndex = 7;
            // 
            // lbSingleGroups
            // 
            this.lbSingleGroups.FormattingEnabled = true;
            this.lbSingleGroups.Location = new System.Drawing.Point(6, 137);
            this.lbSingleGroups.Name = "lbSingleGroups";
            this.lbSingleGroups.Size = new System.Drawing.Size(176, 160);
            this.lbSingleGroups.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Players in Singles:";
            // 
            // cbSingleGroups
            // 
            this.cbSingleGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSingleGroups.Enabled = false;
            this.cbSingleGroups.FormattingEnabled = true;
            this.cbSingleGroups.Location = new System.Drawing.Point(84, 110);
            this.cbSingleGroups.Name = "cbSingleGroups";
            this.cbSingleGroups.Size = new System.Drawing.Size(98, 21);
            this.cbSingleGroups.TabIndex = 5;
            // 
            // lblPlayersPlayingSingle
            // 
            this.lblPlayersPlayingSingle.AutoSize = true;
            this.lblPlayersPlayingSingle.Location = new System.Drawing.Point(148, 17);
            this.lblPlayersPlayingSingle.Name = "lblPlayersPlayingSingle";
            this.lblPlayersPlayingSingle.Size = new System.Drawing.Size(13, 13);
            this.lblPlayersPlayingSingle.TabIndex = 1;
            this.lblPlayersPlayingSingle.Text = "0";
            // 
            // btnGenerateSingleGroups
            // 
            this.btnGenerateSingleGroups.Enabled = false;
            this.btnGenerateSingleGroups.Location = new System.Drawing.Point(6, 81);
            this.btnGenerateSingleGroups.Name = "btnGenerateSingleGroups";
            this.btnGenerateSingleGroups.Size = new System.Drawing.Size(176, 23);
            this.btnGenerateSingleGroups.TabIndex = 4;
            this.btnGenerateSingleGroups.Text = "Generate Groups";
            this.btnGenerateSingleGroups.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum Group Size:";
            // 
            // tpgCalendar
            // 
            this.tpgCalendar.Controls.Add(this.btnSaveCalendar);
            this.tpgCalendar.Controls.Add(this.cbMinutes);
            this.tpgCalendar.Controls.Add(this.cbHours);
            this.tpgCalendar.Controls.Add(this.label7);
            this.tpgCalendar.Controls.Add(this.label8);
            this.tpgCalendar.Controls.Add(this.monthCalendar);
            this.tpgCalendar.Controls.Add(this.btnClearCalendar);
            this.tpgCalendar.Controls.Add(this.btnGenerateSchedule);
            this.tpgCalendar.Controls.Add(this.btnRemoveTimeSlot);
            this.tpgCalendar.Controls.Add(this.btnAddTimeSlot);
            this.tpgCalendar.Controls.Add(this.lbCalendar);
            this.tpgCalendar.Controls.Add(this.btnGenerateCalendar);
            this.tpgCalendar.Location = new System.Drawing.Point(4, 22);
            this.tpgCalendar.Name = "tpgCalendar";
            this.tpgCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCalendar.Size = new System.Drawing.Size(568, 311);
            this.tpgCalendar.TabIndex = 2;
            this.tpgCalendar.Text = "Calendar";
            this.tpgCalendar.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(290, 38);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 6;
            // 
            // btnClearCalendar
            // 
            this.btnClearCalendar.Location = new System.Drawing.Point(143, 6);
            this.btnClearCalendar.Name = "btnClearCalendar";
            this.btnClearCalendar.Size = new System.Drawing.Size(135, 23);
            this.btnClearCalendar.TabIndex = 5;
            this.btnClearCalendar.Text = "Clear Calendar";
            this.btnClearCalendar.UseVisualStyleBackColor = true;
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.Location = new System.Drawing.Point(291, 271);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(271, 34);
            this.btnGenerateSchedule.TabIndex = 4;
            this.btnGenerateSchedule.Text = "Generate Schedule!";
            this.btnGenerateSchedule.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTimeSlot
            // 
            this.btnRemoveTimeSlot.Location = new System.Drawing.Point(14, 257);
            this.btnRemoveTimeSlot.Name = "btnRemoveTimeSlot";
            this.btnRemoveTimeSlot.Size = new System.Drawing.Size(271, 23);
            this.btnRemoveTimeSlot.TabIndex = 3;
            this.btnRemoveTimeSlot.Text = "Remove Time Slot";
            this.btnRemoveTimeSlot.UseVisualStyleBackColor = true;
            // 
            // btnAddTimeSlot
            // 
            this.btnAddTimeSlot.Location = new System.Drawing.Point(290, 228);
            this.btnAddTimeSlot.Name = "btnAddTimeSlot";
            this.btnAddTimeSlot.Size = new System.Drawing.Size(220, 23);
            this.btnAddTimeSlot.TabIndex = 2;
            this.btnAddTimeSlot.Text = "Add Time Slot";
            this.btnAddTimeSlot.UseVisualStyleBackColor = true;
            // 
            // lbCalendar
            // 
            this.lbCalendar.FormattingEnabled = true;
            this.lbCalendar.Location = new System.Drawing.Point(13, 39);
            this.lbCalendar.Name = "lbCalendar";
            this.lbCalendar.Size = new System.Drawing.Size(271, 212);
            this.lbCalendar.TabIndex = 1;
            // 
            // btnGenerateCalendar
            // 
            this.btnGenerateCalendar.Location = new System.Drawing.Point(7, 7);
            this.btnGenerateCalendar.Name = "btnGenerateCalendar";
            this.btnGenerateCalendar.Size = new System.Drawing.Size(130, 23);
            this.btnGenerateCalendar.TabIndex = 0;
            this.btnGenerateCalendar.Text = "Generate Calendar";
            this.btnGenerateCalendar.UseVisualStyleBackColor = true;
            // 
            // cbMinutes
            // 
            this.cbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Location = new System.Drawing.Point(406, 203);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(56, 21);
            this.cbMinutes.TabIndex = 22;
            // 
            // cbHours
            // 
            this.cbHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHours.FormattingEnabled = true;
            this.cbHours.Location = new System.Drawing.Point(338, 203);
            this.cbHours.Name = "cbHours";
            this.cbHours.Size = new System.Drawing.Size(56, 21);
            this.cbHours.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Time:";
            // 
            // btnSaveCalendar
            // 
            this.btnSaveCalendar.Location = new System.Drawing.Point(14, 282);
            this.btnSaveCalendar.Name = "btnSaveCalendar";
            this.btnSaveCalendar.Size = new System.Drawing.Size(271, 23);
            this.btnSaveCalendar.TabIndex = 23;
            this.btnSaveCalendar.Text = "Save Calendar";
            this.btnSaveCalendar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 362);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tennis Schema Generator";
            this.tabControl1.ResumeLayout(false);
            this.tpgPlayers.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tpgSettings.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoublesGroupSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinglesGroupSize)).EndInit();
            this.tpgCalendar.ResumeLayout(false);
            this.tpgCalendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgPlayers;
        private System.Windows.Forms.TabPage tpgSettings;
        private System.Windows.Forms.TabPage tpgCalendar;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayersPlayingSingle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSingleGroups;
        private System.Windows.Forms.Button btnGenerateSingleGroups;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbSingleGroups;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTeamsPlayingDouble;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDoubleGroups;
        private System.Windows.Forms.Button btnGenerateDoubleGroups;
        private System.Windows.Forms.ListBox lbDoubleGroups;
        private System.Windows.Forms.NumericUpDown nudDoublesGroupSize;
        private System.Windows.Forms.NumericUpDown nudSinglesGroupSize;
        private System.Windows.Forms.Button btnClearDoubles;
        private System.Windows.Forms.Button btnClearSingles;
        private System.Windows.Forms.Label lblSelectDoubleGroups;
        private System.Windows.Forms.Label lblSelectSingleGroups;
        private System.Windows.Forms.Button btnRemoveTimeSlot;
        private System.Windows.Forms.Button btnAddTimeSlot;
        private System.Windows.Forms.ListBox lbCalendar;
        private System.Windows.Forms.Button btnGenerateCalendar;
        private System.Windows.Forms.Button btnGenerateSchedule;
        private System.Windows.Forms.Button btnClearCalendar;
        private System.Windows.Forms.Button btnSavePlayers;
        private System.Windows.Forms.CheckBox cboDoubleDouble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cboSingleDouble;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.ComboBox cbHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveCalendar;
    }
}

