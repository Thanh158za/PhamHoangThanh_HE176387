// See https://aka.ms/new-console-template for more information
Console.Write("Input the 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the 3rd number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int largestNumber = num1;

if (num2 > largestNumber)
{
    largestNumber = num2;
}

if (num3 > largestNumber)
{
    largestNumber = num3;
}

Console.WriteLine("The {0} Number is the greatest among three", GetNumberPosition(largestNumber));
static string GetNumberPosition(int number)
{
    if (number == 1)
    {
        return "1st";
    }
    else if (number == 2)
    {
        return "2nd";
    }
    else
    {
        return "3rd";
    }
}
