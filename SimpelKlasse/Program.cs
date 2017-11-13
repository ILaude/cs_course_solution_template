using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Navn: "+ p.Fuldtnavn());
            Console.WriteLine("Alder:" + p.Alder().ToString());

            Person p2 = new Person("Arthur", "Lam", 1990);

            Console.WriteLine("Navn: "+ p2.Fuldtnavn());
            Console.WriteLine("Alder:" + p2.Alder().ToString());

            Person p3 = new Person();
            p3.Fornavn = "Blanca";
            p3.Efternavn = "Tiger";
            p3.Fødselsår = 1995;

            Console.WriteLine("Navn: " + p3.Fuldtnavn());
            Console.WriteLine("Alder:" + p3.Alder().ToString());

        }
    }
}
