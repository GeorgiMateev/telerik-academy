using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Animals
{
    abstract class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        private int age;

        public int Age
        {
            get { return age; }
        }

        private string sex;

        public string Sex
        {
            get { return sex; }
        }

        public Animal(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public abstract string MakeSound();

        public static TypeCode RecognizeAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
