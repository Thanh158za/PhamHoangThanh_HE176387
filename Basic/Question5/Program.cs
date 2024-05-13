// See https://aka.ms/new-console-template for more information

int a, b, temp;
Console.WriteLine("Enter first number:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
b = Convert.ToInt32(Console.ReadLine());

temp = a;
a = b;
b = temp;


Console.WriteLine("After swap");
Console.WriteLine($"The first number:{a}");
Console.WriteLine($"The second number:{b}");


