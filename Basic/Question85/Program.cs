// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

int[] arr1 = { 1, 3, 4, 5, 6, 7 };
double[] arr2 = { 1.2, -3, 4.1, 6, -5.47 };
Console.WriteLine("Original Array elements:");
PrintIntArray(arr1);
Console.WriteLine("Cumulative sum of the said array elements:");
PrintIntArray(CalculateIntSum(arr1));

Console.WriteLine("\nOriginal Array elements:");
PrintDoubleArray(arr2);
Console.WriteLine("Cumulative sum of the said array elements:");
PrintDoubleArray(CalculateDoubleSum(arr2));


static void PrintIntArray(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

static void PrintDoubleArray(double[] arr)
{
    foreach (double num in arr)
    {
        Console.Write($"{num:0.00} ");
    }
    Console.WriteLine();
}
static double[] CalculateDoubleSum(double[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        arr[i] += arr[i - 1];
    }
    return arr;
}

static int[] CalculateIntSum(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        arr[i] += arr[i - 1];
    }
    return arr;
}