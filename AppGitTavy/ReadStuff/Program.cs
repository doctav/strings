using System;

namespace ReadStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //string readedLine = Console.ReadLine();
            //Console.WriteLine(readedLine.Length/2f);

            //Console.WriteLine("Hello World!");
            string name1, name2;
            Console.WriteLine("Insert the first name");
            name1=Console.ReadLine();
            Console.WriteLine("Insert the second name");
            name2=Console.ReadLine();

            if (name1==name2)
                Console.WriteLine("OK");
            {

            }

            //Compare
            if(string.Compare(name1,name2)==0)
                Console.WriteLine("The names are equal");
            else
                if (string.Compare(name1,name2)<0)
                Console.WriteLine($"{name1} if before {name2}");
            else
                Console.WriteLine($"{name1} is after {name2}");

            
            
            {

            }
        }
    }
}
