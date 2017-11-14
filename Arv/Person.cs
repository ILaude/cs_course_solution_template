using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string Fuldtnavn()
        {
            return $"{this.Fornavn} {this.Efternavn}" ;
        }

        public Person()
        {

        }
    }
}
