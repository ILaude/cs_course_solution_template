using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terningspil;

namespace Terningspil
{
    public class Bæger
    {
        private Terning[] terninger;

        private int antalTerninger;

        public int AntalTerninger
        {
            get { return antalTerninger; }
            set {
                if (value <= 0)
                {

                    Console.WriteLine("Jeg giver dig en terning!");
                    value = 1;
                }

                antalTerninger = value;
            }
        }


        public Bæger(int antal)
        {
            this.AntalTerninger = antal;
            terninger = new Terning[AntalTerninger];
            for (int i = 0; i < AntalTerninger; i++)
            {
                terninger[i] = new Terning();
            }
        }
    }

   
}
