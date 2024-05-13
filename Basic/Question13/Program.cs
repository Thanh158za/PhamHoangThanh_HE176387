// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 3; j++)
	{
        
        if ((i != 0  && j == 1) && (i != 4 && j == 1))
		{
            Console.Write(" ");
        }
        else
        {
            Console.Write($"{a}");
        }
	}
    Console.WriteLine();
}
