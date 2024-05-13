// See https://aka.ms/new-console-template for more information
Console.WriteLine(CheckString("FizzBuzz"));
Console.WriteLine(CheckString("FizzFizz"));
Console.WriteLine(CheckString("FizzBuzzB"));
static string CheckString(string str)
{
    if (str.StartsWith("F") && str.EndsWith("B"))
    {
        return "FizzBuzz";
    }
    else if (str.StartsWith("F"))
    {
        return "Fizz";
    }
    else if (str.EndsWith("B"))
    {
        return "Buzz";
    }
    else
    {
        return str;
    }
}