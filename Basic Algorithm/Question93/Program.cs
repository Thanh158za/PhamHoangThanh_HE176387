// See https://aka.ms/new-console-template for more information
int[] numbers = { 1, 2, 3, 4, 5 };
int[] reversed = ReverseArray(numbers);
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();
foreach (int number in reversed)
{
    Console.Write(number + " ");
}
static int[] ReverseArray(int[] arr)
{
    int[] reversed = new int[arr.Length];
    for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
    {
        reversed[j] = arr[i];
    }
    return reversed;
}