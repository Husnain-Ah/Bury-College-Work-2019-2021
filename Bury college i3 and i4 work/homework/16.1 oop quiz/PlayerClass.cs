using System;
using System.Collections.Generic;
using System.Text;

namespace _16._1_oop_quiz
{
    class PlayerClass
    {
        private string Name { get; }
        private int NumOfPlays { get; set; }
        private decimal AverageScore { get; set; }

        public PlayerClass(string name, int numOfPlays = 0, decimal averageScore = 0)
        {
            Name = name;
            NumOfPlays = numOfPlays;
            AverageScore = averageScore;
        }

        public string getPlayerDetails()
        {
            return (Name + " Has played " + NumOfPlays.ToString() + " and has an average of " + AverageScore);
        }

        public void completedAGame(int score)
        {
            if (NumOfPlays == 0)
            {
                this.NumOfPlays = 1;
                this.AverageScore = 1;
            }
            else 
            {
                this.NumOfPlays++;
                this.AverageScore = (this.AverageScore + score) / 2;
            }
        }
    }
}
