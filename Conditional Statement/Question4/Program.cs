// See https://aka.ms/new-console-template for more information
Console.Write("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());

if (IsLeapYear(year))
{
    Console.WriteLine($"{year} is a leap year.");
}
else
{
    Console.WriteLine($"{year} is not a leap year.");
}

static bool IsLeapYear(int year)
{
    return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
}
