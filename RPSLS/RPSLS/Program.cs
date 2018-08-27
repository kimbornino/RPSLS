using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Rules RPSLSRules = new Rules();
            Game RPSLS = new Game();

            RPSLS.RunGame();

            Console.ReadKey();

        }
    }
}
