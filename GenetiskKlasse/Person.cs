using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetiskKlasse
{
    class Person
    {
        public string Navn { get; set; }

    }

    class Kursist : Person
    {
        public int KursistId { get; set; }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }

    class Person1
    {
        private List<Person> personer = new List<Person>();
        public void Tilføj(Person p)
        {
            personer.Add(p);
        }

    }

    class Person2<T>
    {
        private List<T> personer = new List<T>();
        public void Tilføj(T p)
        {
            personer.Add(p);
        }
    }

    class Person3<T> where T : Person
    {
        private List<T> personer = new List<T>();
        public void Tilføj(T p)
        {
            personer.Add(p);
        }
    }
}
