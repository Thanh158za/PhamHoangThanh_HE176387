// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.Write("Enter string:");
string input = Console.ReadLine();
string result = ConvertToUppercase(input);
Console.WriteLine(result);
static string ConvertToUppercase(string input)
{
    try
    {
    if (string.IsNullOrEmpty(input))
        {
            return "Error: Input string is null or empty";
        }
        return input.ToUpper();
    }
    catch (Exception e)
    {
        return e.ToString();
    }
}
