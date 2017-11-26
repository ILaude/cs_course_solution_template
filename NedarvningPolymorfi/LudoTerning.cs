using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvningPolymorfi
{
    class LudoTerning : Terning
    {
        public LudoTerning() : base()
        {

        }

        public LudoTerning(int værdi) : base(værdi)
        {

        }

        public bool ErGlobus()
        {
            return Værdi == 3;
        }

        public bool ErStjerne()
        {
            return Værdi == 5;
        }

        public override void Skriv()
        {
            switch (this.Værdi)
            {
                case 3:
                    Console.Write("[G]");
                    break;
                case 5:
                    Console.Write("[S]");
                    break;
                default:
                    base.Skriv();
                    break;
            }
        }

    }
}
