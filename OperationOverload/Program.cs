using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            hund h1 = new hund() { Navn = "A", Lydnivau = 30 };
            hund h2 = new hund() { Navn = "B", Lydnivau = 20 };
            Console.WriteLine(h1> h2);
        }
    }

    class hund
    {
        public string Navn { get; set; }

        public int Lydnivau { get; set; }

        public static bool operator <(hund h1, hund h2)
        {
            return h1.Lydnivau < h2.Lydnivau;
        }

        public static bool operator >(hund h1, hund h2)
        {
            return h1.Lydnivau > h2.Lydnivau;
        }
    }
}
