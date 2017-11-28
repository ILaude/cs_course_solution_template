using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBeregn
{
    class Program
    {

        //public delegate int Beregn(int x, int y);

        static void Main(string[] args)
        {
            //Func<int,int,int> b = Plus;
            //b += Minus;
            var res = Beregner(1, 1, Plus);
            Console.WriteLine(res);
            int res2 = Beregner(1, 1, Minus);
            Console.WriteLine(res2);
            int res4 = Beregner(1, 1, (x, y) => x + 2 * y);
            Console.WriteLine(res4);

            //Func<int, int, int> b = Gange;
            //Func<int, int> b = Gange2; ingen overloading.

            var res3 = Beregner(1.0, 1.0, Math.Pow);

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

        public static int Gange2(int a)
        {
            return a * 2;

        }


        public static int Beregner(int a, int b, Func<int,int,int> beregn)
        {
            return beregn(a, b);
  
        }

        public static double Beregner(double a, double b, Func<double,double,double> beregn)
        {
            return beregn(a, b);
        }

    }
}
