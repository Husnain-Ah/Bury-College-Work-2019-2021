using System;

namespace standardAlgorithms
{
    class Program
    {
        private static int countQuickSort;

        static void ResetTheArrays(ref int[] list, ref string[] list2)
        {
            list[0] = 4;
            list[1] = 3;
            list[2] = 5;
            list[3] = 1;
            list[4] = 6;
            list[5] = 2;
            list[6] = 7;
            list[7] = 9;
            list[8] = 11;
            list[9] = 8;
            list[10] = 10;
            list[11] = 12;
            list[12] = 14;
            list[13] = 13;
            list[14] = 16;
            list[15] = 18;
            list[16] = 15;
            list[17] = 17;
            list[18] = 19;
            list[19] = 21;
            list[20] = 23;
            list[21] = 22;
            list[22] = 20;
            list[23] = 27;
            list[24] = 30;
            list[25] = 24;
            list[26] = 29;
            list[27] = 28;
            list[28] = 26;
            list[29] = 25;


            list2[0] = "Caterpillar";
            list2[1] = "Earwig";
            list2[2] = "Aardvark";
            list2[3] = "Fish";
            list2[4] = "Zebra";
            list2[5] = "Baboon";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The lists are now unsorted");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void DisplayIntegerArray(int[] list)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The current order of the integer array is:");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void DisplayStringArray(string[] list)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The current order of the string array is:");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void BubbleSortForIntegers()
        {

        }
        static void QuickSortForIntegers()
        {

        }
        static void InsertionSortForIntegers()
        {

        }

        static void Main(string[] args)
        {
            int[] array1 = new int[6];
            string[] array2 = new string[6];
            ResetTheArrays(ref array1, ref array2);
            DisplayIntegerArray(array1);
            DisplayStringArray(array2);

            char userInput = ' ';
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Which Standard Algorithm would you like to use?");
                Console.WriteLine("[B]ubble Sort");
                Console.WriteLine("[Q]uick Sort");
                Console.WriteLine("[I]nsertion Sort");
                Console.WriteLine("[L]inear or Serial Search");
                Console.WriteLine("Bi[n]ary Search - list must first be sorted");
                Console.WriteLine("[R]eset the array (unsort the array)");
                Console.WriteLine("E[x]it");
                userInput = Console.ReadLine().ToUpper()[0];

                if (userInput == 'B')
                {
                    BubbleSortForIntegers();
                    Console.WriteLine("Bubble Sort Complete - this is an iteravive algorithm");
                    DisplayIntegerArray(array1);
                }
                else if (userInput == 'Q')
                {
                    countQuickSort = 0;
                    QuickSortForIntegers();
                    Console.WriteLine("Quick Sort Complete - this is a recursive algorithm");
                    Console.WriteLine("Quicksort used {0} partition calls", countQuickSort);
                    DisplayIntegerArray(array1);
                }
                else if (userInput == 'I')
                {
                    InsertionSortForIntegers();
                    DisplayIntegerArray(array1);
                }
                else if (userInput == 'R')
                {
                    ResetTheArrays(ref array1, ref array2);
                }
            } while (userInput != 'X');
        }
    }
}
