using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave04Månedsløn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            Console.WriteLine("Lønninger:");
            for (int i = 0; i < Månedsløn.Length; i++)
            {
                Console.WriteLine(Månedsløn[i]);
            }

            decimal gns = 0;

            for (int i = 0; i < Månedsløn.Length; i++)
            {
                gns += Månedsløn[i];
            }

            gns = gns / Månedsløn.Length;

            Console.Write("Gennemsnit: ");
            Console.Write(gns.ToString("N2"));

            Console.WriteLine();
            // Sorteret lønningerne
            //System.Array.Sort(Månedsløn);
            //Console.WriteLine();
            //Console.WriteLine("Lønninger sorteret:");
            //for (int i = 0; i < Månedsløn.Length; i++)
            //{
            //    Console.WriteLine(Månedsløn[i]);
            //}

            // Laver kopi og sorterer.
            int[] MånedslønSorteret = new int[Månedsløn.Length];
            Månedsløn.CopyTo(MånedslønSorteret, 0);
            System.Array.Sort(MånedslønSorteret);

            Console.WriteLine("Lønninger sorteret:");
            for (int i = 0; i < MånedslønSorteret.Length; i++)
            {
                Console.WriteLine(MånedslønSorteret[i]);
            }


        }
    }
}
