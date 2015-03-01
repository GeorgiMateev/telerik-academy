using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.Fraction
{
    class Fraction
    {
        private int numerator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private int denumerator;

        public int Denumerator
        {
            get { return denumerator; }
            set { denumerator = value; }
        }


        public Fraction(int numerator, int denumerator)
        {
            this.numerator = numerator;
            this.denumerator = denumerator;
        }

        public override string ToString()
        {
            string format = String.Format("{0}/{1}", this.numerator, this.denumerator);
            return format;
        }

        public static Fraction operator+(Fraction fr1, Fraction fr2)
        {
            throw new NotImplementedException();
        }

        public static Fraction Parse(string fraction)
        {
            try
            {
                string[] parts = fraction.Split('/');
                int num = int.Parse(parts[0]);
                int denum = int.Parse(parts[1]);

                Fraction fr = new Fraction(num, denum);

                return fr;
            }
            catch (FormatException e)
            {
                throw new FormatException("Incorrect format!", e);
            }
            
        }
    }
}
