// See https://aka.ms/new-console-template for more information
Console.Write("Input the number of elements to be stored in the array: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Element - {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

int max = arr[0];
int min = arr[0];

for (int i = 1; i < n; i++)
{
    if (arr[i] > max)
        max = arr[i];

    if (arr[i] < min)
        min = arr[i];
}

Console.WriteLine($"Maximum element is: {max}");
Console.WriteLine($"Minimum element is: {min}");
