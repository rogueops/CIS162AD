//Number Guessing Game Assignment
//Created By: Nicore
//Created On: 10/04/2020
//Class: CIS162AD
//Note: This program will first generate a random number, then ask the user
//      for their guess in the form of a whole number. If the number is too high
//      or low the user will get a message and when the user gets the correct number
//      print a success message. The user's input will be verified that it is a whole number
//      and if it was not a whole number then print an error message.

using System;

namespace RandomNumber
{
    internal class NumberGuess
    {
        static void Main(string[] args)
        {
            //added given rand num code
            Random random = new Random(DateTime.UtcNow.Millisecond);

            //init random number variable
            int number = random.Next(1, 101);

            //init number of guesses to start with
            int i = 0;

            //instead of just writing to console, trying something new
            string version = "Welcome To The Guess an Random Number Game v1.6";
            string space = "-------------------------------------------------";
            string welcome = "The number is whole and between 1 and 100";
            string gusser = "Please enter a number: ";
            string quit = "\nPress [ENTER] to exit...";
            string error = "Whoops! Please enter a whole number between 1 and 100.";
            string cheer = "\n       Whoot! Whoot!";
            string taunt = "Oh! So close!";
            string correct = "You guessed the right number!";


            //intro text block
            Console.WriteLine(space);
            Console.WriteLine(version);
            Console.WriteLine(welcome);
            Console.WriteLine(space);

            while (true)
            {
                //init guess variable and set default
                int guess = 0;

                //ask for user's number to guess
                Console.Write(gusser);

                //first check if input was a number in outside loop
                if (int.TryParse(Console.ReadLine(), out guess))
                {

                    //if the guess was the same as the random number then do
                    if (guess == number)
                    {
                        //success! user gussed the random number
                        //print message and how many tries it took
                        Console.WriteLine(cheer);
                        Console.WriteLine(correct);
                        Console.WriteLine("It took {0} tries to guess the number!",i);
                        Console.WriteLine(space);
                        Console.WriteLine(quit);
                        Console.ReadLine();
                        break;
                    }
                    //else the guess was not equal to the random number
                    else
                    {
                        //print higher or lower than hint
                        Console.WriteLine(taunt);
                        Console.WriteLine("The number you guessed was too {0}.", (guess > number) ? "high" : "low");
                        i++;
                    }
                }
                //else input was not a number
                else
                {
                    Console.WriteLine(error);
                }
            }

        }
    }
}
