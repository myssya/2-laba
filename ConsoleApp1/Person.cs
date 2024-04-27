using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string Name;
        private string Surname;
        private DateTime BDate;

        public Person(string name, string surname, System.DateTime bDate)
        {
            Name = name;
            Surname = surname;
            BDate = bDate;
        }
        public Person()
        {

            Name = "nadim";
            Surname = "myska";
            BDate = new DateTime(2005, 10, 4);
        }
        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }
        public string surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
        public System.DateTime bDate
        {
            get
            {
                return BDate;
            }
            set
            {
                BDate = value;
            }
        }
        public int intbDate
        {
            get
            {
                return BDate.Year;
            }
            set
            {
                BDate = new DateTime(value, BDate.Month, BDate.Day);
            }
        }
        public string ToShortString()

        {
            return name + " " + Surname;
        }
        public override string ToString()
        {
            return string.Format(name, Surname, BDate);
        }
    }
}








