// See https://aka.ms/new-console-template for more information
Console.Write("Enter the radius of the sphere: ");
double radius = Convert.ToDouble(Console.ReadLine());

double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
double volume = (4 / 3.0) * Math.PI * Math.Pow(radius, 3);

Console.WriteLine($"Surface Area: {surfaceArea:F5}");
Console.WriteLine($"Volume:{volume:F5}");

