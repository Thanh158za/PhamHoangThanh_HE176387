// See https://aka.ms/new-console-template for more information
Console.Write("Enter a string: ");
string str = Console.ReadLine();
string[] words = str.Split(' ');

Console.WriteLine("String after reverse:");
string strReverse = "";
for (int i = words.Length - 1; i >= 0; i--)
{
    strReverse += words[i] + " ";
}
Console.WriteLine(strReverse.Trim());



