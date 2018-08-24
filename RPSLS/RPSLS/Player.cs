using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //member variables
        public string user1Weapon;
        public string user2Weapon;
       // public List <weaponList()> 
        //methods
        public void GetUserChoice()
        {
            Console.WriteLine("What weaopon will you throw?");
            string user1Weapon = Console.ReadLine();
        }
        public void Compare()
        {
         
        if (user1Weapon == "Rock")
                if (user2Weapon == "paper")
                {
                    Console.WriteLine("User 2 wins!");
                }
               if (user2Weapon == "scissors")
                 {
                Console.WriteLine("user 1 wins!");
                 }
               if (user2Weapon == "lizard")
                 {

                Console.WriteLine("User 1 wins!");
                }
               if (user2Weapon == "spock")
                {
                Console.WriteLine("User 2 wins!");
            }
            //new scenario
            if (user1Weapon == "paper")
            {
                if (user2Weapon == "rock")
                {
                    Console.WriteLine("User 1 wins!");
                }
                if (user2Weapon == "scissors")
                {
                    Console.WriteLine("user 2 wins!");
                }
                if (user2Weapon == "lizard")
                {
                    Console.WriteLine("User 2 wins!");
                }
                if (user2Weapon == "spock")
                {
                    Console.WriteLine("User 1 wins!");
                }
            }
            //new scenario
            if (user1Weapon == "scissors")
            {
                if (user2Weapon == "rock")
                {
                    Console.WriteLine("User 2 wins!");
                }
                if (user2Weapon == "paper")
                {
                    Console.WriteLine("user 1 wins!");
                }
                if (user2Weapon == "lizard")
                {
                   // Console.WriteLine("User 1 wins!");
                }
                if (user2Weapon == "spock")
                {
                    //Console.WriteLine("User 2 wins!");
                }
            }

        }
    }

    }
}
