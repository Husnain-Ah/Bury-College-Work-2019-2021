using System;

namespace Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your third number");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your fourth number");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1}{num2}{num3}{num4} \n{num1}{num2}{num4}{num3} \n{num1}{num3}{num2}{num4} \n{num1}{num3}{num4}{num2} \n{num1}{num4}{num2}{num3} \n{num1}{num4}{num3}{num2} ");
            Console.WriteLine($"{num2}{num1}{num3}{num4} \n{num2}{num1}{num4}{num3} \n{num2}{num3}{num1}{num4} \n{num2}{num3}{num4}{num1} \n{num2}{num4}{num2}{num1} \n{num2}{num4}{num3}{num1} ");
            Console.WriteLine($"{num3}{num2}{num1}{num4} \n{num3}{num2}{num4}{num1} \n{num3}{num1}{num2}{num4} \n{num3}{num1}{num4}{num2} \n{num3}{num4}{num2}{num1} \n{num3}{num4}{num1}{num2} ");
            Console.WriteLine($"{num4}{num2}{num3}{num1} \n{num4}{num2}{num1}{num3} \n{num4}{num3}{num2}{num4} \n{num4}{num3}{num1}{num2} \n{num4}{num1}{num2}{num3} \n{num4}{num1}{num3}{num2} ");
        }
    }
}
