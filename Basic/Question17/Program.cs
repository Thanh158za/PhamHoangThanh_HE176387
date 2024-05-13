// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Input a string:");
string str = Console.ReadLine();
if(str.Length >= 1)
{
    var s = str.Substring(0, 1);

    Console.WriteLine(s + str + s);
}
