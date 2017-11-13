using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skab en ref, som kan peje på en person
            Person p;

            // Skab en ny person og bind ref til p.
            p = new Person();
            p.name = "Mikkel";
            string t = p.ToString();
            Console.WriteLine(t);
            Person p2 = new Person("Mikkel", 14);

            Person p3 = new Person("Mikkeline");

            //p = null;
            //string t2 = p.ToString();
            //Console.WriteLine(t2);

            Bil b = new Bil();

            //p = b;

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    class Bil
    {

    }
}
