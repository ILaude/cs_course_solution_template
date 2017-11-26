using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.MinApp
{
    class Instruktør : Kursusdeltager
    {
        public string Nøgle { get; set; }

        public Instruktør(string navn, string cpr, string nøgle) : base(navn, cpr)
        {
            Nøgle = nøgle;
        }

        public override void Skriv()
        {
            Console.WriteLine("Navn: " + Navn + " med CPR " + Cpr + " og nøgle " + Nøgle);
        }
    }
}
