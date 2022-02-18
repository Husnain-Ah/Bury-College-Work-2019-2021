using System;

namespace switch_extended
{
    class Program
    {
        static void Hello()
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
       
        static void maths()
        {
            Console.WriteLine("what is 2 * 2");
            answer = int (Console.ReadLine());
            if (answer) = 4;
            Console.WriteLine("well done")
            else;
            Console.WriteLine("nope");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Procedures and functions");
            Console.WriteLine("Programmed by Husnain Ahmed");
            Console.WriteLine("************************");

            int userInput;
            string exit = "N";

            do
            {
                userInput = 0;
                Console.WriteLine("Please enter a number form 1 - 8");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Hello();
                        break;
                    case 2:
                        maths();
                        break;

                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }

                Console.ReadLine();

                Console.WriteLine("Please enter a number 1-8");
                exit = Console.ReadLine();
            } while (exit == "y");
        }
    }
}
