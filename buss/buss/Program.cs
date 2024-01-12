/* Startkod för att komma igång
 * Observera att båda klasserna är i samma fil för att förenkla.
 * Om programmet blir större är det rekommenderat att ha klasserna i separata filer, som jag förklarar i videon.
 * I så fall kan det vara lämpligt att ställa in startvärden, som jag har gjort.
 * Du kan också skriva ut saker i konsolen i konstruktorn för att se att den "vaknar".
 * Denna kod är mest användbar om du siktar på betygen E och C.
 * För högre betyg krävs mer självständigt arbete.
 */
using System;

// Nedan är namnet på "namespace" - projektet.
// Skapa ett nytt konsollprojekt med namnet "Bussen" så kan du kopiera all kod direkt från denna fil
namespace Bussen
{
    /* Börja längst ner i dokumentet och klassen "Program".
     * Denna klass är liten och har uppgiften att starta programmet genom att skapa en buss och sedan anropa Run() metoden.
     * Projektbeskrivningen betonar vikten av att koda stegvis. I det här fallet kanske du bara behöver skriva ut
     * något text i Run() metoden.
     */
    class Passenger
    {
        public int Age { get; set; }

        public Passenger(int age)
        {
            Age = age;
        }
    }

    class Bus
    {
        public Passenger[] passengers = new Passenger[25]; //array/vector
        public int passengerCount = 0;

  

        public void Run()
        {
            Console.WriteLine("Välkommen till fantastiska Buss-simulatorn");

            while (true) //skapar menyn för koden, varje case är kopplade till metoder förutom case 4 som avbryter programmet och default som säger till användaren att mata in rätt i format.
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Lägg till en passagerare");
                Console.WriteLine("2. Skriv ut bussen");
                Console.WriteLine("3. Beräkna total ålder");
                Console.WriteLine("4. Avsluta");

                int temp;
                if (int.TryParse(Console.ReadLine(), out temp)) 
                {
                    // Menyn för att utföra åtgärder ska vara här
                    switch (temp)
                    {
                        case 1:
                            Console.WriteLine("Passagerare tillagd. Ange passagerarens ålder:");
                            int age = int.Parse(Console.ReadLine());
                            AddPassenger(age);
                            break;
                        case 2:
                            PrintPassengerNumber(); // det totala passagerarnumret
                            break;
                        case 3:
                            int totalAge = CalculateTotalAge();
                            Console.WriteLine($"Total ålder av passagerare: {totalAge}");
                            break;
                        case 4:
                            Console.WriteLine("Avslutar programmet. Hej då!");
                            return; //return istället för break för att avsluta programmet.
                        default:
                            Console.WriteLine("Felaktig inmatning");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ange ett nummer 1-4 från menyn.");
                }
            }

            
        }

        // Metoder för betyg E

        public void AddPassenger(int age)
        {
            if (passengerCount < passengers.Length)
            {
                passengers[passengerCount] = new Passenger(age);
                passengerCount++;
                Console.WriteLine("Passagerare tillagd i bussen.");
            }
            else
            {
                Console.WriteLine("Bussen är full.");
            }
        }

        public void PrintPassengerNumber()
        {
            Console.WriteLine("Passagerares åldrar på bussen");
            for (int i = 0; i < passengerCount; i++)
            {
                Console.WriteLine($"Passagerare {i + 1}: Ålder {passengers[i].Age}");
            }
            // Skriv ut alla värden från vektorn. Med andra ord, skriv ut alla passagerare
        }

        public int CalculateTotalAge()
        {
            int totalAge = 0;
            for (int i = 0; i < passengerCount; i++)
            {
                totalAge += passengers[i].Age;
            }
            // Beräkna den totala åldern.
            return totalAge; 
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Detta körs först!
            // Programmet skapar ett objekt av klassen "Bus". Detta är objektet vi kommer att arbeta med.
            // Följande rad skapar en buss:
            var minBuss = new Bus();
            // Följande rad anropar Run() metoden i vårt nya bussobjekt.
            minBuss.Run();
            // När Run() metoden är klar fortsätter koden här. Då är programmet klart.
            
            Console.ReadKey(true);
        }
    }
}
