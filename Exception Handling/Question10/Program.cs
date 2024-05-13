// See https://aka.ms/new-console-template for more information
double number;

try
{
    Console.Write("Enter a number: ");
    number = double.Parse(Console.ReadLine());

    if (number < 0)
    {
        Console.WriteLine("Enter number > 0");
    }
    else
    {
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine($"The square root of {number} is {Math.Round(squareRoot, 2).ToString()}");
    }
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}

