// See https://aka.ms/new-console-template for more information
int a, b;
Console.WriteLine("Enter first number:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
Console.WriteLine($"{a} / {b} = {a / b}");
Console.WriteLine($"{a} mod {b} = {a % b}");