// See https://aka.ms/new-console-template for more information
Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}
