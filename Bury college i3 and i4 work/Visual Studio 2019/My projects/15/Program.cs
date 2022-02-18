using System;

namespace _15
{
    class Program
    {
        public static int[] PossibleNumbers = new int[9];


        public static void SetNumber()
        {

            PossibleNumbers[0] = 1;
            PossibleNumbers[1] = 2;
            PossibleNumbers[2] = 3;
            PossibleNumbers[3] = 4;
            PossibleNumbers[4] = 5;
            PossibleNumbers[5] = 6;
            PossibleNumbers[6] = 7;
            PossibleNumbers[7] = 8;
            PossibleNumbers[8] = 9;

        }



        static void Main(string[] args)
        {
            Console.WriteLine("you area going to play a 2 player game called '15'.");
            Console.WriteLine("Would you like to read the rules? Y/N");
            string ReadRules;
            ReadRules = Console.ReadLine().ToUpper();

            if (ReadRules == "Y")
            {
                Console.WriteLine("You have to add 3 numbers to make 15 by taking turns to input your number, a number which has already been used cannot be used again.");
            }


            Console.WriteLine("Start game ");
            Console.WriteLine("Chose from the following numbers");

            Console.WriteLine(PossibleNumbers[0].ToString());
            Console.WriteLine(PossibleNumbers[1].ToString());
            Console.WriteLine(PossibleNumbers[2].ToString());
            Console.WriteLine(PossibleNumbers[3].ToString());
            Console.WriteLine(PossibleNumbers[4].ToString());
            Console.WriteLine(PossibleNumbers[5].ToString());
            Console.WriteLine(PossibleNumbers[6].ToString());
            Console.WriteLine(PossibleNumbers[7].ToString());
            Console.WriteLine(PossibleNumbers[8].ToString());

            Console.WriteLine("Player 1 pick your first number");
            int p1n1;
            p1n1 =int.Parse(Console.ReadLine());

            Console.WriteLine("Player 2 pick your first number");
            int p2n1;
            p2n1 = int.Parse(Console.ReadLine());


        }
    }
}
