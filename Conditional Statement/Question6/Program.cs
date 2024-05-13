// See https://aka.ms/new-console-template for more information
Console.Write("Enter the value of m: ");
int m = Convert.ToInt32(Console.ReadLine());

int n;

if (m > 0)
{
    n = 1;
}
else if (m == 0)
{
    n = 0;
}
else
{
    n = -1;
}

Console.WriteLine("The value of n = " + n);
