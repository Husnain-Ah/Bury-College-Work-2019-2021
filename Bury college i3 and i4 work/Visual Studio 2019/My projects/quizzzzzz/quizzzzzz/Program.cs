using System;

namespace quizzzzzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string answerText = "";  //this string stores your answers as a variable
            int score = 0; // this turns your score into an integer variable

            do
            {
                Console.WriteLine("What is 10*10"); //asks a question

                answerText = Console.ReadLine();

                if (answerText == "100")
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            } while (answerText != "100");

            do
            {
                Console.WriteLine("What is 9*10");

                answerText = Console.ReadLine();

                if (answerText == "90")
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            } while (answerText != "90");

            do
            {
                Console.WriteLine("What is 8*10");

                answerText = Console.ReadLine();

                if (answerText == ("80"))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            } while (answerText != "80");

            do
            {
                Console.WriteLine("What is 7*10");

                answerText = Console.ReadLine();

                if (answerText == "70")
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            } while (answerText != "70");

            do
            {
                Console.WriteLine("What is 6*10");

                answerText = Console.ReadLine();

                if (answerText == "60")
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            } while (answerText != "60");
        }
    }
}
