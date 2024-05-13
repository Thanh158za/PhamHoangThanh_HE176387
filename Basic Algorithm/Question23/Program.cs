// See https://aka.ms/new-console-template for more information

Console.WriteLine(CheckEndDigit(3, 13));
Console.WriteLine(CheckEndDigit(12, 23));
static bool CheckEndDigit(int a, int b)
{
    return Math.Abs(a % 10) == Math.Abs(b % 10);
}
