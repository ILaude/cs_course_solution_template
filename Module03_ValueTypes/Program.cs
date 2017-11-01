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

            Person b;
            b.navn = "Bibo";
            b.alder = 4;


            Person e;
            e.navn = "Evariste";
            e.alder = 4;

            b = e;

            e.alder = 3;

            DateTime nu = DateTime.Now;
            DateTime jul = new DateTime(2017, 12, 24);

            TimeSpan t = jul.Subtract(nu);

            Console.WriteLine("Antal dage til jul:");
  
            Console.WriteLine(t.TotalDays);

            const decimal momsPct = 0.25M;
            // momsPct = 1; const kan ikke ændres

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
    // værdibaseret klasse (struc på stack)
    struct Person
    {
        public string navn;
        public int alder;
    }
}
