// See https://aka.ms/new-console-template for more information

Console.Write(FindMax(3,4,5));
static int FindMax(int a, int b, int c)
{
    return Math.Max(a, Math.Max(b, c));
}
