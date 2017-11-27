using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] dbFunktioner = new IDbFunktioner[4];
            dbFunktioner[0] = new Hund();
            dbFunktioner[1] = new Ubåd();
            dbFunktioner[2] = new Hund();
            dbFunktioner[3] = new Ubåd();

            foreach (var item in dbFunktioner)
            {
                item.Gem();
            }
        }
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund...") ;
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }
}
