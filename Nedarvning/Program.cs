using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();

            Terning t2 = new Terning(4);
            t2.Skriv();

            Terning t3 = new Terning(8);
            t3.Skriv();

            LudoTerning l = new LudoTerning();
            l.Skriv();

            for (int i = 0; i < 5; i++)
            {
                l.Ryst();
                l.Skriv();
                Console.WriteLine("Er Globus:" + l.ErGlobus());
                Console.WriteLine("Er Stjerne:" + l.ErStjerne());
            } 
        }
    }
}
