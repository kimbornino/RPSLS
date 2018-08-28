using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        //member variables
        public string weaponChoice;
        public int playerScore = 0;
        public string playersName;
        public string tempChoice;

        public Player(string name)
        {
            playersName = name;
        }

        public virtual void MakePlayerChoice()
        {
            Console.WriteLine("What weapon will " + playersName + " throw?");
             weaponChoice = (Console.ReadLine()).ToLower();

            //if choice invalid get new choice
            if (weaponChoice == "rock" || weaponChoice == "paper" || weaponChoice == "scissors" || weaponChoice == "lizard" || weaponChoice == "spock")
            {
                Console.WriteLine("You threw " + weaponChoice);
            }
            else
            {
                Console.WriteLine("Invalid entry.  Please try again");
                MakePlayerChoice();
            }
        }

        public void IncrementScore()
        {
            {
                playerScore = playerScore + 1;
            }
        }

    }
}

    

    

