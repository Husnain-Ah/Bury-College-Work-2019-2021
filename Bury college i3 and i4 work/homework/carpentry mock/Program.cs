using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace carpentry_mock
{

    class Program
    {

        static void Main(string[] args)
        {
            double BasicCarpet = 1.50;
            double StandardCarpet = 3.00;
            double LuxuryCarpet = 5.00;
            double FittingCost = 49.99;
            double Underlay = 0.50;
            string FinalQuote = "";


            Console.WriteLine("Enter client name :");
            string ClientName = Console.ReadLine();

            Console.WriteLine("What is the date? ");
            string date = Console.ReadLine();

            Console.WriteLine("How many rooms will you need carpet for? ");
            int RoomNumber = int.Parse(Console.ReadLine());
            
            
            List<double> list = new List<double>(); 

            for (int i = 0; i < RoomNumber; i++)

            {
                Console.WriteLine("Enter room name : ");
                string RoomName = Console.ReadLine();

                Console.WriteLine("Enter length of the room in metres : ");
                double RoomLength = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter width of the room in metres : ");
                double RoomWidth = double.Parse(Console.ReadLine());

                double RoomDimensions = (RoomLength * RoomWidth);


                Console.WriteLine("Which quality of carpet would you like? Basic, Standard or Luxury : ");
                string Carpet = Console.ReadLine().ToLower();

                double RoomCost = 0;

                if (Carpet == "basic")  
                {
                    RoomCost = (RoomDimensions * BasicCarpet);
                };

                if (Carpet == "standard")
                {
                    RoomCost = (RoomDimensions * StandardCarpet);
                };

                if (Carpet == "luxury")
                {  
                    RoomCost = (RoomDimensions * LuxuryCarpet);
                };


                Console.WriteLine("Would you like to use underlay? Y/N : ");
                string NeedUnderlay = Console.ReadLine().ToUpper();
                double UnderlayCost = (Underlay * RoomDimensions);
                string Quote;
                double FinalCost;

                if (NeedUnderlay == "N")
                {
                    double TotalCost = (RoomCost + FittingCost);
                    double VAT = (TotalCost / 5);
                    TotalCost = (RoomCost + FittingCost + VAT);
                    list.Add(TotalCost);
                    FinalCost = list.Sum();
                    FinalQuote = ("The total cost of all your rooms combined is £" + FinalCost);
                    Quote = ("Hello " + ClientName + "The date is " + date +" The total cost of the room " + RoomName + " is £" + TotalCost + " , The cost of the carpet was £" + RoomCost + ", Added 20% VAT and £49.99 for the fitting. ");
                    Console.WriteLine(Quote);

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Husnain\Documents\homework\carpentry mock\QuoteTextFile.txt", true))

                    {
                        file.WriteLine(Quote);
                    }
                   
                };

                if (NeedUnderlay == "Y")
                {
                    double TotalCost = (RoomCost + FittingCost + UnderlayCost);
                    double VAT = (TotalCost / 5);
                    TotalCost = (RoomCost + FittingCost + UnderlayCost + VAT);
                    list.Add(TotalCost);
                    FinalCost = list.Sum();
                    FinalQuote = ("The total cost of all your rooms combined is £" + FinalCost);
                    Quote = ("Hello " + ClientName + " The date is " + date +" The total cost of the room " + RoomName + " is £" + TotalCost + " , The cost of the carpet was £" + RoomCost + ", Added 20% VAT as well as £" + UnderlayCost + " for the underlay and £49.99 for the fitting. ");
                    Console.WriteLine(Quote);

                    

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Husnain\Documents\homework\carpentry mock\QuoteTextFile.txt", true))

                    {
                        file.WriteLine(Quote);
                    }
                };


                


            }

            
            Console.WriteLine(FinalQuote);


            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Husnain\Documents\homework\carpentry mock\QuoteTextFile.txt", true))

            {
                file.WriteLine(FinalQuote);
            }















        }
    }
}
