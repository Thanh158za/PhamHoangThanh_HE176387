// See https://aka.ms/new-console-template for more information
Console.WriteLine(checkMultiple(13));
Console.WriteLine(checkMultiple(14));
Console.WriteLine(checkMultiple(27));
Console.WriteLine(checkMultiple(41));
static bool checkMultiple(int num)
{
    return num % 13 == 1 || num % 13 == 0;
}