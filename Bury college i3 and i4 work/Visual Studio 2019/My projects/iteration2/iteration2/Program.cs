using System;

namespace iteration2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            string Continue ;
            repeat
                Continue = "yes";

            Console.WriteLine("What is your username");
            userinputusername = Console.ReadLine();
            Console.WriteLine("Please enter password");
            userinputpassword = Console.ReadLine();

            while (password != userinputpassword) ;
            Console.WriteLine("Please enter the correct password");
            userinput = Console.ReadLine();
            endfor

            Console.WriteLine("Please enter a new password");
            userinputpassword = Console.ReadLine();
            Console.WriteLine("continue? yes/no ");
            Continue = Console.ReadLine();
            until(Continue == "no");



        }
    }
}
