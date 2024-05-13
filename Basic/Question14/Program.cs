// See https://aka.ms/new-console-template for more information
Console.Write("Enter the amonut of celsius: ");
int celsius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Kelvin = {celsius + 273}");
Console.Write($"Fahrenheit = {celsius * 18 / 10 + 32}");