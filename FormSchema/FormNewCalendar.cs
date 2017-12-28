using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSchema
{
    public partial class FormNewCalendar : Form
    {
        List<DateTime> excludedDates = new List<DateTime>();
        List<TimeSlot> timeSlots = new List<TimeSlot>();

        DateTime startDate;
        DateTime endDate;

        public List<DateTime> ExcludedDates
        {
            get { return excludedDates; }
            private set { excludedDates = value; }
        }

        public List<TimeSlot> TimeSlots
        {
            get { return timeSlots; }
            private set { timeSlots = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            private set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            private set { endDate = value; }
        }

        public FormNewCalendar()
        {
            InitializeComponent();

            this.Load += new EventHandler(FormNewCalendar_Load);
            this.FormClosing += new FormClosingEventHandler(FormNewCalendar_FormClosing);

            btnSetStartDate.Click += new EventHandler(btnSetStartDate_Click);
            btnSetEndDate.Click += new EventHandler(btnSetEndDate_Click);

            btnAddExcludedDate.Click += new EventHandler(btnAddExcludedDate_Click);
            btnRemoveExcludedDate.Click += new EventHandler(btnRemoveExcludedDate_Click);

            btnAddTimeSlot.Click += new EventHandler(btnAddTimeSlot_Click);
            btnRemoveTimeSlot.Click += new EventHandler(btnRemoveTimeSlot_Click);

            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        private void FormNewCalendar_Load(object sender, EventArgs e)
        {

            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
                cbDayOfWeek.Items.Add(dayOfWeek);

            cbDayOfWeek.SelectedIndex = 0;

            for (int i = 0; i < 24; i++)
            {
                cbHours.Items.Add(i);
            }

            cbMinutes.Items.Add("00");
            cbMinutes.Items.Add(10);
            cbMinutes.Items.Add(20);
            cbMinutes.Items.Add(30);
            cbMinutes.Items.Add(40);
            cbMinutes.Items.Add(50);

            cbDayOfWeek.SelectedIndex = 0;
            cbHours.SelectedIndex = 0;
            cbMinutes.SelectedIndex = 0;
        }

        private void FormNewCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void btnSetStartDate_Click(object sender, EventArgs e)
        {
            if (monthCalendar.SelectionStart != null)
            {
                if (!string.IsNullOrEmpty(lblSetEndDate.Text))
                {
                    DateTime currentEndDate = DateTime.ParseExact(lblSetEndDate.Text, "d", CultureInfo.CurrentCulture);
                    if (currentEndDate < monthCalendar.SelectionStart)
                    {
                        MessageBox.Show("The start date has to appear before the end date in time.", "Error Setting Start Date", MessageBoxButtons.OK);
                        return;
                    }
                }

                lblSetStartDate.Text = monthCalendar.SelectionStart.ToString("d");
            }
        }

        private void btnSetEndDate_Click(object sender, EventArgs e)
        {
            if (monthCalendar.SelectionStart != null)
            {
                if (!string.IsNullOrEmpty(lblSetStartDate.Text))
                {
                    DateTime currentStartDate = DateTime.ParseExact(lblSetStartDate.Text, "d", CultureInfo.CurrentCulture);
                    if (currentStartDate > monthCalendar.SelectionStart)
                    {
                        MessageBox.Show("The end date has to appear after the start date in time.", "Error Setting End Date", MessageBoxButtons.OK);
                        return;
                    }
                }
                lblSetEndDate.Text = monthCalendar.SelectionStart.ToString("d");
            }
        }

        private void btnAddExcludedDate_Click(object sender, EventArgs e)
        {
            if (monthCalendar.SelectionStart != null)
            {
                if (!lbExcludedDates.Items.Contains(monthCalendar.SelectionStart.ToString("d")))
                {
                    DateTime newDate = new DateTime(monthCalendar.SelectionStart.Year, monthCalendar.SelectionStart.Month, monthCalendar.SelectionStart.Day, 0, 0, 0);
                    ExcludedDates.Add(newDate);
                    FillExcludedDatesListBox();
                }
            }
        }

        private void btnRemoveExcludedDate_Click(object sender, EventArgs e)
        {
            if (monthCalendar.SelectionStart != null && lbExcludedDates.SelectedItem == null)
            {
                DateTime selectedDate = new DateTime(monthCalendar.SelectionStart.Year, monthCalendar.SelectionStart.Month, monthCalendar.SelectionStart.Day, 0, 0, 0);
                ExcludedDates.Remove(selectedDate);
                FillExcludedDatesListBox();
            }

            else if (lbExcludedDates.SelectedItem != null)
            {
                DateTime selectedDate = DateTime.ParseExact(lbExcludedDates.SelectedItem.ToString(), "d", CultureInfo.CurrentCulture);
                ExcludedDates.Remove(selectedDate);
                FillExcludedDatesListBox();
            }
        }

        private void FillExcludedDatesListBox()
        {
            lbExcludedDates.Items.Clear();

            var sortedList = ExcludedDates.OrderBy(date => date.ToString()).ToList();

            foreach (DateTime date in sortedList)
            {
                lbExcludedDates.Items.Add(date.ToString("d"));
            }
        }

        private void btnAddTimeSlot_Click(object sender, EventArgs e)
        {
            int dayOfWeek = cbDayOfWeek.SelectedIndex;
            int hours = (int)cbHours.SelectedItem;
            string strMinutes = cbMinutes.SelectedItem.ToString();
            int minutes = int.Parse(strMinutes);

            TimeSlot newSlot = new TimeSlot(dayOfWeek, hours, minutes);
            TimeSlots.Add(newSlot);
            FillTimeSlotsListBox();
        }

        private void btnRemoveTimeSlot_Click(object sender, EventArgs e)
        {
            if (lbTimeSlots.SelectedItem != null)
            {
                TimeSlots.RemoveAt(lbTimeSlots.SelectedIndex);
                FillTimeSlotsListBox();
            }
        }

        private void FillTimeSlotsListBox()
        {
            lbTimeSlots.Items.Clear();

            foreach (TimeSlot slot in TimeSlots)
            {
                lbTimeSlots.Items.Add(slot.ToString());
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (TimeSlots.Count != 0)
            {
                StartDate = DateTime.ParseExact(lblSetStartDate.Text, "d", CultureInfo.CurrentCulture);
                EndDate = DateTime.ParseExact(lblSetEndDate.Text, "d", CultureInfo.CurrentCulture);

                this.FormClosing -= FormNewCalendar_FormClosing;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExcludedDates = null;
            TimeSlots = null;

            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;

            this.FormClosing -= FormNewCalendar_FormClosing;
            this.Close();
        }
    }
}
