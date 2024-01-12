using System.Data.SqlTypes;

class Program
{
    static int FahrToCels(int fahrenheit) //metod för att konvertera fahrenheit till celsius.
    {
        int celcius = (int)((fahrenheit - 32) * 5.0 / 9.0); //uträkningen för celsius.
        return celcius;

    }

    public static void Main(string[] args)//metoden för att mata in fahrenheit samt att den kommer att använda sig av FahrToCels metoden.
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