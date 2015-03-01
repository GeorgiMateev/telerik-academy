using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhoneDevice
{  

    class GSM
    {
        private string  model;
        public string  Model
        {
            get { return model; }
            set { model = value; }
        }

        private string manufacturer;
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private string owner;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private List<Call> callHistory;                    
        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }
        

        private Battery battery;
        public Battery Baterry
        {
            get { return battery; }
            set { battery = value; }
        }

        private Display display;
        public Display Display
        {
            get { return display; }
            set { display = value; }
        }

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = null;
            this.price = -1;
            this.battery = null;
            this.display = null;
            this.callHistory = new List<Call>();
        }
        public GSM(string model, string manufacturer, string owner, decimal price) 
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
            this.battery = null;
            this.display = null;
            this.callHistory = new List<Call>();

        }
        public GSM(string model, string manufacturer, string owner, decimal price, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
            this.display = display;
            this.callHistory = new List<Call>();

        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCall(int index)
        {
            this.callHistory.RemoveAt(index);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateCallPrice(decimal pricePerMinute)
        {
            int durationAllSeconds = 0;
            foreach (var item in this.callHistory)
            {
                durationAllSeconds += item.DurationSeconds;
            }
            decimal durationAllMinutes = durationAllSeconds / 60.0M;
            return durationAllMinutes * pricePerMinute;
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Model:"+this.Model+" ");
            info.Append("Manufacturer:"+this.Manufacturer+" ");
            info.Append("Owner:"+this.Owner+" ");
            info.Append("Price:"+this.Price.ToString() + " ");
            if (Baterry!=null)
            {
                info.Append(this.Baterry.ToString());
            }
            if (Display != null)
            {
                info.Append(this.Display.ToString());
            }

            return info.ToString();
        }
    }   
       
}
