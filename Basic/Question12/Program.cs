// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a digit: ");
int number = Convert.ToInt32(Console.ReadLine());   
for (int i = 0; i < 4; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine($"{number} {number} {number} {number}");
    }
    else
    {
        Console.WriteLine($"{number}{number}{number}{number}");
    }
}

