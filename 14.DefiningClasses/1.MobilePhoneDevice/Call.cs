using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhoneDevice
{
    class Call
    {
        private DateTime dateAndTime;

        public DateTime DateAndTime
        {
            get { return dateAndTime; }
            set { dateAndTime = value; }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        private int durationSeconds;

        public int DurationSeconds
        {
            get { return durationSeconds; }
            set { durationSeconds = value; }
        }

        public Call(DateTime timeAndDate, string number, int duration)
        {
            this.dateAndTime = timeAndDate;
            this.number = number;
            this.durationSeconds = duration;
        }

        public override string ToString()
        {
            string str = "Date:" + dateAndTime.ToShortDateString() + " Time:" + dateAndTime.ToShortTimeString() +
                "Number:" + this.number + " Duration:" + durationSeconds + " seconds.";
            return str;
        }
    }
}
