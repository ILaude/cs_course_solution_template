using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionKort
{
    class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void TilføjKort(Kort k)
        {
            bunke.Push(k);
        }

        public Kort FjernKort()
        {
            if (bunke.Count > 0)
            {
                return bunke.Pop(); 
            }
            return null;
        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
