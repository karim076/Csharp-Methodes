using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenProject
{
    internal class Enemy
    {
        private string enemyCharacter;
        private int numberOfLives;
        private float speed;
        public Enemy()
        {
            this.numberOfLives = 3;
            this.enemyCharacter = "@";
        }
        //setters
        public void KillEnemy()
        {
            this.numberOfLives--;
        }

        public void SetSpeed(int speed)
        {
            if (speed > 0)
            {
                this.speed += speed;
            }
        }

        public void EnemyCharacterChoice(string enemyCharacter)
        {
            if (enemyCharacter != "")
            {
                this.enemyCharacter = enemyCharacter;
            }
            else
            {
                string charRepo = "$%#@!*?;:^&";
                Random rando = new Random();
                int ranNum = rando.Next(0, charRepo.Length);

                char randomChar = charRepo[ranNum];
                this.enemyCharacter = Convert.ToString(randomChar);
            }
        }
        //getters
        public float GetEnemySpeed()
        {
            return this.speed;
        }
        public string GetEnemyName()
        {
            return this.enemyCharacter;
        }

    }
}
