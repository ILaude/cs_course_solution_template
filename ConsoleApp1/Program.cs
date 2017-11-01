using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn:");
            string navn = Console.ReadLine();
            string navnMedStort = navn.ToUpper();
            Console.WriteLine("Velkommen " + navnMedStort);
            Console.WriteLine("Tryk på en tast for at fortsætte");
            Console.ReadKey();
        }
    }
}
