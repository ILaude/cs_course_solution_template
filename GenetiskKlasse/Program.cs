using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetiskKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Navn = "Hans" };
            Kursist k = new Kursist() { Navn = "Grete", KursistId = 3 };
            Instruktør i = new Instruktør() {Navn = "Heks", NøgleId = 45 };

            Person1 person1 = new Person1();
            person1.Tilføj(p);
            person1.Tilføj(k);
            person1.Tilføj(i);


            //foreach (var person in person1)
            //{
            //    Console.WriteLine(person.N);
            //}

            Person2<Person> person2 = new Person2<Person>();
            person2.Tilføj(p);
            person2.Tilføj(k);
            person2.Tilføj(i);

            Person3<Person> person3 = new Person3<Person>();
            person3.Tilføj(p);
            person3.Tilføj(k);
            person3.Tilføj(i);


        }
    }
}
