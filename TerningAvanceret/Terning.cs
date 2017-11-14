using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningspil
{
    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get {
                Console.WriteLine("Terningen aflæses");
                return værdi; }
            set
            {
                Console.WriteLine("Terningen tildeles en værdi");
                if (value < 1 || value > 6)
                {
                    value = 1;
                }
                værdi = value; }
        }

        private static System.Random rnd = new Random();

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }
        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

    }
}
