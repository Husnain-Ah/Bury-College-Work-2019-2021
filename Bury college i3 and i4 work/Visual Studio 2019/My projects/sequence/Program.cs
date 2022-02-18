using System;

namespace sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = ("");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            int age;
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("In 10 years you will be " + (age + 10));
        }
    }
}
