// See https://aka.ms/new-console-template for more information

Console.WriteLine(RemoveAt("Python"));
Console.WriteLine(RemoveAt("ytade"));
Console.WriteLine(RemoveAt("jsues"));
static string RemoveAt(string str)
{
    return (str.Length >= 2 && str.Substring(1, 2) == "yt") ? str.Remove(1, 2) : str;
}
