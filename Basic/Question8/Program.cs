// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number:");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{a} * {i} = {a * i}");

}
