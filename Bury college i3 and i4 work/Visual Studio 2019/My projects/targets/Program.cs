using System;

namespace targets
{
    class Program
    {
        public static char[,] positions = new char[5, 5];
        public static char[,] grid = new char[5, 5];

        static void Main(string[] args)
        {
            bool playerTurn = true;
            string gameOver = "no";

            Console.WriteLine("TARGETS");
            Console.WriteLine("*******");

            playerTurn = true;
            gameOver = "no";

            resetGrid();
            displayGrid();
            setUpEnemies();
            setUpSoldiers();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            do
            {
                displayGrid();
                Console.WriteLine(leftInPosition());

                if (playerTurn)
                {
                    playerAttempt();
                    playerTurn = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    computerAttempt();
                    playerTurn = true;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }



                Console.WriteLine("Pless enter to continue... ");
                Console.ReadKey();
                Console.Clear();
                gameOver = checkForWin();
            } while (gameOver == "no");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Game Over");
            Console.WriteLine("*******");
            Console.WriteLine("The {0} wins", gameOver);
        }

        static void resetGrid()
        {
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    grid[x, y] = '-';
                    positions[x, y] = '-';
                }
            }
        }

        static void setUpEnemies()
        {
            for (int i = 0; i < 2; i++)
            {
                int row = 0;
                int col = 0;
                Random rnd = new Random();
                row = rnd.Next(0, 5);
                col = rnd.Next(0, 5);
                positions[row, col] = 'E';
            }
        }

        static void setUpSoldiers()
        {
            string rawInput = "";
            int inputRow = 0;
            int inputCol = 0;
            bool isInteger = false;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("You are about to enter the coordinates to show where you would like to place soldier {0}", i.ToString());
                do
                {
                    isInteger = false;
                    Console.WriteLine("Please enter the row input number between 0 and 4");
                    rawInput = Console.ReadLine();
                    isInteger = int.TryParse(rawInput, out inputRow);
                } while (isInteger == false);

                do
                {
                    isInteger = false;
                    Console.WriteLine("Please enter the column number between 0 and 4");
                    rawInput = Console.ReadLine();
                    isInteger = int.TryParse(rawInput, out inputCol);
                } while (isInteger == false);

                positions[inputRow, inputCol] = 'S';
            }
        }

        static void displayGrid()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Display the board...");
            Console.WriteLine(" ");
            Console.WriteLine(" 1  2  3  4");
            Console.WriteLine("0 {0} {1} {2} {3} {4}", grid[0, 0], grid[0, 1], grid[0, 2], grid[0, 3], grid[0, 4]);
            Console.WriteLine("1 {0} {1} {2} {3} {4}", grid[1, 0], grid[1, 1], grid[1, 2], grid[1, 3], grid[1, 4]);
            Console.WriteLine("2 {0} {1} {2} {3} {4}", grid[2, 0], grid[2, 1], grid[2, 2], grid[2, 3], grid[2, 4]);
            Console.WriteLine("3 {0} {1} {2} {3} {4}", grid[3, 0], grid[3, 1], grid[3, 2], grid[3, 3], grid[3, 4]);
            Console.WriteLine("4 {0} {1} {2} {3} {4}", grid[4, 0], grid[4, 1], grid[4, 2], grid[4, 3], grid[4, 4]);
        }

        static string leftInPosition()
        {
            int soldiers = 0;
            int enemies = 0;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (positions[x, y] == 'E')
                    {
                        enemies++;
                    }
                    else if (positions[x, y] == 'S')
                    {
                        soldiers++;
                    }
                }                    
            }
            return "Soldiers: " + soldiers.ToString() + "  Enemies: " + enemies.ToString();
        }

        static void computerAttempt()
        {
            int row = 0;
            int col = 0;
            Random rnd = new Random();
            row = rnd.Next(0, 5);
            col = rnd.Next(0, 5);

            if (positions[row, col] == 'S')
            {
                positions[row, col] = '-';
                grid[row, col] = 'S';
                Console.WriteLine("The Computer sucessfully hit your soldier!");
            }
            else if (positions[row, col] == 'E')
            {
                positions[row, col] = '-';
                grid[row, col] = 'E';
                Console.WriteLine("Computer friendly fire! The computer hit one of its own!");
            }
            else
            {
                Console.WriteLine("Computer missed with: {0}:{1}", row, col);
            }

        }

        static void playerAttempt()
        {
            string rawInput = "";
            int inputRow = 0;
            int inputCol = 0;
            bool isInteger = false;

            Console.WriteLine("It's your turn. Choose a coordiante to attack");
            do
            {
                isInteger = false;
                Console.WriteLine("Please enter the row input number between 0 and 4");
                rawInput = Console.ReadLine();
                isInteger = int.TryParse(rawInput, out inputRow);
            } while (isInteger == false);

            do
            {
                isInteger = false;
                Console.WriteLine("Please enter the column number between 0 and 4");
                rawInput = Console.ReadLine();
                isInteger = int.TryParse(rawInput, out inputCol);
            } while (isInteger == false);

            if (positions[inputRow, inputCol] == 'E')
            {
                positions[inputRow, inputCol] = '-';
                grid[inputRow, inputCol] = 'E';
                Console.WriteLine("Successful hit!");
            }
            else if (positions[inputRow, inputCol] == 'S')
            {
                positions[inputRow, inputCol] = '-';
                grid[inputRow, inputCol] = 'S';
                Console.WriteLine("Friendly fire! You hit your own soldier!");
            }
            else
            {
                Console.WriteLine("Miss!!!");
                Console.WriteLine("An X will be shown on the board");
                grid[inputRow, inputCol] = 'X';
            }
        }

        static string checkForWin()
        {
            string status = "no";
            int soldiers = 0;
            int enemies = 0;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (positions[x, y] == 'E')
                    { enemies++; }
                    else if (positions[x, y] == 'S')
                    { soldiers++; }
                }
            }
            if (enemies == 0)
            { status = "player"; }
            else if (soldiers == 0)
            { status = "computer"; }
            else
            { status = "no"; }

            return status;
        }
    }

    


}
