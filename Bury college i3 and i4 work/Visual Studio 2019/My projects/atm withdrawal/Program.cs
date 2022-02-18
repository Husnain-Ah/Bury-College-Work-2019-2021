using System;

namespace atm_withdrawal
{
    class Program
    {
        static void Main(string[] args)
        {
            int withdraw;
            Console.WriteLine("type how much money you would like to withdraw in numbers (WITHOUT THE POUND SIGN)");
            withdraw = int.Parse(Console.ReadLine());
            if (withdraw > 100)
            {
                Console.WriteLine("you have gone over the withdrawal limit of 100 please input a number less than 100");
            }
            else
            {
                Console.WriteLine("You have Withdrawn £" + withdraw + " from your account.");
            }

        }
    }
}
