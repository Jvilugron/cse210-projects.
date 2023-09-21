using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string playAgain;

        do
        {
            int magicNumber = random.Next(1, 101);
            int guess;
            int numberOfGuesses = 0;

            Console.WriteLine("Welcome to Guess My Number Game!");
            
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numberOfGuesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            } while (guess != magicNumber);

            Console.WriteLine($"It took you {numberOfGuesses} guesses.");
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();

        } while (playAgain.ToLower() == "yes");
    }
}
