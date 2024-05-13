// See https://aka.ms/new-console-template for more information
string specifiedWord = "Hello";

Console.Write("Input a string: ");
string inputString = Console.ReadLine();

bool isStartsWith = inputString.StartsWith(specifiedWord);

Console.Write(isStartsWith);
