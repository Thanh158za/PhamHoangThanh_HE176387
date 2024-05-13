// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input first integer: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Check if one is negative and one is positive:");
Console.WriteLine((a < 0 && b > 0) || (a > 0 && b < 0));