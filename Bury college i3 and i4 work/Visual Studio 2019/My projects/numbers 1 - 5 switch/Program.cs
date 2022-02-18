using System;

namespace numbers_1___5_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.Write("Please enter a number from  1 to 5 ");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("1");
                    break;

                case 2:
                    Console.WriteLine("2");
                    break;

                case 3:
                    Console.WriteLine("3");
                    break;

                case 4:
                    Console.WriteLine("4");
                    break;

                case 5:
                    Console.WriteLine("5");
                    break;

                default:
                    Console.WriteLine("wrong");
                    break;
            }

        }
    }
}
