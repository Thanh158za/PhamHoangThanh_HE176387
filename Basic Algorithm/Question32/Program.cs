// See https://aka.ms/new-console-template for more information

int[] numbers = { 1, 3, 5, 7, 9 };
Console.WriteLine(checkNumber(numbers, 5));
Console.WriteLine(checkNumber(numbers, 6));
static bool checkNumber(int[] arr, int num)
{
    foreach (int element in arr)
    {
        if (element == num)
        {
            return true;
        }
    }
    return false;
}
