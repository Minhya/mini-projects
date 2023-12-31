﻿using System;

namespace annagissningsspel2
{
    internal class Program

    {
        public static void Main(string[] args)
        {

            Program.GuessingGame(args);
        }
        static void GuessingGame(string[] args)
        {

            while (true) // while loop för att loopa hela spelet
            {
                Random rnd = new Random(); // generar ett slumpmässigt nummer
                int rngnum = rnd.Next(1, 101); // lägger en gräns så att det är mellan 1 - 100

                Console.WriteLine("Welcome to Anna's guessing game!");

                Console.WriteLine("Are you ready to play? Type 'yes' to continue....");
                string answer_to_play = Console.ReadLine().ToLower();

                int maxAttempts = 3; 

                if (answer_to_play.ToLower() == "yes")
                {
                    int attempts = 0;

                    while (attempts < maxAttempts) 
                    {
                        Console.WriteLine("Guess a number from 1 to 100: ");
                        int userGuess;

                        if (int.TryParse(Console.ReadLine(), out userGuess))  // TryParse() converts the string data type into int Boolean if its is within the limit. out stores the userguesses
                        {
                            if (userGuess < 1 || userGuess > 100)
                            {
                                attempts++;
                            }
                            else
                            {
                                attempts++;

                                if (userGuess == rngnum)
                                {
                                    Console.WriteLine("Congratulations! You won the game!");
                                    break;
                                }
                                else if (userGuess < rngnum)
                                {
                                    Console.WriteLine("The guess was too low.");
                                }
                                else if (userGuess > rngnum)
                                {
                                    Console.WriteLine("The guess was too high.");
                                }
                            }
                        }
                        else
                        {
                            attempts++;
                            Console.WriteLine("Wrong format. Please enter a valid number.");
                        }
                    }
                    string answer;
                    if (attempts >= maxAttempts)
                    {
                        Console.WriteLine("Game over. You lost. The correct number was " + rngnum + ". Type 'yes' to try again.");
                        answer = Console.ReadLine().ToLower();
                        if (answer != "yes")
                        {
                            Console.WriteLine("All done!");
                            break;
                        }
                    }
                    
                }
                 else Console.WriteLine("Bye!");
                 answer_to_play = Console.ReadLine().ToLower();
                 break;
            }
        }

    }
}