using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Terning
    {
        public int værdi;
        private bool snyd;

        private static System.Random rnd = new Random();

        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi.ToString() +"]");
        }
        public void Ryst()
        {
            if (this.snyd)
            {
                this.værdi = 6;
            }
            else
            {
                this.værdi = rnd.Next(1, 7);
            }
        }

        public Terning()
        {
            this.Ryst();
            this.snyd = false;
        }

        public Terning(int værdi)
        {
            if (værdi< 1 || værdi > 6)
            {
                this.værdi = 2;
            }
            else
            {
                this.værdi = værdi;
            }
        }

        public Terning(bool snyd)
        {
            this.Ryst();
            this.snyd = snyd;
        }
    }
}
