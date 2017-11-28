using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            w.Created += (s, e) => Console.WriteLine("Filen {0} oprettes", e.Name);
            w.Deleted += (s, e) => Console.WriteLine("Filen {0} slettes", e.Name);
            w.Changed += (s,e) => Console.WriteLine("Filen {0} ændres", e.Name);


            do
            {

            } while (true);
        }
    }
}
