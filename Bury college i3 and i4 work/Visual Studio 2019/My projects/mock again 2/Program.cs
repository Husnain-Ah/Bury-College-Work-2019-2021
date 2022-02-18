using System;

namespace mock_again_2
{
    class Program

    {

        static void Main(string[] args)





        {

            double USD = 1.40;

            double EUR = 1.14;

            double BRL = 4.77;

            double JPY = 151.05;

            double TRY = 5.68;

            double Discount = 0.95;



            double ConvertMoney = 0;

            string Staff;

            double TotalCost;

            string ChosenCurrency = "";

            double ConvertedMoney = 0;

            double Fee = 0;

            bool RepeatCurrency = true;

            bool RepeatStaff = true;



            //Ask how much money will be converted 

            do

            {

                Console.WriteLine("Enter the amount in pounds sterling (GBP) that you wish to convert  : ");

                ConvertMoney = double.Parse(Console.ReadLine());



            } while (0 > (ConvertMoney) || (ConvertMoney) > 2500);



            //calculate the transaction fee 



            if (ConvertMoney < 300)

            {

                Fee = 0.35 * ConvertMoney;

            }



            if (300 < ConvertMoney && ConvertMoney < 750)

            {

                Fee = 0.3 * ConvertMoney;

            }



            if (750 < ConvertMoney && ConvertMoney < 1000)

            {

                Fee = 0.25 * ConvertMoney;

            }



            if (1000 < ConvertMoney && ConvertMoney < 2000)

            {

                Fee = 0.2 * ConvertMoney;

            }



            if (2000 < ConvertMoney)

            {

                Fee = 0.15 * ConvertMoney;

            }





            //convert the money to the new currency 



            do

            {

                Console.WriteLine("Which currency would you like to convert your GBP to? : "); ;

                ChosenCurrency = Console.ReadLine();

                if (ChosenCurrency == "USD" || ChosenCurrency == "EUR" || ChosenCurrency == "BRL" || ChosenCurrency == "JPY" || ChosenCurrency == "TRY")
                {
                    RepeatCurrency = false;
                }


            } while (RepeatCurrency == true);





            //calculate conversion 



            if (ChosenCurrency == "USD")

            {

                ConvertedMoney = (ConvertMoney * USD);

            }



            if (ChosenCurrency == "EUR")

            {

                ConvertedMoney = (ConvertMoney * EUR);

            }



            if (ChosenCurrency == "BRL")

            {

                ConvertedMoney = (ConvertMoney * BRL);

            }



            if (ChosenCurrency == "JPY")

            {

                ConvertedMoney = (ConvertMoney * JPY);

            }



            if (ChosenCurrency == "TRY")

            {

                ConvertedMoney = (ConvertMoney * TRY);

            }





            //ask if user is a member is a staff, if they are they will recieve a 5% discount 

            do

            {

                Console.WriteLine("are you a member of staff? Yes/No : ");

                Staff = Console.ReadLine();

                if (Staff == "Yes" || Staff == "No")
                {
                    RepeatStaff = false;
                }



            } while (RepeatStaff == true);



            //calculate the total cost and output all costs in a quote 

            if (Staff == "No")

            {

                TotalCost = (ConvertMoney + Fee);

                Console.WriteLine("You receive " + ConvertedMoney + " " + ChosenCurrency + ", The transaction fee is " + Fee + ", The total cost is " + TotalCost + ".");

            }



            if (Staff == "Yes")

            {

                TotalCost = (ConvertMoney + Fee) * Discount;

                Console.WriteLine("You receive " + ConvertedMoney + " " + ChosenCurrency + ", The transaction fee is " + Fee + ", The discount amount is 5%, The total cost is " + TotalCost + ".");

            }



        }

    }

}

