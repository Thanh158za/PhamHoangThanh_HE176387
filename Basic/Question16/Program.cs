// See https://aka.ms/new-console-template for more information
Console.WriteLine(change_index_char("w3resource"));
Console.WriteLine(change_index_char("Python"));
Console.WriteLine(change_index_char("x"));
static string change_index_char(string str)
{
    return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
}