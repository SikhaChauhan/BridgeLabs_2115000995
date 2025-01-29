using System;
class NumGuessingGame
{
    // Function to generate a random guess between the current range
    static int Guess_Generation(int min, int max)
    {
        Random rand = new Random();
        return rand.Next(min, max + 1);
    }
    // Function to get user feedback on the guess
    static string Get_fd_back(int guess)
    {
        Console.WriteLine($"Is your number {guess}? (Enter 'high', 'low', or 'correct'):");
        string fd_back = Console.ReadLine().ToLower();

        while (fd_back != "high" && fd_back != "low" && fd_back != "correct")
        {
            Console.WriteLine("Invalid input! Please enter 'high', 'low', or 'correct':");
            fd_back = Console.ReadLine().ToLower();
        }

        return fd_back;
    }

    static void Main()
    {
        int min = 1;
        int max = 100;
        string fd_back = "";
        int guess;
        
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Think of a number between 1 and 100, and I will try to guess it.");

        while (fd_back != "correct")
        {
            guess = Guess_Generation(min, max);
            fd_back = Get_fd_back(guess);

            if (fd_back == "high")
            {
                max = guess - 1; 
            }
            else if (fd_back == "low")
            {
                min = guess + 1; 
            }
        }
        
        Console.WriteLine("Yay! I guessed your number correctly.");
    }
}
