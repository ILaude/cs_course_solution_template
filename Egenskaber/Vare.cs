using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber
{
    class Vare
    {
        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Der aflæses navn");
                return navn; }
            set {
                Console.WriteLine("Der tildeles navn"  );
                navn = value; }
        }

        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("Der aflæses pris");
                return pris;
            }
            set
            {
                if (value <0)
                {
                    Console.WriteLine("Negativ værdi");
                    value = 0;
                }
                Console.WriteLine("Der tildeles pris");
                pris = value;
            }
        }

        public Vare()
        {
            this.Navn = "";
            this.Pris = 0;
        }
        public Vare(string navn, int pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }
        public double PrisMedMoms()
        {
            return this.pris*1.25;
        }


    }
}
