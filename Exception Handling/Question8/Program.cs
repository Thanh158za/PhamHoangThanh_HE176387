// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Enter the numerator:");
    double numerator = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the denominator:");
    double denominator = Convert.ToDouble(Console.ReadLine());
    if (denominator == 0)
    {
        Console.WriteLine("Error: Cannot divide by zero.");
    }
    else
    {
        double result = numerator / denominator;
        Console.WriteLine("Result: {0}", result);
    }
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}


