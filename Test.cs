using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenProject
{
    /// <summary>
    /// The Test class
    /// </summary>
    internal class Test
    {
        private Game game;
        private List<String> errors;
        private Helper helper;
        /// <summary>
        /// The Test-class constructor
        /// </summary>
        public Test()
        {
            // Now we're going to test the constructors
            // Create a new game with the default constructor
            Game game = new Game();
            helper = new Helper(game);
            errors = new List<String>();

            Console.Clear();
            Console.WriteLine("Starting test...");

            // Check if gameNumber is 0
            if (game.GetGameNumber() != 0)
            {
                errors.Add($"ERROR: gameNumber is {game.GetGameNumber()}. Exptected: 0. (#1)");
            }

            // Check if gameSpeed = 10f
            if (game.GetGameSpeed() != 10f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 10f. (#2)");
            }

            // Check if levelSummary is empty
            if (!String.IsNullOrEmpty(game.GetLevelSummary()))
            {
                errors.Add($"ERROR: levelSummary is {game.GetLevelSummary()}. Exptected: empty. (#3)");
            }

            // Check if playerName is empty
            if (!String.IsNullOrEmpty(game.GetPlayerName()))
            {
                errors.Add($"ERROR: playerName is {game.GetPlayerName()}. Exptected: empty. (#4)");
            }

            // Check if numberOfPlayers is 0
            if (game.GetNumberOfPlayers() != 0)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 0. (#5)");
            }

            // Set gameSpeed to 1
            game.ResetGameSpeed();

            // Check if gameSpeed is 1
            if (game.GetGameSpeed() != 1f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 1f. (#6)");
            }

            // Increase gameSpeed (gameSpeed should now be 1.1f;
            game.IncreaseGameSpeed();

            // Check if gameSpeed is 1.1f
            if (game.GetGameSpeed() != 1.1f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 1.1f. (#7)");
            }

            // Decrease gameSpeed (gameSpeed should now be 1.1f - (0.1f * 1.1f) = 0.979f
            game.DecreaseGameSpeed();

            // Check if gameSpeed is 1f
            if (game.GetGameSpeed() != 0.99f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 0.99f. (#8)");
            }

            // Set gameNumber to 4
            game.SetGameNumber(4);

            // Check if gameNumber is 4
            if (game.GetGameNumber() != 4)
            {
                errors.Add($"ERROR: gameNumber is {game.GetGameNumber()}. Exptected: 4. (#9)");
            }

            // Set levelSummary to "Level 1"
            game.SetLevelSummary("Level 1");

            // Check if levelSummary is "Level 1"
            if (game.GetLevelSummary() != "Level 1")
            {
                errors.Add($"ERROR: levelSummary is {game.GetLevelSummary()}. Exptected: Level 1. (#10)");
            }

            // Set playerName to "Player 1"
            game.SetPlayerName("Player 1");

            // Check if playerName is "Player 1"
            if (game.GetPlayerName() != "Player 1")
            {
                errors.Add($"ERROR: playerName is {game.GetPlayerName()}. Exptected: Player 1. (#11)");
            }

            // Set numberOfPlayers to 3
            game.SetNumberOfPlayers(3);

            // Check if numberOfPlayers is 3
            if (game.GetNumberOfPlayers() != 3)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 3. (#12)");
            }

            // Now we're going to test the second constructor
            // Create a new game with the second constructor
            game = new Game(2f, 1, "Level 2", "Player 2", 4);
            helper = new Helper(game);


            // Check if gameNumber is 1
            if (game.GetGameNumber() != 1)
            {
                errors.Add($"ERROR: gameNumber is {game.GetGameNumber()}. Exptected: 1. (#13)");
            }

            // Check if gameSpeed = 2f
            if (game.GetGameSpeed() != 2f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 2f. (#14)");
            }

            // Check if levelSummary is "Level 2"
            if (game.GetLevelSummary() != "Level 2")
            {
                errors.Add($"ERROR: levelSummary is {game.GetLevelSummary()}. Exptected: Level 2. (#15)");
            }

            // Check if playerName is "Player 2"
            if (game.GetPlayerName() != "Player 2")
            {
                errors.Add($"ERROR: playerName is {game.GetPlayerName()}. Exptected: Player 2. (#16)");
            }

            // Check if numberOfPlayers is 4
            if (game.GetNumberOfPlayers() != 4)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 4. (#17)");
            }

            // Now we're going to test the third constructor
            // Create a new game with the third constructor
            // public Game(int gameNumber, string levelSummary, string playerName)

            game = new Game(5, "Level 5", "Player 5");
            helper = new Helper(game);


            // Check if gameNumber is 5
            if (game.GetGameNumber() != 5)
            {
                errors.Add($"ERROR: gameNumber is {game.GetGameNumber()}. Exptected: 5. (#18)");
            }

            // Check if levelSummary is "Level 5"
            if (game.GetLevelSummary() != "Level 5")
            {
                errors.Add($"ERROR: levelSummary is {game.GetLevelSummary()}. Exptected: Level 5. (#19)");
            }

            // Check if playerName is "Player 5"
            if (game.GetPlayerName() != "Player 5")
            {
                errors.Add($"ERROR: playerName is {game.GetPlayerName()}. Exptected: Player 5. (#20)");
            }

            // Number of players should be 6. Test:
            if (game.GetNumberOfPlayers() != 6)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 6. (#21)");
            }

            // gameSpeed should be 3f. Test:
            if (game.GetGameSpeed() != 3f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 3f. (#22)");
            }

            // Set gameSpeed to 1;
            game.ResetGameSpeed();

            // Decrease gameSpeed with 2;
            game.DecreaseGameSpeed(2);

            // gameSpeed should be 0. Test:
            if (game.GetGameSpeed() != 0f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 0f. (#23)");
            }

            // Kill one player.
            game.KillPlayer();

            // numberOfPlayers should now be 5.Test:
            if (game.GetNumberOfPlayers() != 5)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 5. (#24)");
            }

            // Kill 6 players
            game.KillPlayer(6);

            // numberOfPlayers should now be 0. Test:
            if (game.GetNumberOfPlayers() != 0)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 0. (#25)");
            }

            // Set gameSpeed to 1
            game.ResetGameSpeed();

            // Increase gameSpeed with 2
            game.IncreaseGameSpeed(2);

            // gameSpeed should now be 3. Test:
            if (game.GetGameSpeed() != 3f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 3f. (#26)");
            }

            // Decrease gameSpeed with 1.5f
            game.DecreaseGameSpeed(1.5f);

            // gameSpeed should now be 1.5f. Test:
            if (game.GetGameSpeed() != 1.5f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 1.5f. (#27)");
            }

            // Resurrect 3 players
            game.ResurrectPlayer(3);

            // numberOfPlayers should now be 3. Test:
            if (game.GetNumberOfPlayers() != 3)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 3. (#28)");
            }

            // Score should be 0, test:
            if (game.GetScore() != 0)
            {
                errors.Add($"ERROR: score is {game.GetScore()}. Exptected: 0. (#29)");
            }

            // Increase score with 1
            game.IncreaseScore();

            // Score should now be 1, test:
            if (game.GetScore() != 1)
            {
                errors.Add($"ERROR: score is {game.GetScore()}. Exptected: 1. (#30)");
            }

            // Increase score with 2
            game.IncreaseScore(2);

            // Score should now be 3, test:
            if (game.GetScore() != 3)
            {
                errors.Add($"ERROR: score is {game.GetScore()}. Exptected: 3. (#31)");
            }

            // Add five players to game, using helper
            helper.AddFivePlayers();

            // Check if numberOfPlayers is 8
            if (game.GetNumberOfPlayers() != 8)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 8. (#32)");
            }

            // Kill 2 players, using helper
            helper.KillTwoPlayers();

            // Check if numberOfPlayers is 6
            if (game.GetNumberOfPlayers() != 6)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 6. (#33)");
            }

            // Increase score with 5, using helper
            helper.SetScoreToFive();

            // Check if score is 5
            if (game.GetScore() != 5)
            {
                errors.Add($"ERROR: score is {game.GetScore()}. Exptected: 5. (#34)");
            }

            // start new game, using helper
            game = helper.NewGame();
            helper = new Helper(game);

            // GameSpeed should be 10f, test:
            if (game.GetGameSpeed() != 10f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 10f. (#35)");
            }

            // numberOfPlayers should be 0, test:
            if (game.GetNumberOfPlayers() != 0)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 0. (#36)");
            }

            // Pause game using helper
            helper.PauseGame();

            // GameSpeed should be 0f, test:
            if (game.GetGameSpeed() != 0f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 0f. (#37)");
            }

            // Resume game using helper
            helper.ResumeGame();

            // GameSpeed should be 1f, test:
            if (game.GetGameSpeed() != 1f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 1f. (#38)");
            }

            // End game using helper
            helper.EndGame();

            // number of players should be 1, test:
            if (game.GetNumberOfPlayers() != 3)
            {
                errors.Add($"ERROR: numberOfPlayers is {game.GetNumberOfPlayers()}. Exptected: 3. (#39)");
            }

            // Score should be 0, test:
            if (game.GetScore() != 42)
            {
                errors.Add($"ERROR: score is {game.GetScore()}. Exptected: 42. (#40)");
            }

            // gameSpeed should be 0, test:
            if (game.GetGameSpeed() != 0f)
            {
                errors.Add($"ERROR: gameSpeed is {game.GetGameSpeed()}. Exptected: 0f. (#41)");
            }

            // Start new game using helper
            game = helper.NewGame();
            helper = new Helper(game);

            // Set player's name to Norbert, using helper
            helper.SetPlayerNameToNorbert();

            // Check if player's name is Norbert
            if (game.GetPlayerName() != "Norbert")
            {
                errors.Add($"ERROR: playerName is {game.GetPlayerName()}. Exptected: Norbert. (#42)");
            }








            Console.WriteLine("Done testing. Get ready for the results...");
            showErrors();
        }

        private void showErrors()
        {
            // If there are any errors
            if (errors.Count > 0)
            {
                Console.WriteLine("There are " + errors.Count + " errors!");
                // Show the errors
                foreach (String error in errors)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                Console.WriteLine("No errors found!");
            }
        }
    }
}
