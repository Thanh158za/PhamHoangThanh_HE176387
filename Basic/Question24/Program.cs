// See https://aka.ms/new-console-template for more information
Console.Write("Enter a string:");
string str = Console.ReadLine();
string[] words = str.Split(' ');
string longestWord = words[0];
foreach (string s in words)
{
    if(s.Length > longestWord.Length)
    {
        longestWord = s;
    }
}
Console.Write(longestWord);