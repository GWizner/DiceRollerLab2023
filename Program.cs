using DiceRollerLab2023;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab2023
{
    public class Program
    {
        public static void Main(string[] args)
        {

            bool keepAsk = true;
            int numRolls = 0;
                        
            Console.WriteLine("Hello, User, you will be rolling two dice.");
            while (keepAsk)
            {

                int createdDice = Validator.getUserDice();
                int dieA = RandomDice.buildDie(createdDice);
                int dieB = RandomDice.buildDie(createdDice);
                int randDice = dieA + dieB;

                string sixSides = SixShooters.DiceCalled(dieA, dieB);
                string winLose = SixShooters.Craps(dieA, dieB);
                numRolls++;


                Console.WriteLine($"Roll " + numRolls + ":\n" + randDice + "(" + dieA + " and " + dieB + ")");
                Console.WriteLine();

                if (createdDice == 6)
                {
                    Console.WriteLine(sixSides);
                    Console.WriteLine(winLose);
                }

                keepAsk = Validator.getContinue();
            }
            Console.WriteLine("Goodbye.");
            Console.ReadLine();
        }
    }
}