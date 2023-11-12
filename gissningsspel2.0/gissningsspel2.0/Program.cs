using System;

class Program
{
    static void Main()
    {
        GuessingGame();
    }

    static void GuessingGame()
    {
        int maxRounds = 5;
        int currentRound = 0;
        int? bestRound = null;
        int bestRoundGuesses = int.MaxValue;

        while (currentRound < maxRounds)
        {
            Random random = new Random();
            int rngNum = random.Next(1, 101);
            currentRound++;

            Console.WriteLine($"Welcome to Anna's guessing game! Round {currentRound}");

            Console.Write("Are you ready to play? Type 'yes' to continue....");
            string answerToPlay = Console.ReadLine().ToLower();

            int maxAttempts = 10;
            int attempts = 0;

            if (answerToPlay == "yes")
            {
                while (attempts < maxAttempts)
                {
                    Console.Write("Guess a number from 1 to 100: ");
                    string userGuessStr = Console.ReadLine();

                    if (int.TryParse(userGuessStr, out int userGuess) && userGuess >= 1 && userGuess <= 100)
                    {
                        attempts++;

                        if (userGuess == rngNum)
                        {
                            Console.WriteLine("Congratulations! You won the round!");
                            break;
                        }
                        else if (userGuess < rngNum)
                        {
                            Console.WriteLine("The guess was too low.");
                        }
                        else if (userGuess > rngNum)
                        {
                            Console.WriteLine("The guess was too high.");
                        }
                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine("Wrong format. Please enter a valid number.");
                    }
                }

                if (attempts >= maxAttempts)
                {
                    Console.WriteLine($"Round {currentRound} over. You lost. The correct number was {rngNum}.");
                }
                else
                {
                    Console.WriteLine($"Round {currentRound} over. It took you {attempts} guesses to get it right.");

                    if (attempts < bestRoundGuesses)
                    {
                        bestRound = currentRound;
                        bestRoundGuesses = attempts;
                    }
                }

                if (currentRound < maxRounds)
                {
                    Console.Write("Do you want to continue to the next round? Type 'yes' to continue, or 'no' to quit: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer != "yes")
                    {
                        Console.WriteLine("All done!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Bye!");
                break;
            }
        }

        Console.WriteLine($"\nGame Over!\nYour best round was Round {bestRound} with {bestRoundGuesses} guesses.");
    }
}
