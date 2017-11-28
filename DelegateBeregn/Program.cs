using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBeregn
{
    class Program
    {

        public delegate int Beregn(int x, int y);

        static void Main(string[] args)
        {
            Beregn b = Plus;
            int res = Beregner(1, 1, b);
            Console.WriteLine(res);
            int res2 = Beregner(1, 1, Minus);
            Console.WriteLine(res2);
        }


       

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;

        }

        public static int Gange(int a, int b)
        {
            return a * b;

        }

        public static int Beregner(int a, int b, Beregn beregn)
        {
            return beregn(a, b);
  
        }

    }
}
