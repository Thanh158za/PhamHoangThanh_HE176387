// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Congratulations! You are eligible for casting your vote.");
}
else
{
    Console.WriteLine("Sorry, Fail.");
}
