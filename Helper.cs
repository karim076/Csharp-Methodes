using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenProject
{
    internal class Helper
    {
        private Game game;
   
        public Helper(Game game)
        {
            this.game = game;
        }
        
        public void AddFivePlayers()
        {
            game.ResurrectPlayer(5);
        }

        public void KillTwoPlayers()
        {
            game.KillPlayers(2);
        }

        public void SetScoreToFive()
        {
            //// ???
            game.ResetScore();
            game.IncreaseScore(5);
        }


        public Game NewGame()
        {
            Game game = new Game();
            return new Game();
        }

        public void PauseGame()
        {
            game.ResetGameSpeeds();
        }

        public void ResumeGame()
        {
            game.IncreaseGameSpeed(1);
        }

        public void EndGame()
        {
            game.SetNumberOfPlayers(3);
            game.ResetGameSpeeds();
            game.IncreaseScore(42);
        }

        public void SetPlayerNameToNorbert()
        {
            game.SetPlayerName("Norbert");
        }

        public void SetGameNumberToThree()
        {
            game.ResetGameNumber();
            game.SetGameNumber(3);
        }

        public void SetLevelSummaryToReadyPlayerOne()
        {
            game.SetLevelSummary("Ready Player One");
        }
    }
}
