using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(4, 2);
            double areal = t.Areal;
            Console.WriteLine(areal);

            Trekant t2 = new Trekant(3, 5);
            double areal2 = t2.ArealMetode();
            Console.WriteLine(areal2);

        }
    }
}
