using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenProject
{
    internal class Game
    {
        private int gameNumber;
        private float gameSpeed;
        private string levelSummary;
        private string playerName;
        private int numberOfPlayers;
        private int score;

        //constructor
        public Game()
        {
            this.gameSpeed = 10f;
        }
        public Game(float gameSpeed, int gameNumber, string levelSummary, string playerName, int numberOfPlayers)
        {

            this.gameSpeed = gameSpeed;
            this.gameNumber = gameNumber;
            this.levelSummary = levelSummary;
            this.playerName = playerName;
            this.numberOfPlayers = numberOfPlayers;
        }
        public Game(int gameNumber, string levelSummary, string playerName)
        {

            this.gameSpeed = 3;
            this.gameNumber = gameNumber;
            this.levelSummary = levelSummary;
            this.playerName = playerName;
            this.numberOfPlayers = 6;
        }
        // overloaded methods
        public void IncreaseGameSpeed(float gameSpeed)
        {
            this.gameSpeed += gameSpeed;
            if(this.gameSpeed <= 0)
            {
                this.gameSpeed = 0;
            }
        }
        public void DecreaseGameSpeed(float gameSpeed)
        {
            this.gameSpeed -= gameSpeed;
            if (this.gameSpeed <= 0)
            {
                this.gameSpeed = 0;
            }
        }

        public void KillPlayer(int death)
        {
            if(this.numberOfPlayers > 0)
            {
                this.numberOfPlayers -= numberOfPlayers;
            }
        }

        public void ResurrectPlayer(int extraLife)
        {
            numberOfPlayers += extraLife;
        }

        public void IncreaseScore(int score)
        {
            this.score += score;        }

        public void SetLevelSummary(string levelSummary)
        {
            this.levelSummary += levelSummary;
        }
        // wat in number komt wordt gameNumber
        public void SetGameNumber(int gameNumber)
        {
            this.gameNumber = gameNumber;
        }
        // geeft het nummer gameNumber aan GetGameNumber
        public int GetGameNumber()
        {
            return gameNumber;
        }
        public void ResetGameNumber()
        {
            this.gameNumber = 0;
        }
        // reset het gamespeed
        public void ResetGameSpeed()
        {
            gameSpeed = 1;
        }
        public void ResetGameSpeeds()
        {
            this.gameSpeed = 0;
        }
        // geeft gamespeed terug aan int speed
        public float GetGameSpeed()
        {
            return this.gameSpeed;
        }
        // kijk of de game bezig is
        public bool IsRunning()
        {
            if (this.gameSpeed > 0)
            {
                return true;
            }
            return false;
        }
        // Geeft 10% minder speed
        public void DecreaseGameSpeed()
        {
            float newGameSpeed = this.gameSpeed;
            newGameSpeed -= (gameSpeed / 10);
            if (newGameSpeed > 0)
            {
                gameSpeed -= (gameSpeed / 10);
            }
            else
            {
                gameSpeed = 0;
            }
        }
        // Geeft 10% extra speed
        public void IncreaseGameSpeed()
        {
            float newGameSpeed = this.gameSpeed;
            newGameSpeed += (gameSpeed / 10);
            if (newGameSpeed > 0)
            {
                gameSpeed += (gameSpeed / 10f);
            }
            else
            {
                gameSpeed = 0;
            }
        }
        // geeft levelSummary text mee voor einde game
        public void SetLevelSummary()
        {
            levelSummary = "We're in the end game now";
        }
        // geeft getlevelsummary het levelsummary text
        public string GetLevelSummary()
        {
            return levelSummary;
        }
        // geeft playername het aangegeven naam 'name'
        public void SetPlayerName(string name)
        {
            playerName = name;
        }

        // haalt het playernaam op
        public string GetPlayerName()
        {
            return playerName;
        }

        public void SetNumberOfPlayers(int players)
        {
            numberOfPlayers = players;
        }

        public int GetNumberOfPlayers()
        {
            return this.numberOfPlayers;
        }
        // verminderdt numberofplayer met 1
        public void KillPlayer()
        {
            if(this.numberOfPlayers > 0)
            {
                this.numberOfPlayers--;
            }
        }

        public void KillPlayers(int nunberOfPlayers)
        {
            this.numberOfPlayers -= nunberOfPlayers;
        }


        public void ResurrectPlayer()
        {
            this.numberOfPlayers += 1;
        }

        public void IncreaseScore()
        {
            this.score++;
        }

        public void ResetScore()
        {
            this.score = 0;
        }

        public int GetScore()
        {
            return score;
        }

    }
}
