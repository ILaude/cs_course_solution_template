using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvningPolymorfi
{
    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get
            {

                return værdi; }
            set
            {
                if (value < 1 || value > 6)
                {
                    value = 1;
                }

                værdi = value; }
        }

        private static Random rnd = new Random();


        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }

        public virtual void Skriv()
        {
            Console.Write("[" + Værdi + "]");
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int værdi)
        {
            Værdi = værdi;
        }



    }
}
