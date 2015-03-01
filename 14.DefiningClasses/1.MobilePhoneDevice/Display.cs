using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MobilePhoneDevice
{
    class Display
    {
        private string size;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        private int numberColors;

        public int NumberColors
        {
            get { return numberColors; }
            set { numberColors = value; }
        }

        public Display(string size, int colors)
        {
            this.size = size;
            this.numberColors = colors;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Size:" + size + " ");
            info.Append("Number colors:" + numberColors + " ");

            return info.ToString();
        }
    }
}
