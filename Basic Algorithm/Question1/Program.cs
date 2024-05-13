// See https://aka.ms/new-console-template for more information
Console.WriteLine(SumOfTwoInteger(1,3));
Console.WriteLine(SumOfTwoInteger(2, 4));
Console.WriteLine(SumOfTwoInteger(5, 3));
static int SumOfTwoInteger(int x, int y)
{
    return x == y ? 3 * (x + y) : x + y;
}