using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Terning
    {
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
        public Terning()
        {
            this.Ryst();
        }
        private static System.Random rnd = new System.Random();

        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set
            {
                if (value<1 || value > 6)
                {
                    value = 1;
                }
                værdi = value; }
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.Write("[" + this.værdi + "]");
        }

    }
}
