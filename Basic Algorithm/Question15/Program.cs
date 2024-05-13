// See https://aka.ms/new-console-template for more information

Console.WriteLine(CheckRange(11, 20, 12));
Console.Write(CheckRange(11, 10, 11));
static bool CheckRange(int num1, int num2, int num3)
{
    return num1 >= 20 && num1 <= 50 || num2 >= 20 && num2 <= 50 || num3 >= 20 && num3 <= 50;
}

