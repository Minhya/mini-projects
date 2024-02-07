using System;

namespace Bussen
{
   
    class Passenger
    {
        public int age { get; set; } //behöver inte ens get set

        public Passenger(int age) //konstruerar passenger-objektet med en viss ålder.
        {
            this.age = age; //this.age den här klassens age sätter jag till det användaren ger mig i olika metoder.
        }
    }

    class Bus
    {
        public Passenger[] passengers = new Passenger[25]; //array/vector, max 25 passagerare/objekt passengers är en lista av klassen passenger
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

                int input;
                if (int.TryParse(Console.ReadLine(), out input)) 
                {
                    // Menyn för att utföra åtgärder ska vara här, switch på variabeln är 1 ska den göra...
                    switch (input)
                    {
                        
                        case 1:
                            Console.WriteLine("Passagerare tillagd. Ange passagerarens ålder:");
                            try //Trycatch ifall användaren inte skriver in siffror för att lägga in ålder.
                            {
                                int age = int.Parse(Console.ReadLine()); //parse till integer
                                AddPassenger(age); //med argumentet ålder
                            }
                            catch (FormatException) //det som blev fel aktiverar detta, formatet specifikt
                            {
                                Console.WriteLine("Felaktigt format för ålder. Ange nummer för ålder..");
                            }
                            break; //gå ur switch, till menyn. för att köra om programmet.
                        case 2:
                            PrintPassengerNumber(); // det totala passagerarnumret
                            break;
                        case 3:
                            int totalage = CalculateTotalage();
                            Console.WriteLine($"Total ålder av passagerare: {totalage}");
                            break;
                        case 4:
                            Console.WriteLine("Avslutar programmet. Hej då!");
                            return; //return istället för break för att avsluta programmet. return ut från metoden run
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
                passengerCount++; //position
                Console.WriteLine("Passagerare tillagd i bussen.");
            }
            else
            {
                Console.WriteLine("OBS. Bussen var visst full.");
            }
        }

        public void PrintPassengerNumber()
        {
            Console.WriteLine("Passagerares åldrar på bussen är: ");
            for (int i = 0; i < passengerCount; i++) //börjar, tills passengerCount, 1 steg
            {
                Console.WriteLine($"Passagerare {i + 1}: Ålder {passengers[i].age}"); //gjort om 0 position till 1 -talar positionen. i är positionen i vektorn
            }
            // Skriv ut alla värden från vektorn. Med andra ord, skriv ut alla passagerare
        }

        public int CalculateTotalage() //int istället för void. returnerar en int som är totalage.
        {
            int totalage = 0; //börjar på 0
            for (int i = 0; i < passengerCount; i++) //börjar, tills passengerCount, 1 steg
            {
                totalage += passengers[i].age; //totalage = totalage + passenger[i].age; varje steg i vektorn plus totalage som är 0
            }
            // Beräkna den totala åldern.
            return totalage; 
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
