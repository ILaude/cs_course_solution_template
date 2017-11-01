using System;

namespace Module03_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {// stacken : value types, heap : reference types
            // Leg med debug.

            // int og string er typer. Pejer på pladser i hukommelsen.
            int x = 1; //
            string navn = "Tom";

            // var = find selv ud af det.
            var i = 1.0;

            int y = 6;
            x = y;
            x = 100;

            x.ToString();

            Kunde b;
            b.navn = "Bibo";
            b.alder = 4;
            b.køn = Køn.Kvinde;


            Kunde e;
            e.navn = "Evariste";
            e.alder = 4;
            e.køn = Køn.Mand;

            b = e;

            e.alder = 3;

            DateTime nu = DateTime.Now;
            DateTime jul = new DateTime(2017, 12, 24);

            TimeSpan t = jul.Subtract(nu);

            Console.WriteLine("Antal dage til jul:");
  
            Console.WriteLine(t.TotalDays);

            int tal = 1;
            tal++;
            tal += 1;
            tal = tal + 1; // alle ens!

            int ms = DateTime.Now.Millisecond;
            // var ms = DateTime.Now.Millisecond;

            char tegn = 'e';
            Console.WriteLine(tegn.ToString());

            int yyy = 500;
            short uu = Convert.ToInt16(yyy);

            const decimal momsPct = 0.25M;
            // momsPct = 1; const kan ikke ændres

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    enum Køn
    {
        Mand,
        Kvinde
    }
    // værdibaseret klasse (struc på stack)
    struct Kunde
    {
        public string navn;
        public int alder;
        public Køn køn;
    }
}
