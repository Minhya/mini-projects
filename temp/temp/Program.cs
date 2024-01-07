using System.Data.SqlTypes;

class Program
{
    //class/metod to convert fah to celcius
    static decimal ConvertFahrenheitToCelsius(int fahrenheit)
    {
        decimal celsius = (decimal)((fahrenheit - 32) * 5.0 / 9.0);
        return celsius;

    }

    static void Main()
    {
        decimal celsiusTemp = 0;

        do 
        {
            Console.WriteLine("Enter temp in fahr forthe sauna the number must be between 82 and 87: ");
            string fahrenheitInput = Console.ReadLine();

            if (int.TryParse(fahrenheitInput, out int fahrenheit))
            {

                celsiusTemp = ConvertFahrenheitToCelsius(fahrenheit);

                if (celsiusTemp < 82)
                {
                    Console.WriteLine("It's too cold.");
                }
                else if (celsiusTemp > 87)
                {
                    Console.WriteLine("It is too hot.");
                }
                else
                {
                    Console.WriteLine($"The temperature of {celsiusTemp}°C degrees are good.");
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

        }while (celsiusTemp < 82 || celsiusTemp > 87);
    }
 }
