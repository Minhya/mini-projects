using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Transactions;

namespace annabingo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //generate a random number
            Random rnd = new Random();
            //int rndBingoNr = rnd.Next(1, 26);

            //user enter 10 numbers
            int[] userNr = new int[10];
            List<int> rndBingoNr = RandomBingoNumber(10, 1, 25);

           // List<int> rndBingoNr = new List<int>();

            Random random = new Random();
            List<int> randomBingoNumbers = new List<int>();


            for (int i = 0; i < userNr.Length; i++)
            {
                Console.WriteLine("Enter a number" + i + 1 + ": ");
                if (int.TryParse(Console.ReadLine(), out int enteredNr))
                {
                    userNr[i] = enteredNr;
                }
                else
                {
                    Console.WriteLine("invalid input. Enter a number");
                    i--;
                }
            }



            Console.WriteLine("Enter 10 numbers: ");
            int userNr = Convert.ToInt32(Console.ReadLine());

            if (userNr == rndBingoNr ) 
            {
                Console.WriteLine("Congratulations you got bingo!");

            }
            else
            {
                Console.WriteLine("Try again");
                
            } 
            
            




        }

    }
}



