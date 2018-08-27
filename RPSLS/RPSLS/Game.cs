using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables
        public Player player1;
        public Player player2;
        public List<string> gestureList;
        public string typeOfGame;
        public Rules rules;
       

        //constructor 
        public Game()
        {
            gestureList = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            rules = new Rules();
        }
        //methods

        public void GetPlayers()
        {
            Console.WriteLine("Type 1 for a one player game.  Type 2 for a two player game");
            typeOfGame = Console.ReadLine();

            if (typeOfGame == "1")
            {
                player1 = new Player("Player 1");
                player2 = new Computer("Computer");
            }
            else
            {
                player1 = new Player("Player 1");
                player2 = new Player("Player 2");
            }
        }

        public void GetPlayerChoices()
        {
            player1.MakePlayerChoice();
            player2.MakePlayerChoice();
        }

        public void CheckForTie()
        {
            if (player1.weaponChoice == player2.weaponChoice)
            {
                Console.WriteLine("It's a tie!");
                RunRound();
            }
        } 
        public Player Compare()
        {
            Player winner = null;
            if (player1.weaponChoice == "rock")
            {
                if (player2.weaponChoice == "paper" || player2.weaponChoice == "spock")
                {
                    winner = player2;
                    Console.WriteLine("Player 2 wins!");
                }
                else if (player2.weaponChoice == "scissors" || player2.weaponChoice == "lizard")
                {
                    winner = player1;
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");

                }
            }
            //new scenario
            if (player1.weaponChoice == "paper")
            {
                if (player2.weaponChoice == "scissors" || player2.weaponChoice == "lizard")
                {
                    winner = player2;
                    Console.WriteLine("player 2 wins!");
                }
                else if (player2.weaponChoice == "spock" || player2.weaponChoice == "rock")
                {
                    winner = player1;
                    Console.WriteLine("user 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            }

            //new scenario
            if (player1.weaponChoice == "scissors")
            {
                if (player2.weaponChoice == "rock" || player2.weaponChoice == "spock")
                {
                    winner = player2;
                    Console.WriteLine("Player 2 wins!");

                }
                else if (player2.weaponChoice == "paper" || player2.weaponChoice == "lizard")
                {
                    winner = player1;
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            }

            //new scenario
            if (player1.weaponChoice == "spock")
            {
                if (player2.weaponChoice == "paper" || player2.weaponChoice == "lizard")
                {
                    winner = player2;
                    Console.WriteLine("Player 2 wins!");
                    //add to counter
                }
                else if (player2.weaponChoice == "rock" || player2.weaponChoice == "scissors")
                {
                    winner = player2;
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            }
            //new scenario
            if (player1.weaponChoice == "lizard")
            {
                if (player2.weaponChoice == "scissors" || player2.weaponChoice == "rock")
                {
                    winner = player2;
                    Console.WriteLine("Player 2 wins!");
                    //add to counter
                }
                else if (player2.weaponChoice == "paper" || player2.weaponChoice == "spock")
                {
                    winner = player1;
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            }

            return winner;
        }

        public void RunRound()
        {
            GetPlayerChoices();
            CheckForTie();
            Player roundWinner = Compare();
            roundWinner.IncrementScore();

            if (player1.playerScore == 2)
            {
                Console.WriteLine("Player 1 has won two rounds.  Player 1 is the winner of the game");
            }
            if (player2.playerScore == 2)
            {
                Console.WriteLine("Player 2 has won two rounds.  Player 2 is the winner of the game");
            }
            else
            {
                RunRound();
                RunGame();
            }  
        }
        //create functionality for when we need to go back into game without resetting players "RunRound"
        public void RunGame()
        {
            GetPlayers();
            //rules.GetRules();
            RunRound();
        }
    }
}

            

        


    

