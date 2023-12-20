using System;

class Program
{
    static void Main()
    {
        bool spelaIgen = true;

        while (spelaIgen)
        {

            // Genererar 10 slumpmässiga tal.
            int[] slumpNummer = new int[10];

            Random random = new Random();
            for (int i = 0; i < slumpNummer.Length; i++)
            {
                slumpNummer[i] = random.Next(1, 101);
            }

            // En array för att förvara spelarens tal.
            int[] spelarensNummer = new int[10];

            Console.WriteLine("Nu börjar vi!");

            
            for (int i = 0; i < spelarensNummer.Length; i++)
            {
                //spelaren får skriva in sitt nummer
                Console.Write($"Skriv in ett nummer för position {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int givenNummer))
                {
                    spelarensNummer[i] = givenNummer;
                }
                else
                {
                    Console.WriteLine("Fel format. Ange ett nummer mellan 1 - 100.");
                    i--; // Stoppar den från att lägga till i försöken/positionen när man har angett fel format
                }
            }

            // Matchar spelarens nummer med det generarde numret.
            bool fåttBingo = Array.Exists(spelarensNummer, number => Array.Exists(slumpNummer, randNum => randNum == number));

            
            if (fåttBingo)
            {
                Console.WriteLine("Bingo!");
            }
            else
            {
                Console.WriteLine("Ingen bingo. Lycka till nästa gång!");
            }
            // Frågar om spelaren vill spela igen.
            Console.WriteLine("Vill du spela igen? Skriv 'ja' för att fortsätta spela.");
            string spelaIgenInput = Console.ReadLine().ToLower();

            if (spelaIgenInput != "ja")
            {
                spelaIgen = false;
            }
            Console.Clear(); //tar bort det tidigare bingo spel
        }

        Console.WriteLine("Tack för att du spelade. Hej då!");

        
    }

}