using System;

namespace Iteration1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Times tables program");
            Console.WriteLine("Programmed by husnain ahmed");
            Console.WriteLine("***************");

            int multiplicationValue;

            Console.WriteLine("Please enter a times tables value e.g. 5");
            multiplicationValue = int.Parse(Console.ReadLine());

            for(int i = 1; i<= 10; i++)
            {
                Console.WriteLine(i + " times by " + multiplicationValue + " = " + i * multiplicationValue);
            }
            Console.ReadLine();
        }
    }
}
