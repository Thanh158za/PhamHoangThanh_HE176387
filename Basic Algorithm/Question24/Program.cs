// See https://aka.ms/new-console-template for more information
Console.WriteLine(UpperThreeEndChar("Python"));
Console.WriteLine(UpperThreeEndChar("Javascript"));
Console.WriteLine(UpperThreeEndChar("js"));
Console.WriteLine(UpperThreeEndChar("PHP"));
static string UpperThreeEndChar(string str)
{
    if(str.Length < 3)
    {
        return str.ToUpper();
    }
    return str.Remove(str.Length - 3, 3) + "" + str.Substring(str.Length-3).ToUpper();
}
