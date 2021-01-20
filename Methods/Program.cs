using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Geridon tutku = new Geridon();
            tutku.Sayi = 15;
            Console.WriteLine(tutku.Sayi);
            Add();
            Add();
            Add();
            var result = Add2(20);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }
        static void Add()
        {
            Console.WriteLine("Eklendi");
        }
        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }


    }   

    internal class Geridon
    {
       public int Aded { get; set; }
       public int Renk { get; set; }
       public Double Sayi { get; set; }

    }
}
