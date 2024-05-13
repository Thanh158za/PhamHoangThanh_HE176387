// See https://aka.ms/new-console-template for more information
int x, y, z;
Console.Write("Enter the First number:");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the First number:");
y = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the First number:");
z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {(x + y)*z} and x.y + y.z is {x*y + y*z}");
