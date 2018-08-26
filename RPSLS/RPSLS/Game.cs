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
        public string numberOfPlayers;
        public List<string> gestureList;
        public string typeOfGame;
        public bool player2Winner;
        public bool player1Winner;

        //constructor 
        public Game()
        {
            gestureList = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        }
        //methods

        public void GetPlayers()
        {
            Console.WriteLine("Type 1 for a one player game.  Type 2 for a two player game");
            typeOfGame = Console.ReadLine();

            if (numberOfPlayers == "1")
            {
                player1 = new Player();
                player2 = new Computer();
            }
            else {
                player1 = new Player();
                player2 = new Player();
            }
        }

        public void GetPlayerChoices()
        {
            Console.WriteLine("Player 1: What weaopon will you throw?");
            player1.weaponChoice = Console.ReadLine();

            Console.WriteLine("Player 2: What weaopn will you throw?");
            player2.weaponChoice = Console.ReadLine();
        }

        public void NoCountTie()
        {
            if (player1.weaponChoice == player2.weaponChoice)
            {
                Console.WriteLine("It's a tie!");
            }
        }
        public bool Compare()
        {
            if (player1.weaponChoice == "Rock")
                if (player1.weaponChoice == "paper" || player2.weaponChoice == "spock")
                {
                    player2Winner = true;
                    Console.WriteLine("Player 2 wins!");
                }
                else if (player2.weaponChoice == "scissors" || player1.weaponChoice == "lizard")
                {
                    player1Winner = true;
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            return player1Winner;
            //new scenario
            if (player1.weaponChoice == "paper")
                if (player2.weaponChoice == "scissors" || player2.weaponChoice == "lizard")
                {
                    player2Winner = true;
                    Console.WriteLine("player 2 wins!");
                }
                else if (player2.weaponChoice == "spock" || player1.weaponChoice == "rock")
                {
                    player1Winner = true;
                    Console.WriteLine("user 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            return  player1Winner;


            //new scenario
            if (player1.weaponChoice == "scissors")
                if (player2.weaponChoice == "rock" || player2.weaponChoice == "spock")
                {
                    player2Winner = true;
                    Console.WriteLine("Player 2 wins!");
                    
                }
                else if (player2.weaponChoice == "paper" || player1.weaponChoice == "lizard")
                {
                    player1Winner = true;
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            return player1Winner;
            //new scenario
            if (player1.weaponChoice == "spock")
                if (player2.weaponChoice == "paper" || player2.weaponChoice == "lizard")
                {
                    player2Winner = true;
                    Console.WriteLine("Player 2 wins!");
                    //add to counter
                }
                else if (player2.weaponChoice == "rock" || player1.weaponChoice == "scissors")
                {
                    player1Winner = true;
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            return player1Winner;
            //new scenario
            if (player1.weaponChoice == "lizard")
                if (player2.weaponChoice == "scissors" || player2.weaponChoice == "rock")
                {
                    player2Winner = true;
                    Console.WriteLine("Player 2 wins!");
                    //add to counter
                }
                else if (player2.weaponChoice == "paper" || player1.weaponChoice == "spock")
                {
                    player1Winner = true;
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            return player1Winner;

        }
        public void RunGame() {
            GetPlayers();
            GetPlayerChoices();
            Compare();
        }

    }
}
    

