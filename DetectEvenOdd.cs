//Number Types Assignment
//Author: Jason Plimpton
//Built: 09/25/2020
//Class: CIS162D
//Notes: Will check if the number entered is an odd or even number
//       while also checking if the entered value is a number.
//       Giving try and catch and also added a if statement version 
//       to check even and odd while giving functions a try to check 
//       user input with a backup check within the code

using System;

//the beginning of it all
namespace EvenOddDetector
{
    //creating a class for a test function
    //used an auto-fix to make it an internal class
    internal class InputCheck
    {
        //trying out creating a function
        //read input function to check users input
        static int ReadInput(string message)
        {
            //defining int n value
            int n = 0;
            do
            {
                //print out message defined below by ReadInput("text here")
                Console.WriteLine(message);
            }
            //while input is a number then ok, if not repeat input question
            while (!int.TryParse(Console.ReadLine(), out n));

            //return converted input to int number
            return n;
        }


        //Main line auto-created by VS, left as is
        static void Main(string[] args)
        {
            Console.WriteLine("Number Type Checker Program v2.1");
            Console.WriteLine("There are 2 versions to try.");
            Console.WriteLine("Choose 1 for if statement version");
            Console.WriteLine("Choose 2 for try and catch version");
            
            //trying out function first on the menu input
            //as it requires number entry like even and odd code
            int menu = ReadInput("Please enter your choice now: \n");

            if (menu == 1)
            {
                //if 1 is entered by user go to if statment code
                goto ifStatment;
            }
            else if (menu == 2 )
            {
                //if 2 is entered go to try and catch code
                goto tryCatch;
            }

            ifStatment:
            //into for if statment even odd check code
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Number Type Checker if statment version");
            Console.WriteLine("-----------------------------------------");

            //second use of function to check user's input
            int input = ReadInput("Please enter a whole number: \n");

            //research quickest/most effcient way to determine even odd numbers
            if (input % 2 == 0)
            {
                Console.WriteLine("{0} is an even integer.", input);
                //since console app, these lines are added so there is a pause
                Console.ReadLine();
                //pulled this little gem from docs to not continue running
                Environment.Exit(0);
            }
            else if (input % 2 != 0)
            {
                Console.WriteLine("{0} is an odd integer.\n", input);
                Console.ReadLine();
                Environment.Exit(0);
            }
            //backup check if user did not enter a number
            else
            {
                Console.WriteLine("Value entered is not a number!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            tryCatch:
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" Number Type Checker try and catch version");
            Console.WriteLine("-------------------------------------------");

            //switched back to general read input so the
            //check can be done within the try and catch
            Console.WriteLine("Please enter a number: ");
            string user = Console.ReadLine();

            //first we try to parse input to a int number
            //if unable to then catch either the format is invalid
            //or the input is empty or null
            try
            {
                //parsing var user to int as number var
                var number = int.Parse(user);

                //if input was a number then check for even or odd
                //% 2 was pulled from research on best was to determine even odd
                if (number % 2 == 0)
                {
                    //using the print var option using the $ and {varName}
                    Console.WriteLine($"Entered number {number} is even.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                //if the first check is a no then the number must be an odd
                else
                {
                    Console.WriteLine($"Entered number {number} is odd.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            //catch the users input
            catch (FormatException)
            {
                //check for if input was NULL/nothing
                if (string.IsNullOrEmpty(user))
                {
                    Console.WriteLine("You need to enter some value.");
                    Console.WriteLine("Press enter to continue....");
                    Console.ReadLine();
                    goto tryCatch;
                }
                //if it happens to not be empty then must be a non number so print error
                else
                {
                    Console.WriteLine("You need to enter a number.");
                    Console.WriteLine("Press enter to continue....");
                    Console.ReadLine();
                    goto tryCatch;
                }

            }

            //if user input was not a number then print error
            catch (Exception)
            {
                Console.WriteLine("You need to enter a number.");
                Console.WriteLine("Press enter to continue....");
                Console.ReadLine();
                goto tryCatch;
            }
        }
    }
}
