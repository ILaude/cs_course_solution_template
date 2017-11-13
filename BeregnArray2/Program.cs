using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BeregnArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var testStreng = string.Join(", ", test);
            Console.WriteLine("Originalt array:"+ testStreng);
            var resultat = BeregnOgSortererArray(test);

            Console.WriteLine("Sum: " + resultat.sum.ToString());
            Console.WriteLine("Gennemsnit: " + resultat.gennemsnit.ToString("N2"));
            var testStreng2 = string.Join(", ", test);
            Console.WriteLine("Array efter kørsel af metoden:" + testStreng2);


            Console.WriteLine("Nu som xml:");
            XmlSerializer serializer = new XmlSerializer(test.GetType());
            System.Text.StringBuilder sb = new StringBuilder();
            using (StringWriter writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, test);
            }

            Console.WriteLine(sb.ToString());
        }

        static ArrayResultat BeregnOgSortererArray(int[] array)
        {
            Array.Sort(array);
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double gennemsnit = sum / array.Length;

            ArrayResultat resultat = new ArrayResultat();
            resultat.sum = sum;
            resultat.gennemsnit = gennemsnit;
            return resultat;
        }

    }

    public struct ArrayResultat
    {
        public double sum;
        public double gennemsnit;
    }
}
