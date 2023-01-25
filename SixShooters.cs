using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab2023
{
    public class SixShooters
    {
        public static string DiceCalled(int dieA, int dieB)
        {
            
            if (dieA == 1 && dieB == 1)
            {
                string snakeEyes = "Snake Eyes.";
                return snakeEyes;
            }
            else if (dieA == 1 && dieB == 2 || dieA == 2 && dieB == 1)
            {
                string aceyDeucy = "Ace Deuce.";
                return aceyDeucy;
            }
            else if (dieA == 6 && dieB == 6)
            {
                string boxCars = "Box Cars.";
                return boxCars;
            }
            else
            {
                return string.Empty;
            }
        }
        public static string Craps(int dieA, int dieB)
        {
            bool? craps = false;

            if (dieA + dieB == 2)
            {
                craps = true;
            }
            else if (dieA + dieB == 3)
            {
                craps = true;
            }
            else if (dieA + dieB == 12)
            {
                craps = true;
            }
            else if (dieA + dieB == 7)
            {
                craps = false;
            }
            else if (dieA + dieA == 11)
            {
                craps = false;
            }
            else
            {
                craps = null;
            }

            if (craps == false)
            {
                string winner = "You win!";
                return winner;
            }
            else if (craps == true)
            {
                string crapOut = "Craps!";
                return crapOut;
            }
            else
            {
                return string.Empty;
            }

        }

    }
}