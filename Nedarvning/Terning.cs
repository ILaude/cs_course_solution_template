using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get
            {
                Console.WriteLine("Der aflæses værdien som " + this.værdi);

                return værdi; }
            set
            {
                if (value < 1 || value > 6)
                {
                    value = 1;
                }

                Console.WriteLine("Der tildeles værdien " + value);
                værdi = value; }
        }

        private static Random rnd = new Random();


        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + Værdi + "]");
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
