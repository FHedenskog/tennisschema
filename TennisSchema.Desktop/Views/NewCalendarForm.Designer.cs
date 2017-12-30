namespace TennisSchema.Views
{
    partial class NewCalendarForm
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnSetStartDate = new System.Windows.Forms.Button();
            this.lblSetStartDate = new System.Windows.Forms.Label();
            this.btnSetEndDate = new System.Windows.Forms.Button();
            this.lblSetEndDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveExcludedDate = new System.Windows.Forms.Button();
            this.lbExcludedDates = new System.Windows.Forms.ListBox();
            this.btnAddExcludedDate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveTimeSlot = new System.Windows.Forms.Button();
            this.lbTimeSlots = new System.Windows.Forms.ListBox();
            this.btnAddTimeSlot = new System.Windows.Forms.Button();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.cbHours = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 23);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 0;
            // 
            // btnSetStartDate
            // 
            this.btnSetStartDate.Location = new System.Drawing.Point(12, 188);
            this.btnSetStartDate.Name = "btnSetStartDate";
            this.btnSetStartDate.Size = new System.Drawing.Size(99, 23);
            this.btnSetStartDate.TabIndex = 1;
            this.btnSetStartDate.Text = "Set Start Date";
            this.btnSetStartDate.UseVisualStyleBackColor = true;
            // 
            // lblSetStartDate
            // 
            this.lblSetStartDate.AutoSize = true;
            this.lblSetStartDate.Location = new System.Drawing.Point(32, 219);
            this.lblSetStartDate.Name = "lblSetStartDate";
            this.lblSetStartDate.Size = new System.Drawing.Size(0, 13);
            this.lblSetStartDate.TabIndex = 2;
            // 
            // btnSetEndDate
            // 
            this.btnSetEndDate.Location = new System.Drawing.Point(117, 188);
            this.btnSetEndDate.Name = "btnSetEndDate";
            this.btnSetEndDate.Size = new System.Drawing.Size(114, 23);
            this.btnSetEndDate.TabIndex = 3;
            this.btnSetEndDate.Text = "Set End Date";
            this.btnSetEndDate.UseVisualStyleBackColor = true;
            // 
            // lblSetEndDate
            // 
            this.lblSetEndDate.AutoSize = true;
            this.lblSetEndDate.Location = new System.Drawing.Point(140, 219);
            this.lblSetEndDate.Name = "lblSetEndDate";
            this.lblSetEndDate.Size = new System.Drawing.Size(0, 13);
            this.lblSetEndDate.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveExcludedDate);
            this.groupBox1.Controls.Add(this.lbExcludedDates);
            this.groupBox1.Controls.Add(this.btnAddExcludedDate);
            this.groupBox1.Controls.Add(this.monthCalendar);
            this.groupBox1.Controls.Add(this.lblSetEndDate);
            this.groupBox1.Controls.Add(this.btnSetEndDate);
            this.groupBox1.Controls.Add(this.btnSetStartDate);
            this.groupBox1.Controls.Add(this.lblSetStartDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 260);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interval Settings";
            // 
            // btnRemoveExcludedDate
            // 
            this.btnRemoveExcludedDate.Location = new System.Drawing.Point(244, 48);
            this.btnRemoveExcludedDate.Name = "btnRemoveExcludedDate";
            this.btnRemoveExcludedDate.Size = new System.Drawing.Size(131, 23);
            this.btnRemoveExcludedDate.TabIndex = 7;
            this.btnRemoveExcludedDate.Text = "Remove Excluded Date";
            this.btnRemoveExcludedDate.UseVisualStyleBackColor = true;
            // 
            // lbExcludedDates
            // 
            this.lbExcludedDates.FormattingEnabled = true;
            this.lbExcludedDates.Location = new System.Drawing.Point(244, 77);
            this.lbExcludedDates.Name = "lbExcludedDates";
            this.lbExcludedDates.Size = new System.Drawing.Size(131, 134);
            this.lbExcludedDates.TabIndex = 6;
            // 
            // btnAddExcludedDate
            // 
            this.btnAddExcludedDate.Location = new System.Drawing.Point(244, 23);
            this.btnAddExcludedDate.Name = "btnAddExcludedDate";
            this.btnAddExcludedDate.Size = new System.Drawing.Size(131, 23);
            this.btnAddExcludedDate.TabIndex = 5;
            this.btnAddExcludedDate.Text = "Add Excluded Date";
            this.btnAddExcludedDate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveTimeSlot);
            this.groupBox2.Controls.Add(this.lbTimeSlots);
            this.groupBox2.Controls.Add(this.btnAddTimeSlot);
            this.groupBox2.Controls.Add(this.cbMinutes);
            this.groupBox2.Controls.Add(this.cbHours);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.cbDayOfWeek);
            this.groupBox2.Controls.Add(this.lblDayOfWeek);
            this.groupBox2.Location = new System.Drawing.Point(413, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 260);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Slots";
            // 
            // btnRemoveTimeSlot
            // 
            this.btnRemoveTimeSlot.Location = new System.Drawing.Point(15, 230);
            this.btnRemoveTimeSlot.Name = "btnRemoveTimeSlot";
            this.btnRemoveTimeSlot.Size = new System.Drawing.Size(185, 23);
            this.btnRemoveTimeSlot.TabIndex = 21;
            this.btnRemoveTimeSlot.Text = "Remove Time Slot";
            this.btnRemoveTimeSlot.UseVisualStyleBackColor = true;
            // 
            // lbTimeSlots
            // 
            this.lbTimeSlots.FormattingEnabled = true;
            this.lbTimeSlots.Location = new System.Drawing.Point(15, 103);
            this.lbTimeSlots.Name = "lbTimeSlots";
            this.lbTimeSlots.Size = new System.Drawing.Size(185, 121);
            this.lbTimeSlots.TabIndex = 20;
            // 
            // btnAddTimeSlot
            // 
            this.btnAddTimeSlot.Location = new System.Drawing.Point(15, 74);
            this.btnAddTimeSlot.Name = "btnAddTimeSlot";
            this.btnAddTimeSlot.Size = new System.Drawing.Size(185, 23);
            this.btnAddTimeSlot.TabIndex = 19;
            this.btnAddTimeSlot.Text = "Add Time Slot";
            this.btnAddTimeSlot.UseVisualStyleBackColor = true;
            // 
            // cbMinutes
            // 
            this.cbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Location = new System.Drawing.Point(144, 47);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(56, 21);
            this.cbMinutes.TabIndex = 18;
            // 
            // cbHours
            // 
            this.cbHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHours.FormattingEnabled = true;
            this.cbHours.Location = new System.Drawing.Point(79, 47);
            this.cbHours.Name = "cbHours";
            this.cbHours.Size = new System.Drawing.Size(56, 21);
            this.cbHours.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = ":";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(45, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time:";
            // 
            // cbDayOfWeek
            // 
            this.cbDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDayOfWeek.FormattingEnabled = true;
            this.cbDayOfWeek.Location = new System.Drawing.Point(79, 20);
            this.cbDayOfWeek.Name = "cbDayOfWeek";
            this.cbDayOfWeek.Size = new System.Drawing.Size(121, 21);
            this.cbDayOfWeek.TabIndex = 1;
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Location = new System.Drawing.Point(7, 23);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(73, 13);
            this.lblDayOfWeek.TabIndex = 0;
            this.lblDayOfWeek.Text = "Day of Week:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(205, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(332, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 324);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCalendarForm";
            this.Text = "Calendar Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnSetStartDate;
        private System.Windows.Forms.Label lblSetStartDate;
        private System.Windows.Forms.Button btnSetEndDate;
        private System.Windows.Forms.Label lblSetEndDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.ComboBox cbDayOfWeek;
        private System.Windows.Forms.Button btnAddTimeSlot;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.ComboBox cbHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnRemoveTimeSlot;
        private System.Windows.Forms.ListBox lbTimeSlots;
        private System.Windows.Forms.Button btnAddExcludedDate;
        private System.Windows.Forms.Button btnRemoveExcludedDate;
        private System.Windows.Forms.ListBox lbExcludedDates;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}