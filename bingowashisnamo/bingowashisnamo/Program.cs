using System;
using System.Collections.Generic;

namespace annabingo
{
    internal class Program

    {
        public static void Main(string[] args)

        {
            List<List<int>> bingoTable = new List<List<int>>();
                List<int> forbiddenNumbers = new List<int>();

            for (int i = 0; i < 5; i++) {
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

        }
        
    }
}



