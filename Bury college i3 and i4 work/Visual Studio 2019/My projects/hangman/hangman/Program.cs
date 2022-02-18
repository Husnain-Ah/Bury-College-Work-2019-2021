using System;

namespace hangman
{
    class Program
    {
        public static string[] wordBank = new string[5];
        public static string currentWord = "";
        static void SetWordBank()
        {
            wordBank[0] = "STRING";
            wordBank[1] = "INTEGER";
            wordBank[2] = "BOOLEAN";
            wordBank[3] = "REAL";
            wordBank[4] = "STRING";
        }

        static string SelectAWord()
        {
            Random random = new Random();
            return wordBank[random.Next(0, 4)];
        }

        static void DisplayWord(int listSize, char[] outputList)
        {
            for(int i = 0; i < listSize; i++)
            {
                Console.Write(outputList[i] + " ");
            }
            Console.WriteLine();
        }
        static void GuessLetter(ref int letterCount, ref char[] GuessChars, ref char[] WordChars)
        {
            Console.WriteLine("Enter a letter");
            char letter = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < WordChars.Length; i++)
            {
                if (letter == WordChars[i])
                {
                    GuessChars[i] = WordChars[i];
                    letterCount++;
                }
            }
        }

        static void Main (string[] args)
        {

            int letterCount = 0;
            bool gameWon = false;

            SetWordBank();
            currentWord = SelectAWord();
            letterCount = currentWord.Length;
            char[] wordChars = new char[letterCount];
            wordChars = currentWord.ToCharArray();
            char[] guessChars = new char[letterCount];

            for (int i = 0; i < wordChars.Length; i++)
            {
                guessChars[i] = Convert.ToChar("_");
            }

            gameWon = false;
            Console.WriteLine("Welcome to Guess the word");
            Console.WriteLine("a word is chosen at random");
            Console.WriteLine(" ");

            letterCount = 0;

            do
            {
                DisplayWord(wordChars.Length, guessChars);
                GuessLetter(ref letterCount, ref guessChars, ref wordChars);

                if (letterCount == wordChars.Length)
                {
                    gameWon = true;
                    Console.WriteLine("well done you have guessed correctly");
                }
            } while(gameWon == false);
            Console.ReadLine();
        }
    }

}
