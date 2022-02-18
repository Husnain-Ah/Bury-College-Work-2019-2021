using System;

namespace iteration
{
    class ForLoopTest
    {
        static void Main()
        {
            for(int i = 1; i <= 5; i++)
        {
                Console.WriteLine(i);
            }
            {
                int n = 1;
                while (n<6)
                {
                    Console.WriteLine("Current value of n is {0}", n);
                    n++;
                }
            }
        }
    }
}
