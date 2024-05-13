// See https://aka.ms/new-console-template for more information

Console.Write("Input the number of elements to store in the array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

Console.WriteLine($"Input {n} number of elements in the array:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"element {i} : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The values stored into the array are:");
PrintArray(array);

Console.WriteLine("The values stored into the array in reverse are:");
PrintReverseArray(array);

Console.ReadLine();
static void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}

static void PrintReverseArray(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.Write(array[i] + " ");
    }
}
