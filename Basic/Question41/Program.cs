// See https://aka.ms/new-console-template for more information


Console.WriteLine("Input a string: ");
string str = Console.ReadLine();
var count = str.Count(s => s == 'w');
Console.Write(count >= 1 && count <= 3);
