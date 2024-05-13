// See https://aka.ms/new-console-template for more information
Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

Console.WriteLine($"Input {size} elements in the array:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"element {i} : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Elements in array are: ");
foreach (int element in array)
{
    Console.Write(element + " ");
}
