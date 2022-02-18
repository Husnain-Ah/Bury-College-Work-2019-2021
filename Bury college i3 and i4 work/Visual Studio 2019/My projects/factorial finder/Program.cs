using System;

namespace factorial_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numinput1 = 0;
            int answer = 0;
            Console.WriteLine("Enter a whole number");
            numinput1 = int.Parse(Console.ReadLine());
            answer = 1;

            if (numinput1 == 0)
            {
                answer = 1;
                Console.WriteLine("Your answer is " + answer);
            }
            else
            {
                for (int i = numinput1; i> 0; i--)
                {
                    answer = answer * i;
                }
            }
            Console.WriteLine($"The factorial of {numinput1} = {answer}");
        }
    }
}
