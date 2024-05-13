// See https://aka.ms/new-console-template for more information

Console.WriteLine(remove_char("w3resource", 1));
Console.WriteLine(remove_char("w3resource", 9));
Console.WriteLine(remove_char("w3resource", 0));

static string remove_char(string str, int n)
{
    return str.Remove(n, 1);
}
