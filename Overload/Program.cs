using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            int res1 = Beregn(1, 2);
            Console.WriteLine(res1);
            int res2 = Beregn(1, 2, 3);
            Console.WriteLine(res2);
            int res3 = Beregn(1, 2, 3, 4);
            Console.WriteLine(res3);
        } 

        public static int Beregn(int a, int b)
        {
            return a + b;
        }

        public static int Beregn(int a, int b, int c)
        {
            return Beregn(Beregn(a,b),c);
        }

        public static int Beregn(int a, int b, int c, int d)
        {
            return Beregn(Beregn(a,b,c),d);
        }
    }
}
