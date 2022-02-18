using System;

namespace _16._1_oop_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            char play = 'Y';

            QuestionClass[] questions = new QuestionClass[5];
            createQuestions(ref questions);

            Console.WriteLine("New Player? Please enter your name: ");
            PlayerClass player1 = new PlayerClass(Console.ReadLine());

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(player1.getPlayerDetails());
                Console.ForegroundColor = ConsoleColor.White;

                runTheQuiz(ref player1, questions);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(player1.getPlayerDetails());
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Would you like to play again? [Y/N] ");
                play = Console.ReadLine().ToUpper()[0];
            } while (play == 'Y');

        }
                
        static void createQuestions(ref QuestionClass[] question)
        {
            question[0] = new QuestionClass(1, 1, "What does OOP stand for?", "Object oriented programming", "Oriented Orange pants", "Objects over pink", "Only oriental Plants");
            question[1] = new QuestionClass(2, 1, "Which of the following is used to hide unneccessary details from the user and reduce complexity?", "Abstraction", "Encapsulation", "Inheritance", "Aromatics");
            question[2] = new QuestionClass(3, 1, "Which of the following is used to derive a class form another, form a hierarchy and share a set of attributes and methods between them?", "Inheritance", "Encapsulation", "Abstraction", "Dragging");
            question[3] = new QuestionClass(4, 1, "Which of the following is used to bundle together data with the methods that operate on it?", "Encapsulation", "Inheritance", "Abstraction", "Dragging");
            question[4] = new QuestionClass(5, 1, "Can OOP be used without classes?", "No", "Yes", "Maybe", "Sometimes");

        }

        static void runTheQuiz(ref PlayerClass player, QuestionClass[] question)
        {
            int score = 0;
            int maxScore = 0;
            string userInput = "";

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(question[i].QuestionNum.ToString() + ": " + question[i].Question);
                Console.WriteLine("- A - " + question[i].CorrectAnswer);
                Console.WriteLine("- B - " + question[i].Incorrect1);
                Console.WriteLine("- C - " + question[i].Incorrect2);
                Console.WriteLine("- D - " + question[i].Incorrect3);
                Console.WriteLine("Press A, B, C or D then enter to choose your answer.");
                userInput = Console.ReadLine().ToUpper();
                maxScore = maxScore + question[i].PointsIfCorrect;

                if (userInput[0] == 'A')
                {
                    score = score + question[i].PointsIfCorrect;
                }
            }
            Console.WriteLine("You scored " + score.ToString() + " out of a possible " + maxScore.ToString());
            player.completedAGame(score);

        }
    }
}
