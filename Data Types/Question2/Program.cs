// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter width: ");
int width = Convert.ToInt32(Console.ReadLine());

// Display the triangle
for (int i = width; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(number);
    }
    Console.WriteLine();
}
