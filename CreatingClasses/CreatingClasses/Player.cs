using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    class Player
    {
        private string name;
        private int score;
        private int livesLeft;

        public Player (string name)
        {
            this.name = name;
            this.livesLeft = 10;
            this.score = 100;
                     
        }

        public Player (string name, int StartingLives)
        {
            this.name = name;
            this.livesLeft = StartingLives;
        }

        public string GetName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }

        public void GetPoints (int totalPoints)
        {
            this.score += totalPoints;
        }

        public void Kill()
        {
            if (livesLeft>0)
            {
                this.livesLeft--;
            }
        }

        public int GetLivesLeft()
        {
            return livesLeft;
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                if (score < 0)
                {
                    score = 0;
                }
                
            }
        }       
    }
}
