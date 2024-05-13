// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} is an even integer");
}
else
{
    Console.WriteLine($"{number} is an odd integer");
}
