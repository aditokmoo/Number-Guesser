using System;

namespace Number_Guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Run Get App info function
            GetAppInfo();

            // Ask for user name and greet
            GreetUser();

            while (true) {

                // Create new random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(0, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!!");

                // Ask user if they want to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y") {
                    continue;
                } else if(answer == "N") {
                    return;
                } else {
                    return;
                }
            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app var's
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Adi Tokmo";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user for name and greet
        static void GreetUser()
        {
            // Asks users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Print Hello Message
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
