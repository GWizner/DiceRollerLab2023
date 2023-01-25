using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab2023
{
    public class RandomDice
    {
        static Random rand = new Random();
        public static int buildDie(int howManySides)
        {
            int randNum = rand.Next(howManySides) + 1;

            return randNum;
        }
    }
}