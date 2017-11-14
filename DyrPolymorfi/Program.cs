using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyrPolymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] samlingDyr = new Dyr[20];
            for (int i = 0; i < samlingDyr.Length; i++)
            {
                samlingDyr[i]= DyrPolymorfi.Dyr.Tilfældigtdyr();
            }

            foreach (var dyr in samlingDyr)
            {
                dyr.SigNoget();
            }

        }
    }
}
