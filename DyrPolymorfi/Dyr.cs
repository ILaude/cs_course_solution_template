using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyrPolymorfi
{
    public class Dyr
    {
        public string Navn { get; set; }

        static Random rnd = new Random();

        public virtual void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {this.Navn}");
        }

        public Dyr()
        {

        }

        public static Dyr Tilfældigtdyr()
        {
            
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            
            int tilfældigt = rnd.Next(0, navne.Length);

            if (tilfældigt % 2 == 0)
            {
                Dyr test = new Hund() { Navn = navne[tilfældigt] };
                return test;
            }
            else
            {
                Dyr test = new Kat() { Navn = navne[tilfældigt] };
                return test;
            }
        }
    }
}
