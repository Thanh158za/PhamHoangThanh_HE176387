// See https://aka.ms/new-console-template for more information
Console.WriteLine(CountAa("bbaaccaag"));
Console.WriteLine(CountAa("jjkiaaasew"));
Console.Write(CountAa("JSaaakoiaa"));
static int CountAa(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length - 1; i++)
    {
        if (str[i] == 'a' && str[i + 1] == 'a')
        {
            count++;
        }
    }
    return count;
}
