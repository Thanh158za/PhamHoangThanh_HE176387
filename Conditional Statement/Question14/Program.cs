// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the lengths of the sides of the triangle:");
Console.Write("Side 1: ");
int side1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Side 2: ");
int side2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Side 3: ");
int side3 = Convert.ToInt32(Console.ReadLine());

if (side1 == side2 && side2 == side3)
{
    Console.WriteLine("This is an equilateral triangle.");
}
else if (side1 == side2 || side1 == side3 || side2 == side3)
{
    Console.WriteLine("This is an isosceles triangle.");
}
else
{
    Console.WriteLine("This is a scalene triangle.");
}