using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal = kommatal * 2;
            Console.WriteLine(kommatal);

            FilTyper ft = FilTyper.csv;

            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            DateTime nu = DateTime.Now;
            Console.WriteLine("I dag:");
            Console.WriteLine(nu.ToString("dd-MM-yyyy"));

            Person q = new Person();
           
            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";

            q = p;
            q.Id = 2;

            Console.WriteLine(p.Navn);

            Console.ReadKey();
        }
    }
}
