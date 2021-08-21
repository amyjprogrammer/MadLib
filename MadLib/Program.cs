using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;
                
            Console.Write("Please enter a color: ");
            color = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Please enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are {0}", color);
            Console.WriteLine("{0} are blue", pluralNoun);
            Console.WriteLine("I love {0}", celebrity);

            Console.ReadLine();
        }
    }
}
