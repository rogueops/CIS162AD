//Author: Jason Plimpton
//Simple Calculator Application
//Class: CIS162AD
//Created: 09/19/2020
//Version 1.6

using System;

namespace ConsoleCalculator
{
    public class SimpleCalc
    {
        //Fun starts here!
        private static void Main()
        {

            //Init integer method
            int method;

            //Some welcome text about the program
            Console.Write("\n\n");
            Console.Write("Welcome To Jason's Simple Console Calculator v1.6:\n");
            Console.Write("--------------------------------------------------\n");

            //Restart point for new numbers to caclulate
            Input:

            //init first input
            string stringFirstNumber;
            double num1;

            //ask for number and check if valid
            //input check curtosey of Google research
            do {
               Console.WriteLine("\nPlease enter a number:");
               stringFirstNumber = Console.ReadLine();
               }
            while (!double.TryParse(stringFirstNumber, out num1));

            //init second input
            string stringSecondNumber;
            double num2;

            //ask for another number and check if valid
            do {
                Console.WriteLine("Please enter a second number:");
                stringSecondNumber = Console.ReadLine();
               }
            while (!double.TryParse(stringSecondNumber, out num2));

            //Start point if invalid menu option entered
            Menu:

            //Display a menu with operations available
            Console.Write("\nHere are the calculator operations: \n");
            Console.Write("1: Addition.\n2: Substraction.\n3: Multiplication.\n4: Division.\n5: Enter Different Numbers.\n6: Quit Calculator.\n");
            Console.Write("\nWhat would you like to do? ");
            method = Convert.ToInt32(Console.ReadLine());

            //Little research to use switch for menu options instead of if statements
            //Also learned a new way to write vars without the $
            switch (method) {

                case 1:
                    Console.Write("\nAddition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    Console.Write("\nPress enter to close calculator....");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Write("\nSubstraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                    Console.Write("\nPress enter to close calculator....");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Write("\nMultiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                    Console.Write("\nPress enter to close calculator....");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.Write("\nDivision of {0}  and {1} is: {2}\n", num1, num2, num1 / num2);
                    Console.Write("\nPress enter to close calculator....");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.Write("\nYou have select to enter new numbers to calculate!\n");
                    Console.Write("\nPress enter to enter new numbers....");
                    Console.ReadLine();
                    goto Input;

                case 6:
                    break;

                //Message to display if anything other than numbers 1-6 is entered
                default:
                    Console.Write("\nInvalid calculator option chosen!\n");
                    Console.Write("\nPress enter to go back to menu....");
                    Console.ReadLine();
                    goto Menu;
            }
        }
    }
}