using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();

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

            Console.Write("Let's cube a number, please enter the number: ");
            string num = Console.ReadLine();
            int cubeNumber = Int32.Parse(num);
            Console.WriteLine("The cube of {0} is {1}", num, CubeNum(cubeNumber));

            Console.ReadLine();

        }
        static void SayHi()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to Madlib, {0}", name);
        }

        static int CubeNum(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
