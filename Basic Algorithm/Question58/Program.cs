// See https://aka.ms/new-console-template for more information
Console.WriteLine(NearestToThirteen(4, 5));
Console.WriteLine(NearestToThirteen(7, 12));
Console.Write(NearestToThirteen(17, 33));
static int NearestToThirteen(int num1, int num2)
{
    int Minus1 = Math.Abs(num1 - 13);
    int Minus2 = Math.Abs(num2 - 13);
    if (num1 > 13 && num2 > 13)
    {
        return 0;
    }
    return Minus1 < Minus2 ? num1 : num2;
}
