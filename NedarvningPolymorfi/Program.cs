using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvningPolymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            Terning t2 = new Terning();

            LudoTerning l = new LudoTerning();

            LudoTerning l2 = new LudoTerning(3);

            Terning[] terninger = new Terning[4];
            terninger[0] = t;
            terninger[1] = t2;
            terninger[2] = l;
            terninger[3] = l2;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < terninger.Length; j++)
                {
                    terninger[j].Ryst();
                    terninger[j].Skriv();
                }
                Console.WriteLine();
            }


        }
    }
}
