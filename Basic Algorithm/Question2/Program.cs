// See https://aka.ms/new-console-template for more information
Console.WriteLine(absoluteDifference(51));
Console.WriteLine(absoluteDifference(30));
Console.Write(absoluteDifference(53));
static int absoluteDifference(int a)
{
    const int b = 51;

    return a > b ? (a - b) * 3 : b - a;
}