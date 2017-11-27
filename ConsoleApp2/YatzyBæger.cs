using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class YatzyBæger
    {
        private Terning[] Terninger { get; set; }

        public YatzyBæger()
        {
            this.Terninger = new Terning[5];
            for (int i = 0; i < Terninger.Length; i++)
            {
                Terninger[i] = new Terning();
            }
        }

        public void Ryst()
        {
            for (int i = 0; i < this.Terninger.Length; i++)
            {
                this.Terninger[i].Ryst();
            }
        }

        public void Skriv()
        {
            for (int i = 0; i < Terninger.Length; i++)
            {
                Terninger[i].Skriv();
            }
            Console.WriteLine();
        }

        public int AntalTerningerMedGivenVærdi(int værdi)
        {
            var antal = 0;
            for (int i = 0; i < Terninger.Length; i++)
            {
                if (Terninger[i].Værdi == værdi)
                {
                    antal++;
                }
            }
            return antal;
        }

        public List<int> VærdiSomDerErEtGivenAntalAf(int værdi)
        {
            List<int> liste = new List<int>();

            for (int i = 1; i < 7; i++)
            {
                if (AntalTerningerMedGivenVærdi(i) == værdi)
                {
                    liste.Add(i);
                }
            }

            return liste;
        }

        public int MaxAntalEns()
        {
            var max = 0;
            for (int i = 1; i < 7; i++)
            {
                max = Math.Max(max, AntalTerningerMedGivenVærdi(i));
            }
            return max;
        }


        public bool FemEns()
        {
            if (MaxAntalEns()==5)
            {
                //Console.WriteLine("Du har fem ens.");
                return true;
            }

            //Console.WriteLine("Du har ikke fem ens.");
            return false;
        }


        public bool FireEns()
        {
            for (int i = 1; i < 7; i++)
            {
                if (this.AntalTerningerMedGivenVærdi(i) == 4)
                {
                    //Console.WriteLine("Du har fire ens.");
                    return true;
                }
            }

            //Console.WriteLine("Du har ikke fire ens.");
            return false;
        }


        public bool TreEns()
        {
            for (int i = 1; i < 7; i++)
            {
                if (this.AntalTerningerMedGivenVærdi(i) == 3)
                {
                    //Console.WriteLine("Du har tre ens.");
                    return true;
                }
            }

            //Console.WriteLine("Du har ikke tre ens.");
            return false;
        }

        public int AntalPar()
        {
            var antal = 0;

            for (int i = 1; i < 7; i++)
            {
                if (this.AntalTerningerMedGivenVærdi(i) == 2)
                {
                    antal++;
                }
            }

            return antal;
        }

        public bool ToPar()
        {
            if (AntalPar() == 2)
            {
                //Console.WriteLine("Du har to par.");
                return true;
            }

            //Console.WriteLine("Du har ikke to par.");
            return false;
        }

        public bool EtPar()
        {
            if (AntalPar() == 1)
            {
                //Console.WriteLine("Du har et par.");
                return true;
            }

            //Console.WriteLine("Du har ikke et par.");
            return false;
        }

        public bool FuldtHus()
        {
            if (TreEns() && EtPar())
            {
                //Console.WriteLine("Du har fuldt hus.");
                return true;
            }

            //Console.WriteLine("Du har ikke fuldt hus.");
            return false;
        }

        public bool LilleStraight()
        {
            if (MaxAntalEns() == 1 && AntalTerningerMedGivenVærdi(6) == 0)
            {
                return true;
            }
            return false;
        }

        public bool StorStraight()
        {
            if (MaxAntalEns() == 1 && AntalTerningerMedGivenVærdi(1) == 0)
            {
                return true;
            }
            return false;
        }
        public void Resultat()
        {
            if (FuldtHus())
            {
                Console.WriteLine("Du har fuldt hus.");
            }
            else if (FemEns())
            {
                Console.WriteLine("Du har fem ens.");
                Console.WriteLine(Points() + " point");
            }

            else if (FireEns())
            {
                Console.WriteLine("Du har fire ens.");
                Console.WriteLine(Points() + " point");
            }

            else if (TreEns())
            {
                Console.WriteLine("Du har tre ens.");
                Console.WriteLine(Points() + " point");
            }

            else if (ToPar())
            {
                Console.WriteLine("Du har to par.");
                Console.WriteLine(Points() + " point");
            }

            else if (EtPar())
            {
                Console.WriteLine("Du har et par.");
                Console.WriteLine(Points() + " point");
            }

            else if(LilleStraight())
            {
                Console.WriteLine("Du har en lille straight.");
                Console.WriteLine(Points() + " point");
            }

            else if (StorStraight())
            {
                Console.WriteLine("Du har en stor straight.");
                Console.WriteLine(Points() + " point");
            }

            else
                Console.WriteLine("Du har ikke noget brugbart");

        }

        public int Points()
        {
            if (FemEns())
            {
                var points = 0;

                foreach (var item in VærdiSomDerErEtGivenAntalAf(5))
                {
                    points += 5 * item;
                }

                return points;
            }
            if (FireEns())
            {
                var points = 0;

                foreach (var item in VærdiSomDerErEtGivenAntalAf(4))
                {
                    points += 4 * item;
                }

                return points;
            }

            if (TreEns())
            {
                var points = 0;


                foreach (var item in VærdiSomDerErEtGivenAntalAf(3))
                {
                    points += 3 * item;
                }

                return points;
            }

            if (EtPar())
            {
                var points = 0;

                foreach (var item in VærdiSomDerErEtGivenAntalAf(2))
                {
                    points += 2 * item;
                }




                return points;
            }

            if (ToPar())
            {
                var points = 0;

                foreach (var item in VærdiSomDerErEtGivenAntalAf(2))
                {
                    points += 2 * item;
                }




                return points;
            }

            if (FuldtHus())
            {
                var points = 0;

                foreach (var item in VærdiSomDerErEtGivenAntalAf(3))
                {
                    points += 3 * item;
                }

                foreach (var item in VærdiSomDerErEtGivenAntalAf(2))
                {
                    points += 2 * item;
                }


                return points;
            }


            if (LilleStraight())
            {
                return 15;
            }

            if (StorStraight())
            {
                return 20;
            }


                return 0;
        }
    }
}
