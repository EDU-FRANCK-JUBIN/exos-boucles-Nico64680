using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBoucle
{
    public static class Boucle
    {
        public static void E1()
        {
            Console.WriteLine("/// FOR ///");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("/// WHILE ///");
            int ia = 0;
            while (ia <= 20)
            {
                if(ia % 2 == 0)
                {
                    Console.WriteLine(ia);
                }
                ia++;
            }
        }

        public static void E2()
        {
            Console.WriteLine("/// votre chiffre ///");
            int nbr = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 0; i <= nbr; i++)
            {
                result = result + i;
            }

            Console.WriteLine("Resultat : {0}", result);
        }

        public static void E3()
        {
            Console.WriteLine("Entrer 5 valeurs");
            List<double> nbrs = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valeur {0}", i + 1);
                double input = Convert.ToDouble(Console.ReadLine());
                nbrs.Add(input);
            }

            Console.WriteLine("La moyenne est : {0}", nbrs.Average());
        }

        public static void SommeEntier(int nbrDebut, int nbrFin)
        {
            int iDebut = nbrDebut;
            int resultSomme = 0;

            while (iDebut >= nbrDebut && iDebut <= nbrFin)
            {
                resultSomme = resultSomme + iDebut;
                iDebut++;
            }

            Console.WriteLine("Resultat : {0}", resultSomme);
        }

        public static void CalculMoyenne(List<double> l)
        {
            Console.WriteLine(l.Average());
        }

        public static void E5()
        {
            List<int> mult3 = new List<int>();
            List<int> mult5 = new List<int>();
            int somCommune = 0;

            for (int i = 0; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    mult3.Add(i);
                }
            }

            for (int i = 0; i <= 100; i++)
            {
                if(i % 5 == 0)
                {
                    mult5.Add(i);
                }
            }

            foreach (var item3 in mult3)
            {
                foreach (var item5 in mult5)
                {
                    if(item3 == item5)
                    {
                        somCommune += item3 + item5;
                    }
                }
            }

            Console.WriteLine("Total : {0}", somCommune);
        }
    }
}
