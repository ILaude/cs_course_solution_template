using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyrPolymorfi
{
    public class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {this.Navn}"); ;
        }
    }
}
