// See https://aka.ms/new-console-template for more information

int[] arr1 = { 1, 1, 2, 3, 1 };
int[] arr2 = { 1, 1, 2, 4, 1 };
int[] arr3 = { 1, 1, 2, 1, 2, 3 };

Console.WriteLine(CheckSequence(arr1));
Console.WriteLine(CheckSequence(arr2));
Console.WriteLine(CheckSequence(arr3));
static bool CheckSequence(int[] arr)
{
    for (int i = 0; i < arr.Length - 2; i++)
    {
        if (arr[i] == 1 && arr[i + 1] == 2 && arr[i + 2] == 3)
        {
            return true;
        }
    }
    return false;
}