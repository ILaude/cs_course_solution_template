namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn;
            månedsløn = new int[5];
            månedsløn[0] = 1000;
            månedsløn[1] = 3000;
            månedsløn[2] = 2000;
            månedsløn[3] = 2000;
            månedsløn[4] = 2000;

            decimal gns = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                gns += månedsløn[i];
            }

            gns = gns / månedsløn.Length;

            System.Console.WriteLine(gns.ToString("n2"));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
