using System.Data.SqlTypes;

class Program
{
    static int FahrToCels(int fahrenheit)
    {
        int celcius = (int)((fahrenheit - 32) * 5.0 / 9.0);
        return celcius;

    }

    public static void Main(string[] args)
    {

        Console.WriteLine("Skriv temperaturen i fahrenheit: ");
        string fahrenheitInput = Console.ReadLine();


        int fahrenheit;
        if (int.TryParse(fahrenheitInput, out fahrenheit))
        {
            int celcius = FahrToCels(fahrenheit);
            Console.WriteLine($"Temperaturen är {celcius}°C");
        }
        else
        {
            Console.WriteLine("Fel inmatning..");
        }
    }

}