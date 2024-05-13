// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input first integer: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer:");
int b = Convert.ToInt32(Console.ReadLine());
if(a < b)
{
    Console.WriteLine($"|{a} - {b}| = " + Math.Abs(a-b));
}
else
{
    Console.WriteLine($"3.({a} - {b}) = "+3*(a-b));
}
