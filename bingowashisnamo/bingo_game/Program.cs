using System;

class Program
{
    static void Main()
    {
        // Generate an array with 10 random numbers
        List<List<int>> bingoTable = GenerateBingoTable();

        // Create an array to store user-entered numbers
        int[] userNumbers = new int[10];

        // Display the generated random numbers
        Console.WriteLine("I haave generated some random numbers:");
      

        // Let the user enter their numbers
        for (int i = 0; i < userNumbers.Length; i++)
        {
            Console.Write($"Enter a number for position {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int enteredNumber))
            {
                userNumbers[i] = enteredNumber;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--; // Decrement i to repeat the current iteration
            }
        }

        // Check if any entered number matches the generated random numbers
        bool foundBingo = Array.Exists(userNumbers, number => bingoTable.Exists(row => row.Contains(number)));

        // Print "Bingo" if a matching number is found
        if (foundBingo)
        {
            Console.WriteLine("Bingo!");
        }
        else
        {
            Console.WriteLine("No matching number. Better luck next time!");
        }

        Console.ReadLine(); // Keep the console window open
    }

    static List<List<int>> GenerateBingoTable()

    {
        List<List<int>> bingoTable = new List<List<int>>();
        List<int> forbiddenNumbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Random rndBingo = new Random();
            List<int> bingoTiles = new List<int>();
            int number;


            for (int j = 0; j < 5; j++)
            {
                do
                {
                    number = rndBingo.Next(1, 26);

                } while (forbiddenNumbers.Contains(number));
                bingoTiles.Add(number);
                forbiddenNumbers.Add(number);

            }

            bingoTable.Add(bingoTiles);

        }

        foreach (var row in bingoTable)
            Console.WriteLine($"[{string.Join(",", row)}]");

        return bingoTable;


    }
}