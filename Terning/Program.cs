using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Standrad terning");
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Console.WriteLine("Snydeterning");
            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            Console.WriteLine("Ikke-snydeterning");
            Terning t3 = new Terning(false);
            t3.Skriv();
            t3.Ryst();
            t3.Skriv();
        }
    }
}
