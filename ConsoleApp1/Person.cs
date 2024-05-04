using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string _name;
        private string _surname;
        private DateTime _bDate;

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
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public DateTime BDate
        {
            get
            {
                return _bDate;
            }
            set
            {
                _bDate = value;
            }
        }
        public string ToShortString()

        {
            string result= _name + " " + Surname;
            return result;
        }
        public override string ToString()
        {
            return string.Format(_name, Surname, BDate);
        }
    }
}








