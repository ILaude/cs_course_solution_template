using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.MinApp
{
    abstract class Person
    {
        public string Navn { get; set; }

        protected string Cpr;

        public Person(string navn, string cpr)
        {
            this.Navn = navn;
            this.Cpr = cpr;
        }

        public virtual void Skriv()
        {
            Console.WriteLine("Navn: " + Navn + " med CPR " + Cpr);
        }

        public static bool CprOk(string cpr)
        {
            if (cpr.Length == 11)
            {
                if (cpr[6] == '-')
                {
                    return true;
                }
                return false;
            }

            return false;
        }

    }
}
