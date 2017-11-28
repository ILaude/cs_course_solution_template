using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -500, Saldo = 0 };
            k.kreditoverskrevet += (s, e) => Console.WriteLine("Kredit overskrevet med " + e.overskrevetMed);
            k.Køb(200);
            k.Køb(500);

        }
    }

    public class Kunde
    {
        public EventHandler<EventKredit> kreditoverskrevet;
        //public EventHandler kreditoverskrevet = (s, e) => Console.WriteLine("Kredit overskrevet");
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                if (kreditoverskrevet != null)
                {
                    kreditoverskrevet(this, new EventKredit() {overskrevetMed = (KreditMax-Saldo) });
                }
            }
        }
    }

    public class EventKredit : EventArgs
    {
        public int overskrevetMed { get; set; }
    }
}
