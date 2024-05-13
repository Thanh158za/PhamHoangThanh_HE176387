// See https://aka.ms/new-console-template for more information

using System.Globalization;

DateTime date = GetDate();
Console.WriteLine("Converted date: {0:d}", date);
static DateTime GetDate()
{
    while (true)
    {
        Console.WriteLine("Enter a date in format dd/mm/yyyy: ");
        string input = Console.ReadLine();

        try
        {
            return DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date format. Please try again.");
        }
    }
}
