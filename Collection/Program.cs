using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Person() {Id = 4, Navn ="Ida" });
            personer.Add(new Person() { Id = 5, Navn = "Sune" });
            personer.Add(new Person() { Id = 24, Navn = "Mikkel" });

            foreach (var person in personer)
            {
                Console.WriteLine(person.Navn);
            }

            Dictionary<int, Person> dictionary = new Dictionary<int, Person>();
            dictionary.Add(1, new Person() { Id = 4, Navn = "Ida" });
            dictionary.Add(2, new Person() { Id = 5, Navn = "Sune" });
            dictionary.Add(3, new Person() { Id = 24, Navn = "Mikkel" });
            Console.WriteLine(dictionary[2].Navn);



        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
