// See https://aka.ms/new-console-template for more information
Console.Write("Input the number of terms: ");
int n = Convert.ToInt32(Console.ReadLine());

double sum = 0;
string series = "";

for (int i = 1; i <= n; i++)
{
    double term = 1.0 / i;
    sum += term;
    series += "1/" + i + " + ";
}

// Remove the trailing " + " from the series string
series = series.TrimEnd(' ', '+');

Console.WriteLine("Series: " + series);
Console.WriteLine($"Sum of Series up to {n} terms:{sum:F5} ");
