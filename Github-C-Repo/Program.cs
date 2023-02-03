using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            //Runs function created below to get info
            GetAppInfo();

            //Ask for user name and greet
            GreetUser();

            while (true)
            {

                //Init Correct Number
                //int correctNumber = 7;

                //Create a new random object

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // init guest variable
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");


                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get user input
                    string input = Console.ReadLine();

                    // Make sure its a number

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //keep going
                        continue;
                    }


                    guess = Int32.Parse(input);

                    //Match guess to correct number

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number try again");
                    }
                }

                // Output success message

                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                // Ask if they want to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get the Answer

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        static void GetAppInfo()
        {
            // Set app vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jordan Wolter";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Write our app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Inform user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}