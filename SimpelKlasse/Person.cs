using System;

namespace SimpelKlasse
{
    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string Fuldtnavn()
        {
            string Fuldtnavn = this.Fornavn + " " + this.Efternavn;
            return Fuldtnavn;
        }

        public int Alder()
        {
            int nuværendeÅr = DateTime.Now.Year;
            int alder = nuværendeÅr - this.Fødselsår;
            return alder;
        }

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string fornavn, string eftenavn, int fødselsår)
        {
            this.Fornavn = fornavn.ToUpper();
            this.Efternavn = eftenavn.ToUpper();
            this.Fødselsår = fødselsår;

        }
    }
}
