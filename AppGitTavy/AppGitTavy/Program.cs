using System;
using System.Text;

namespace AppGitTavy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the first git syncronized project.");
            Console.WriteLine("This is my branch!");
            Console.WriteLine("Sincronizarea a 3-a.");
            Console.WriteLine("A 4-a sincronizare.");
            Console.WriteLine("Hello World! This is the first git syncronized project. Good luck!");

            //sume diverse
            Console.WriteLine(CalculateSum(2, 5));
            Console.WriteLine(CalculateSum());
            Console.WriteLine(CalculateSum(10, 30, 40, 50));

            //stringuri diverse
            string nume = "Ionel";
            int len = nume.Length;
            Console.WriteLine("Lungime sir=" + len);
            Console.WriteLine(nume[2]);
            Console.WriteLine($"s=\"{nume}\"");
            for (int i = 0; i < nume.Length; i++)
            {
                Console.WriteLine($"s[{i}]={nume[i]}");
            }
            ////citire de la consola
            //Console.WriteLine("Numele dvs.?");
            //nume = Console.ReadLine();
            //Console.WriteLine($"Salutare, {nume}. Sa aveti o zi frumoasa!");
            string nume1, nume2;
            nume1 = "Tavy";
            nume2 = "Nico";
            if (string.Compare(nume1, nume2) == 0)
                Console.WriteLine($"{nume1} si {nume2} sunt identice");
            else
                if (string.Compare(nume1, nume2) < 0)
                Console.WriteLine($"{nume1} este INAINTE de {nume2}");
            else
                Console.WriteLine($"{nume1} este DUPA {nume2}");

            //gasire primul sir in ordine lexicografica dintr-o colectie de siruri
            string[] towns = { "Cluj-Napoca", "Brasov", "Iasi", "Bucuresti", "Oradea", "Timisoara", "Alba Iulia" };
            string primul = towns[0];
            for (int i = 1; i < towns.Length; i++)
            {
                if (string.Compare(primul, towns[i]) > 0)
                    primul = towns[i];
            }
            Console.WriteLine($"Primul oras este {primul}");

            //concatenare siruri
            string numeComplet;
            numeComplet = string.Concat(nume1, "  ", nume2);
            Console.WriteLine($"Nume complet = {numeComplet}");

            //cautare siruri
            string sirDeBaza = "C# Programming Course";
            string sirCautat = "Course";
            int index;
            index = sirDeBaza.IndexOf(sirCautat);
            Console.WriteLine($"Subsirul \"{sirCautat}\" este la pozitia {index}");

            //extragere siruri
            string sirExtras;
            sirExtras = sirDeBaza.Substring(3, 7);
            Console.WriteLine($"Sirul extras este {sirExtras}");

            //splitare siruri pe baza de separatori
            string sirComplet = "Ionel, Vasile, Maria, Ionela, Gigel";
            string[] siruriSplitate = sirComplet.Split(',', ' ');
            foreach (var sir in siruriSplitate)
            {
                Console.WriteLine(sir);
            }

            //inlocuire sub-siruri
            sirComplet = sirComplet.Replace(", ", "+");
            Console.WriteLine(sirComplet);

            //changing character casing
            sirComplet = sirComplet.ToLower();
            Console.WriteLine(sirComplet);
            sirComplet = sirComplet.ToUpper();
            Console.WriteLine(sirComplet);

            //StringBuilder
            StringBuilder sb= new StringBuilder();
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.MaxCapacity);  
            sb.Append("Unu");
            sb.Append("Doi");
            Console.WriteLine(sb.ToString() + "  " + sb.Length);

            int salariu = 2345;
            string s;
            s = salariu.ToString("D10");  //D= number cu 10 caractere
            s = salariu.ToString("C");      //default culture (currency)
            Console.WriteLine(s);

            double procent = 0.5726;
            s = procent.ToString("P4");  //procent cu 4 zecimale
            Console.WriteLine(s); 
        }


        static long CalculateSum(params int[] elements)
        {
            long sum = 0;
            foreach (var element in elements)
            {
                sum += element;
            }
            return sum;
        }


        static int CalculSumaRecursiv(int N)
        {
            if (N == 0)
                return 0;
            else
                return N + CalculSumaRecursiv(N - 1);

        }
    }
}
