using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeregnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSortererArray(test);

            Console.WriteLine(res.sum);
            Console.WriteLine(res.gennemsnit.ToString("N2"));
            
        }
        static ArrayResultat BeregnOgSortererArray(int[] array)
        {
            Array.Sort(array);
            ArrayResultat resultat = new ArrayResultat();
            resultat.sum = ArraySum(array);
            resultat.gennemsnit = ArrayGennemsnit(array);
            return resultat;
        }
        static double ArraySum(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static double ArrayGennemsnit(int[] array)
        {
            var gennemsnit = ArraySum(array)/ array.Length;
            return gennemsnit;
        }
    }
    public struct ArrayResultat
    {
        public double sum;
        public double gennemsnit;
    }
}
