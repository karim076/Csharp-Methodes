using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenProject
{
    internal class Player
    {
        private string name;
        private int score;
        private int life;
        public Player()
        {
            this.name = "Norbert";
            this.life = 7;

            if (this.name == "Bart" || this.name == "Tim" || this.name == "Marc" || this.name == "Wicher")
            {
                this.name = "Norbert";
            }
        }
        //score / Setters
        public void IncreaseScore()
        {
            this.score++;
        }

        public void SetScore(int score)
        {
            if (score > 0)
            {
                this.score += score;
            }
        }
        public int GetScore()
        {
            return this.score;
        }
        public void ResetScore()
        {
            this.score = 0;
        }

        //life
        public void DeathPlayer()
        {
            this.life--;
        }
        public void RevivePlayer()
        {
            this.life++;
        }
        public void Addlife(int life)
        {
            this.life += life;
        }

        // getters
        public int GetLife()
        {
            return this.life;
        }
        
        public int GetScorePlayer() 
        { 
            return this.score; 
        }
        public string GetPlayerName()
        {
            return this.name;
        }
    }
}
