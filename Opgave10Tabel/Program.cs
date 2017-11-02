using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave10Tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int k = 1; k < 11; k++)
                {
                    string tal = (i * k).ToString();


                    if ((i*k) % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if((i * k) > 50)
                        {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    }
                    
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                   
                    Console.Write(tal.PadLeft(5));
                }
                Console.Write("\r\n");
            }

        }
    }
}
