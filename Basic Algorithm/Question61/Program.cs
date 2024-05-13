// See https://aka.ms/new-console-template for more information

Console.WriteLine(addWord("[[]]", "Hello"));
static string addWord(string str, string word)
{
    return str.Substring(0, 2) + word + str.Substring(2);
}
