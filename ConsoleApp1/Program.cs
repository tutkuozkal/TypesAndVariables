using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int number = 1000000000;
            Console.WriteLine("Number is {0}", number);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
               
        }
        enum Days
        {
            Monday=10,Tuesday=30,Wednesday,Thursday,Friday,Saturday,Sunday
        }


       
    }
}
