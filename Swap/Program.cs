using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            Swap<int>(ref a, ref b);

            Swap(ref a, ref b);

            string s = "A";
            string t = "B";

            Swap<string>(ref s, ref t);
            Swap(ref s, ref t);




        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
