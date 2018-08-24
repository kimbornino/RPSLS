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
        public string user1Weapon;
        public string user2Weapon;
        //constructor 
        // needs to take in arguments from player 1 and player 2
        
    //methods
        public void GetUserChoice()
        {
            Console.WriteLine("What weaopon will you throw?");
            string user1Weapon = Console.ReadLine();
        }
        public void NoCountTie()
        {
        if (user1Weapon == user2Weapon)
            {
                Console.WriteLine("It's a tie!");
            }
        }
        public void Compare()
        {

            if (user1Weapon == "Rock")
                if (user2Weapon == "paper" || user2Weapon == "spock")
                {
                    Console.WriteLine("user 2 wins!");
                    //add to counter
                }
                else if (user2Weapon == "scissors" || user1Weapon == "lizard")
                {
                    Console.WriteLine("user 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }

            //new scenario
            if (user1Weapon == "paper")
                if (user2Weapon == "scissors" || user2Weapon == "lizard")
                {
                    Console.WriteLine("user 2 wins!");
                    //add to counter
                }
                else if (user2Weapon == "spock" || user1Weapon == "rock")
                {
                    Console.WriteLine("user 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }

            //new scenario
            if (user1Weapon == "scissors")
                if (user2Weapon == "rock" || user2Weapon == "spock")
                {
                    Console.WriteLine("user 2 wins!");
                    //add to counter
                }
                else if (user2Weapon == "paper" || user1Weapon == "lizard")
                {
                    Console.WriteLine("user 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            //new scenario
            if (user1Weapon == "spock")
                if (user2Weapon == "paper" || user2Weapon == "lizard")
                {
                    Console.WriteLine("user 2 wins!");
                    //add to counter
                }
                else if (user2Weapon == "rock" || user1Weapon == "scissors")
                {
                    Console.WriteLine("user 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }
            //new scenario
            if (user1Weapon == "lizard")
                if (user2Weapon == "scissors" || user2Weapon == "rock")
                {
                    Console.WriteLine("user 2 wins!");
                    //add to counter
                }
                else if (user2Weapon == "paper" || user1Weapon == "spock")
                {
                    Console.WriteLine("user 1 wins!");
                }
                else
                {
                    Console.WriteLine("Entry invalid.  Please try again");
                }

        }
    }
}
    

