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
    public partial class NewCalendarForm : Form
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

        public NewCalendarForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(OnNewCalendarFormLoad);
            this.FormClosing += new FormClosingEventHandler(OnNewCalendarFormClosing);

            btnSetStartDate.Click += new EventHandler(OnSetStartDateButtonClick);
            btnSetEndDate.Click += new EventHandler(OnSetEndDateButtonClick);

            btnAddExcludedDate.Click += new EventHandler(OnAddExcludedDateButtonClick);
            btnRemoveExcludedDate.Click += new EventHandler(OnRemoveExcludedDateButtonClick);

            btnAddTimeSlot.Click += new EventHandler(OnAddTimeSlotButtonClick);
            btnRemoveTimeSlot.Click += new EventHandler(OnRemoveTimeSlotButtonClick);

            btnOK.Click += new EventHandler(OnOKButtonClick);
            btnCancel.Click += new EventHandler(OnCancelButtonClick);
        }

        private void OnNewCalendarFormLoad(object sender, EventArgs e)
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

        private void OnNewCalendarFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void OnSetStartDateButtonClick(object sender, EventArgs e)
        {
            if (monthCalendar.SelectionStart != null)
            {
                if (!string.IsNullOrEmpty(lblSetEndDate.Text))
                {
                    DateTime currentEndDate = DateTime.ParseExact(lblSetEndDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    if (currentEndDate < monthCalendar.SelectionStart)
                    {
                        MessageBox.Show("The start date has to appear before the end date in time.", "Error Setting Start Date", MessageBoxButtons.OK);
                        return;
                    }
                }

                lblSetStartDate.Text = monthCalendar.SelectionStart.ToString("d");
            }
        }

        private void OnSetEndDateButtonClick(object sender, EventArgs e)
        {
            if (monthCalendar.SelectionStart != null)
            {
                if (!string.IsNullOrEmpty(lblSetStartDate.Text))
                {
                    DateTime currentStartDate = DateTime.ParseExact(lblSetStartDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    if (currentStartDate > monthCalendar.SelectionStart)
                    {
                        MessageBox.Show("The end date has to appear after the start date in time.", "Error Setting End Date", MessageBoxButtons.OK);
                        return;
                    }
                }
                lblSetEndDate.Text = monthCalendar.SelectionStart.ToString("d");
            }
        }

        private void OnAddExcludedDateButtonClick(object sender, EventArgs e)
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

        private void OnRemoveExcludedDateButtonClick(object sender, EventArgs e)
        {
            if (monthCalendar.SelectionStart != null && lbExcludedDates.SelectedItem == null)
            {
                DateTime selectedDate = new DateTime(monthCalendar.SelectionStart.Year, monthCalendar.SelectionStart.Month, monthCalendar.SelectionStart.Day, 0, 0, 0);
                ExcludedDates.Remove(selectedDate);
                FillExcludedDatesListBox();
            }

            else if (lbExcludedDates.SelectedItem != null)
            {
                DateTime selectedDate = DateTime.ParseExact(lbExcludedDates.SelectedItem.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
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

        private void OnAddTimeSlotButtonClick(object sender, EventArgs e)
        {
            int dayOfWeek = cbDayOfWeek.SelectedIndex;
            int hours = (int)cbHours.SelectedItem;
            string strMinutes = cbMinutes.SelectedItem.ToString();
            int minutes = int.Parse(strMinutes);

            TimeSlot newSlot = new TimeSlot(dayOfWeek, hours, minutes);
            TimeSlots.Add(newSlot);
            FillTimeSlotsListBox();
        }

        private void OnRemoveTimeSlotButtonClick(object sender, EventArgs e)
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

        private void OnOKButtonClick(object sender, EventArgs e)
        {
            if (TimeSlots.Count != 0)
            {
                StartDate = DateTime.ParseExact(lblSetStartDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                EndDate = DateTime.ParseExact(lblSetEndDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                this.FormClosing -= OnNewCalendarFormClosing;
                this.Close();
            }
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            ExcludedDates = null;
            TimeSlots = null;

            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;

            this.FormClosing -= OnNewCalendarFormClosing;
            this.Close();
        }
    }
}
