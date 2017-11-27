namespace Module10_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    interface IMaskine
    {
        void Start();
        void Stop();

        int Status(bool v);
    }

    class Tandbørste : IMaskine {

        public void Start() { }
        public void Stop() { }

        public int Status(bool v)
        {
            return 0;
        }
    }

    class Lastbil : IMaskine
    {
        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public int Status(bool v)
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}
