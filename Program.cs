using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            bool guessIsCorrect = false;

            Random random = new Random();

            while (playAgain)
            {
                // generate a random number between 0 and 9
                int randomNumber = random.Next(0, 9);
                int tries = 0;     // count of number os attempts made 
                int maxTries = 3; // maximum number of attempts allowed per game
                Console.WriteLine("A random number between 0-9 will be generated");
                Console.WriteLine("=============================================");


                // loop will run until user guesses correctly or runs out of tries.
                while (!guessIsCorrect && tries < maxTries)
                {
                    Console.WriteLine("Enter a number of your choice: ");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    // compare user's guess with random number
                    if (guess < randomNumber)
                    {
                        Console.WriteLine("The number you have guessed is too low.");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("The number you have guessed is too high");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations, you have guessed it correct in " + (tries + 1) + " tries");
                        guessIsCorrect = true;
                    }
                    tries++;

                    // display how many tries are left if the guess was incorrect
                    if (!guessIsCorrect && tries < maxTries)
                    {
                        int triesLeft = maxTries - tries;
                        Console.WriteLine("You have " + triesLeft + " tries left");
                        Console.WriteLine("-----------------------------------------");
                    }
                }
                // display attempts exhausted if the user was not able to guess the no.
                if (!guessIsCorrect)
                {
                    Console.WriteLine("Sorry you could not guess it, attempts exhausted");
                }

                // display if the user wishes to play the game again
                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgainResponse = Console.ReadLine().ToLower();

                if (playAgainResponse != "yes")
                {
                    playAgain = false;
                    Console.WriteLine("Thank you for playing!");
                }
                else
                {
                    // Generate a new random number for the next game
                    randomNumber = random.Next(0, 9);
                    guessIsCorrect = false;
                    tries = 0;
                }
            }
        }
    }
}
