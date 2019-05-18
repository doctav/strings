using System;
using System.Diagnostics;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = " Ana are mere! ";
            Console.WriteLine($"index of a: {myString.IndexOf('a')}");
            Console.WriteLine($"last index of a: {myString.LastIndexOf('a')}");

            Console.WriteLine("Salutare!");

            string mere = myString.Substring(9, 4);
            Console.WriteLine(mere);

            string cleanedString = myString.Trim();
            Console.WriteLine(cleanedString);

            string replacedString = myString.Replace(" ", ".");
            Console.WriteLine(replacedString);

            string replaceA = myString.Replace("a", "!", false, new System.Globalization.CultureInfo("en-us"));
            Console.WriteLine(replaceA);

            //split
            string[] splitted = myString.Trim().Split(" ");
            for (int i = 0; i < splitted.Length; i++)
            {
                Console.WriteLine(splitted[i]);
            }

            Console.WriteLine(myString.ToLower());

            Console.WriteLine(myString.Remove(9, 4));

            Console.WriteLine(myString);

            //concatenation
            string concatenated = "";
            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 10000; i++)
            {
                concatenated = concatenated + i.ToString();
            }
            timer.Stop();

            //Console.WriteLine(concatenated);
            Console.WriteLine(timer.Elapsed);

            //StringBuilder
            StringBuilder sb= new StringBuilder();
            //concatenation
            Stopwatch timerStringBuilder = new Stopwatch();
            timerStringBuilder.Start();

            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i.ToString());
            }
            timerStringBuilder.Stop();

            //Console.WriteLine(sb.ToString());
            Console.WriteLine(timerStringBuilder.Elapsed);

        }
    }
}



