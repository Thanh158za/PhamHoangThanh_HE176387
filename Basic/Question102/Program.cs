// See https://aka.ms/new-console-template for more information
int n;

Console.WriteLine("Input the size of the identity matrix:");
n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    matrix[i, i] = 1;
}

Console.WriteLine("Identity Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
