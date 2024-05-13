// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
string str1 = "Python";
string str2 = "C Sharp";
string str3 = "Javascript";
string result = Regex.Replace(str1, @"[aeiouAEIOU]", "");
Console.WriteLine(result);
string result2 = Regex.Replace(str2, @"[aeiouAEIOU]", "");
Console.WriteLine(result2);
string result3 = Regex.Replace(str3, @"[aeiouAEIOU]", "");
Console.WriteLine(result3);
