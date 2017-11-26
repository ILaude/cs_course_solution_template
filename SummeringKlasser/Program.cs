using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.MinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person p = new Person();

            Kursusdeltager k = new Kursusdeltager("Anne", "xxxxxx-xxxx");
            k.Skriv();

            Console.WriteLine(Elev.CprOk("xxx"));
            Console.WriteLine(Instruktør.CprOk("230367-0000"));

            Instruktør i = new Instruktør("Michell", "xxxxxx-xxxx", "7B");
            i.Skriv();

            Elev e = new Elev("Mikkel", "xxxx", "1");
            e.Skriv();

            Person[] personer = new Person[3];
            personer[0] = k;
            personer[1] = i;
            personer[2] = e;

            foreach (var person in personer)
            {
                person.Skriv();
            }

        }
    }
}
