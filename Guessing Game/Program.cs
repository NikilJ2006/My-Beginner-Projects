using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInfo();
            GreetUser();
            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                ColouredMessage(ConsoleColor.Green, "Enter a number from 1 to 9.");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!Int32.TryParse(input, out guess))
                    {
                        ColouredMessage(ConsoleColor.Green, "Please enter a valid number");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        ColouredMessage(ConsoleColor.Red, "WRONG!! Please try again.");
                    }
                }
                ColouredMessage(ConsoleColor.Yellow, "YOU WIN!! Congrats");

                ColouredMessage(ConsoleColor.Cyan, "Play Again? [Y/N]");
                string playAgainAnswer = Console.ReadLine().ToUpper();
                if (playAgainAnswer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }
        static void AppInfo()
        {
            string appName = "Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Nikil";

            string message = appName + ": Version: " + appVersion + " by " + appAuthor;

            Console.Title = appName;

            ColouredMessage(ConsoleColor.Green, message);
        }
        static void GreetUser()
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", Let's Start");
        }

        static void ColouredMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
