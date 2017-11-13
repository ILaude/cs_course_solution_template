using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare ting = new Vare();
            ting.Navn = "gave";
            Console.WriteLine(ting.Navn);

            Vare sager = new Vare("slik", 10);
            Console.WriteLine(sager.Navn);
            Console.WriteLine(sager.PrisMedMoms());

            Vare snyd = new Vare("Negativ", -10);
            Console.WriteLine(snyd.Pris);
        }
    }
}
