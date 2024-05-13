// See https://aka.ms/new-console-template for more information
Console.WriteLine(IsEqualMinus(4, 5, 6));
Console.WriteLine(IsEqualMinus(7, 12, 13));
static bool IsEqualMinus(int num1, int num2, int num3)
{
    int smallest = Math.Min(Math.Min(num1, num2), num3);
    int biggest = Math.Max(Math.Max(num1, num2), num3);
    int medium;
    if (num1 != smallest && num1 != biggest)
    {
        medium = num1;
    }
    else if (num2 != smallest && num2 != biggest)
    {
        medium = num2;
    }
    else
    {
        medium = num3;
    }
    return (medium - smallest) == (biggest - medium);
}

