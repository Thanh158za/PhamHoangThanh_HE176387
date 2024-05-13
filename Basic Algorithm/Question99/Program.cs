// See https://aka.ms/new-console-template for more information

int[] originalArray = { 5, 10, 15 };
int[] doubledArray = DoubledArray(originalArray);

Console.WriteLine("Original array:");
foreach (int number in originalArray)
{
    Console.Write(number + " ");
}

Console.WriteLine("\nDoubled array:");
foreach (int number in doubledArray)
{
    Console.Write(number + " ");
}
static int[] DoubledArray(int[] arr)
{
    int newArrayLength = arr.Length * 2;
    int[] doubledArray = new int[newArrayLength];

    doubledArray[0] = arr[0];
    return doubledArray;
}
