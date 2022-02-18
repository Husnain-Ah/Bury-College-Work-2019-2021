using System;
using System.IO;

namespace file_handling
{
    class Program
    {
        public static string filePath = @"N:\QuizQuestionFile.txt";

        static bool CheckForFile()
        {
            if (File.Exists(filePath))
            {
                return true;
            }
            else
            {
                return false;
            }
            //checks if a file exists
        }

        static void AddAQuestion()
        {
            bool fileExists = CheckForFile();

            if (!fileExists)
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("// Quiz Question File //");
                }
                Console.Clear();
                Console.WriteLine("Question File was not found, creating question file...");
                Console.WriteLine("A Question File has been created");
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Ready to add a question to " + filePath.ToString());
            Console.WriteLine("------------------");

            string questionText = "";
            string answerText = "";
            string topicText = "";
            Console.WriteLine("Enter the question you would like to add");
            questionText = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter the answer to the question");
            answerText = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter the questions topic");
            topicText = Console.ReadLine().ToUpper();

            string textForFile = "";
            textForFile = questionText + topicText + "," + answerText + Environment.NewLine;
            File.AppendAllText(filePath, textForFile);
        } // adds a question

        static void runTheQuiz()
        {
            int questionCounter = 0;
            int score = 0;
            string fileLine;
            string userInput = "";

            StreamReader file = new System.IO.StreamReader(filePath);
            while ((fileLine = file.ReadLine()) != null)
            {
                if (fileLine[0] != '/')
                {
                    questionCounter++;
                    Console.WriteLine("Question " + questionCounter);
                    Console.WriteLine(fileLine.Split(',')[0]);
                    userInput = Console.ReadLine();

                    if (userInput == fileLine.Split(',')[1])
                    {
                        score = score + 1;
                    }
                }
            } // resets the quiz and sets the scores to 0, then starts the quiz

            file.Close();
            Console.WriteLine("There were {0} questions.", questionCounter);
            Console.WriteLine("You correctly answered {0} questions.", score);
            Console.WriteLine("Your percentage of correctly answered questions is "+(score / questionCounter * 100)+"%.");
            Console.ReadLine().ToUpper();
        }

        static void Main(string[] args)
        {
            string FileLocation = "";
            Console.WriteLine("Would you like to change the file location? 'YES' or 'NO'");
            string FileChange = Console.ReadLine().ToUpper();
            if (FileChange == "YES")
            {
                Console.WriteLine("where do you want the file to be stored?");
                FileLocation = Console.ReadLine(); 
                filePath = (FileLocation);
            }
            else if (FileChange == "NO")
            {
                Console.WriteLine("Time to start the quiz");
            }
            Console.WriteLine("Welcome to the quiz program");
            Console.WriteLine("---------------------------");
            char userChoice = 'N';
            bool validInput = false;
            do
            {
                Console.WriteLine("Would you like to [A]dd a question or [T]ake a quiz");
                Console.WriteLine("Enter A or T");
                Console.WriteLine("Enter E to exit"); // asks if you will do the quiz or make the questions for it
                userChoice = Console.ReadLine().ToUpper()[0];
                if (userChoice == 'A')
                {
                    validInput = true;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    AddAQuestion();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The question has been added to file");
                    validInput = false;
                    Console.ForegroundColor = ConsoleColor.White; //sets the colours of the program
                }
                else if (userChoice == 'T')
                {
                    validInput = true;
                    if (CheckForFile())
                    {
                        runTheQuiz();
                    }
                } // runs the quiz 
                else if (userChoice == 'E')
                {
                    validInput = true;
                }
                else
                {
                    validInput = false;
                }
            } while (validInput == false); // exits the quiz
        }
    }
}
