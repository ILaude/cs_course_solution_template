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

        public Bæger()
        {
            terninger = new Terning[5];
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }
        }
    }

   
}
