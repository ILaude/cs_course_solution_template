using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
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

    }
}
