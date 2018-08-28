using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public string ComputerChoice;

        public Computer(string name) : base(name)
        { }
         public override void MakePlayerChoice()
         {
            GetNumber();
            GetComputerChoice();
            Console.WriteLine("The computer picked " + ComputerChoice);
            weaponChoice = ComputerChoice;
         }

        public int GetNumber()
        {
            Random rnd = new Random();
            int ChoiceOfWeapon = rnd.Next(1, 6); // creates a number between 1 and 5
            return ChoiceOfWeapon;
        }
        public void GetComputerChoice()
        {
            Random rnd = new Random();
            int ChoiceOfWeapon = rnd.Next(1,6); // creates a number between 1 and 5

            if (ChoiceOfWeapon == 1)
            {
                ComputerChoice = "rock";
            }
            else if (ChoiceOfWeapon == 2)
            {
                ComputerChoice = "paper";
            }
            else  if (ChoiceOfWeapon == 3)
            {
                ComputerChoice = "scissors";
            }
            else if (ChoiceOfWeapon == 4)
            {
                ComputerChoice = "lizard";
            }
            else if (ChoiceOfWeapon == 5)
            {
                ComputerChoice = "spock";
            }
        }
    }
}
