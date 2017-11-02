using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveStrenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);
            string[] deltNavn = samletNavn.Split(' ');

            for (int i = 0; i < deltNavn.Length; i++)
            {
                Console.WriteLine(deltNavn[i]);
            }

            string adresse = "Rådhuspladsen\r\nKøbenhavn";
            Console.WriteLine(adresse);

            string filNavn = @"C:\temp\test.txt";
            System.IO.File.WriteAllText(filNavn, samletNavn + "\r\n" + adresse);
            

        }
    }
}
