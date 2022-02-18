using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeGame16
{
    class PlayerClass
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        private int NumOfLogins { get; set; }
        private decimal Score { get; set; }

        public PlayerClass(string name, string password, int numOfPlays = 1, decimal score = 0)
        {
            UserName = name;
            Password = password;
            NumOfLogins = numOfPlays;
            Score = score;
        }

        public bool checkPassword(string inPassword)
        {
            if(inPassword == Password)
            { return true; }
            else
            { return false; }
        }

        public decimal getScore()
        {
            return Score;
        }

        public void updateScore(int scoreIncrease)
        {
            Score = Score + scoreIncrease;
        }

        public void updateScore(decimal scoreIncrease)
        {
            Score = Score + scoreIncrease;
        }

        public void updateLogins()
        {
            NumOfLogins++;
        }

        public string getPlayerDetails()
        {
            return (UserName + " has logged in " + NumOfLogins.ToString() + " and has a score of " + Score);    
        }
        
    }
}
