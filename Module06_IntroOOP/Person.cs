namespace Module06_IntroOOP
{
    class Person
    {
        public string name;
        private int age;
        public string[] pets;

        // Default constructor(ingen argumenter)
        public Person()
        {
            name = "";
            age = 0;
            pets = new string[2];
            pets[0] = "Dog";
            pets[1] = "Cat";
        }

        // Custom constructor
        public Person(string name, int age)
        {
            if (name == "")
            {
                System.Console.WriteLine("Fejl");
            }
            this.name = name;
            this.age = age;
        }

        public Person(string name) : this(name, 0)
        {

        }

        // Destructor
        ~Person()
        {
            System.Console.WriteLine("Nu dør jeg ...");
        }
    }
}
