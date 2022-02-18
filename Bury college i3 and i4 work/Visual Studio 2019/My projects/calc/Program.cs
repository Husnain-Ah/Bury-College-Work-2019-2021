using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input 2 numbers");
            Console.WriteLine("input number 1");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("input number 2");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine(n1+n2);
            Console.WriteLine(n1*n2);
            Console.WriteLine(n1-n2);
            Console.WriteLine(n1/n2);
        }
    }
}

