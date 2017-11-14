using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArealBeregninger
{
    public static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double højde, double brede)
        {
            return højde * brede;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
