using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.MinApp
{
    class Elev : Kursusdeltager
    {
        public string ElevId { get; set; }

        public Elev(string navn, string cpr, string id) : base(navn, cpr)
        {
            ElevId = id;
        }

        public override void Skriv()
        {
            Console.WriteLine("Navn: " + Navn + " med CPR " + Cpr + " og elevid " + ElevId);
        }
    }
}
