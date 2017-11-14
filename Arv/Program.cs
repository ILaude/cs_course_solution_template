using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Fornavn = "Test", Efternavn = "Testesen" };
            Console.WriteLine(p.Fuldtnavn());

            Elev e = new Elev()
            {
                Fornavn = "Elev",
                Efternavn ="Elevsen",
                Klasselokale = "B34"
            };
            Console.WriteLine(e.Fuldtnavn());

            Elev[] elever = new Elev[1];
            elever[0] = e;


            Instruktør i = new Instruktør()
            {
                Fornavn = "Lærer",
                Efternavn = "Lærersen",
                NøgleId = 56,
                Elever = elever

            };
            Console.WriteLine(i.Fuldtnavn());
        }
    }
}
