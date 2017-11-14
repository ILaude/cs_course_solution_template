using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningspil
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Ryst();
            t.Skriv();

            Terning t2 = new Terning(4);
            t2.Skriv();

            Bæger bæger = new Bæger(-4);
            Console.WriteLine();
        }
    }
}
