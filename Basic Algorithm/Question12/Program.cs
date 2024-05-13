// See https://aka.ms/new-console-template for more information

string[] testStrings = { "C# Sharp", "C#", "C++" };

foreach (string str in testStrings)
{
    Console.WriteLine(StartsWithCSharp(str));
}
static bool StartsWithCSharp(string str)
{
    return str.StartsWith("C#");
}