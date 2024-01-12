using System.Data.SqlTypes;

class Program
{
    
    static decimal ConvertFahrenheitToCelsius(int fahrenheit)//metod för att konvertera Fahr till cels.
    {
        decimal celsius = (decimal)((fahrenheit - 32) * 5.0 / 9.0); //för att räkna ut fah till cel.
        return celsius;

    }

    static void Main()
    {
        decimal celsiusTemp = 0; //initiera 0.

        do 
        {
            Console.WriteLine("Mata in temperaturen i fahrenheit, temperaturen måste ligga mellan 82 - 87 °C grader: ");
            string fahrenheitInput = Console.ReadLine(); //användarens svar ska in hit.

            if (int.TryParse(fahrenheitInput, out int fahrenheit)) //try parse för att inte krascha programmet.
            {

                celsiusTemp = ConvertFahrenheitToCelsius(fahrenheit);

                if (celsiusTemp < 82) //if statement för vad som ska hända ifall värdet som anges är lägre eller högre än det idealla temperaturen.
                {
                    Console.WriteLine("Det är för kallt.");
                }
                else if (celsiusTemp > 87)
                {
                    Console.WriteLine("Det är för varmt.");
                }
                else//detta händer om inmatningen är mellan 82 - 87. Dvs om de andra if/elif statement inte stämmer.
                {
                    Console.WriteLine($"Temperaturen på {celsiusTemp}°C grader är lagom.");
                }

            }
            else
            {
                Console.WriteLine("Vänligen ange ett nummer."); //om inmatningen är ogiltig, t.ex om det är en bokstav kommer detta upp.
            }

        }while (celsiusTemp < 82 || celsiusTemp > 87);
    }
 }
