// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine($"{num1} and {num2} are equal");
}
else
{
    Console.WriteLine($"{num1} and {num2} are not equal");
}
