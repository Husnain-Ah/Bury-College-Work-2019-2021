using System;

namespace Battleships
{
    class Program
    {
        public static bool[,] shipCoords, shipCoords1, shipCoords2;
        public static System.ConsoleColor[] defaultColour, coordTakenColour, emptyCoordColour;
        public static void SetColourSchemes()
        {
            defaultColour = new System.ConsoleColor[2] 
            {
                ConsoleColor.White, ConsoleColor.Black
            };
            coordTakenColour = new System.ConsoleColor[2]
            {
                ConsoleColor.Black, ConsoleColor.White
            };
            emptyCoordColour = new System.ConsoleColor[2]
            {
                ConsoleColor.White, ConsoleColor.Red
            };
        }
        public static void SetShipCoords()
        {
            shipCoords = shipCoords1 = shipCoords2 = new bool[10, 10]
            {
                {false, false, false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false, false, false}
            };
        }
        public static bool[,] ChooseShipCoords()
        {
            Console.WriteLine("Enter the x and y coordinates of where you want to place the ship");
            Console.Write("x: ");
            int xCoordInput = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int yCoordInput = int.Parse(Console.ReadLine());
            shipCoords[yCoordInput - 1, xCoordInput - 1] = true;
            return shipCoords;
        }
        public static void Colour(System.ConsoleColor[] colour)
        {
            Console.BackgroundColor = colour[1];
            Console.ForegroundColor = colour[0];
        }
        public static void DisplayShips(bool[,] shipCoords)
        {
            Console.WriteLine("  1 2 3 4 5 6 7 8 9 10");
            for (int i = 0; i < 10; i++)
            {
                Colour(defaultColour);
                if (i + 1 == 10)
                {
                    Console.Write("{0}", i + 1);
                }
                else
                {
                    Console.Write("{0} ", i + 1);
                }
                for (int j = 0; j < 10; j++)
                {
                    if (shipCoords[i, j] == true)
                    {
                        Colour(coordTakenColour);
                    }
                    else
                    {
                        Colour(emptyCoordColour);
                    }
                    Console.Write("[]");
                }
                Console.WriteLine();
            }
            Colour(defaultColour);
        }
        static void Main(string[] arg)
        {
            SetColourSchemes();
            SetShipCoords();
            shipCoords1 = ChooseShipCoords();
            Console.WriteLine();
            DisplayShips(shipCoords1);
        }
    }
}
