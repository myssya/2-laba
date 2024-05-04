using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person("name", "familia", System.DateTime.Now);
            Person obj1 = new Person();

            string n = obj.ToString();

            Console.WriteLine(n);
         }
}}
