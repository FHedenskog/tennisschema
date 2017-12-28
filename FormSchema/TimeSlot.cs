using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FormSchema
{
    public class TimeSlot
    {
        int weekday;
        int hours;
        int minutes;

        public int Weekday
        {
            get { return weekday; }
            private set { weekday = value; }
        }

        public int Hours
        {
            get { return hours; }
            private set { hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            private set { minutes = value; }
        }

        public TimeSlot(int weekday, int hours, int minutes)
        {
            Weekday = weekday;
            Hours = hours;
            Minutes = minutes;
        }

        public TimeSlot()
        {

        }

        public override string ToString()
        {
            string toString = "";

            switch (weekday)
            {
                case 0:
                    toString += "Sunday, ";
                    break;
                case 1:
                    toString += "Monday, ";
                    break;
                case 2:
                    toString += "Tuesday, ";
                    break;
                case 3:
                    toString += "Wednesday, ";
                    break;
                case 4:
                    toString += "Thursday, ";
                    break;
                case 5:
                    toString += "Friday, ";
                    break;
                case 6:
                    toString += "Saturday, ";
                    break;
            }

            toString += Hours + ":";

            if (minutes == 0)
                toString += "00";
            else
                toString += Minutes;

            return toString;
        }

        public void SetProperties(string content)
        {
            char[] delimiterChars = {',', ':'};
            string[] parts = content.Split(delimiterChars);

            switch (parts[0])
            {
                case "Sunday":
                    Weekday = 0;
                    break;
                case "Monday":
                    Weekday = 1;
                    break;
                case "Tuesday":
                    Weekday = 2;
                    break;
                case "Wednesday":
                    Weekday = 3;
                    break;
                case "Thursday":
                    Weekday = 4;
                    break;
                case "Friday":
                    Weekday = 5;
                    break;
                case "Saturday":
                    Weekday = 6;
                    break;
            }

            string strHours = parts[1].Trim();
            Hours = int.Parse(strHours);

            if (parts[2] == "00")
                Minutes = 0;
            else
                Minutes = int.Parse(parts[2]);
        }
    }
}
