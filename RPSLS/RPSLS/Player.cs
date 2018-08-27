using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    //added the word "public"
    public class Player
    {
        //member variables
        public string weaponChoice;
        public int playerScore = 0;
        public string playersName;

        //gesture method
        //public string userName;
        // public List <weaponList()> 

        //methods
        //player1.score...
        public Player(string name)
        {
            playersName = name;
        }

        public virtual void MakePlayerChoice()
        {
            Console.WriteLine("What weapon will " + playersName + " throw?");
            weaponChoice = Console.ReadLine();

            // Console.WriteLine("Player 2: What weapon will you throw?");
            //player2.weaponChoice = Console.ReadLine();
        }

        public void IncrementScore()
        {
            playerScore = playerScore + 1;

        }

    }
}

    

    

