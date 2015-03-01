using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhoneDevice
{
    class Battery
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double hoursIdle;

        public double HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        private double hoursTalk;

        public double HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        private BatteryType baterryType;

        public BatteryType BatteryType
        {
            get { return baterryType; }
            set { baterryType = value; }
        }


        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = -1;
            this.hoursTalk = -1;
        }
        public Battery(string model, BatteryType type)
        {
            this.model = model;
            this.baterryType = type;
            this.hoursIdle = -1;
            this.hoursTalk = -1;
        }
        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public Battery(string model, BatteryType type, double hoursIdle, double hoursTalk)
            : this(model, type)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Model:" + this.Model + " ");
            if (this.hoursTalk != -1)
            {
                info.Append("Hours in talk mode:" + this.hoursTalk + " ");
            }
            if (this.hoursIdle != -1)
            {
                info.Append("Hours in idle mode:" + this.hoursIdle + " ");
            }

            info.Append("Type:" + this.BatteryType + " ");


            return info.ToString();
        }
    }
    enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
}
