// See https://aka.ms/new-console-template for more information

Console.WriteLine(RemoveCharIndex("Python", 0));
Console.WriteLine(RemoveCharIndex("Python", 3));
static string RemoveCharIndex(string str, int n)
{
    return str.Remove(n, 1);
}
