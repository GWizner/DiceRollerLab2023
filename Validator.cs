using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab2023
{
    public class Validator
    {
        public static bool getContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Would you like to roll again? (y/n): ");
                string choice = Console.ReadLine().ToLower().Trim();
                choice = choice.Trim();
                Console.WriteLine();
                if (choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {

                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I do not understand your input. Please try again.");
                    Console.WriteLine();
                }
            }
            return result;
        }
        public static int getUserDice()
        {
            int userDice = 0;

            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("How many sides should each die have?  ");
                        userDice = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Please input a number (between three and one hundred).");
                        Console.WriteLine();
                    }

                }

                if (userDice < 3)
                {
                    Console.WriteLine("A die needs to have at least three sides.");
                    Console.WriteLine();
                }
                else if (userDice > 100)
                {
                    Console.WriteLine("Please choose a number 100 or less.");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
            return userDice;
        }
    }
}