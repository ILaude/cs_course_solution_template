using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning()
            {
                Værdi = 5
            };

            t.Skriv();
            Console.WriteLine();
            t.Ryst();
            t.Skriv();
            Console.WriteLine();
            Terning t2 = new Terning();
            t2.Skriv();
            Console.WriteLine();


            YatzyBæger b = new YatzyBæger();
            b.Skriv();
            Console.WriteLine("Max antal ens:" + b.MaxAntalEns());
            b.Resultat();


            b.Ryst();
            b.Skriv();

            Console.WriteLine("Antal fire:" + b.AntalTerningerMedGivenVærdi(4));
            b.Resultat();

        }
    }
}
