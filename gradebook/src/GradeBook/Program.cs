using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i];
                Console.WriteLine($"arg: {arg}");
            }

            while (true)
            {
                Console.WriteLine("Enter your name, or (Q, q) to quit: ");
                string name = Console.ReadLine();

                if (name == "Q" || name == "q")
                {
                   break; 
                }
                Console.WriteLine($"The number is: {name} \n");
            }

        }
    }
}
