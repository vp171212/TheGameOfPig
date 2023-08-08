using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfPigDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~Let's Play PIG~~~~~~~~~~~~~~~~");
            Console.WriteLine("See how many turns it takes to get to 20");
            Console.WriteLine("If you roll a 1, you lose all points for the turn");
            Console.WriteLine("If you hold,you save all points for the turn");
            Console.WriteLine("To roll Press:r,To hold Press:h");
            int score = 0;
            int output;
            int turnScore;
            int turn = 0;
            while (score < 20)
            {   turn++;
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Turn" + turn);
                Console.WriteLine("Welcome to the game of Pig");
                output = 0;
                turnScore = 0;
                Console.WriteLine("Please roll");
                string command = Console.ReadLine();
                while (command == "r")
                {
                    if (command == "r")
                    {
                        Random rnd = new Random();
                        output = rnd.Next(1, 7);
                    }
                    Console.WriteLine("You rolled: "+output);
                    if (output == 1)
                    {
                        turnScore = 0;
                        command = "h";
                        break;
                    }
                    else
                        turnScore += output;
                    Console.WriteLine($"Your turn score is {turnScore} and your total score is {score}");
                    Console.WriteLine($"If you hold your Total Score is {turnScore+score}");
                    Console.WriteLine("To roll Press:r,To hold Press:h");
                    command = Console.ReadLine();
                }
                score += turnScore;
                Console.WriteLine("Your Turn Score: " + turnScore);
                Console.WriteLine("Your Total Score: " + score);
               
            }
            Console.WriteLine("*************** Congratulations You Win ****************");
            Console.WriteLine($"You finished in {turn} turn");
        }
    }
}
