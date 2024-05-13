// See https://aka.ms/new-console-template for more information
const int count = 10;

int[] numbers = new int[count];
int sum = 0;

Console.WriteLine("Enter {0} numbers:", count);

for (int i = 0; i < count; i++)
{
    Console.Write("Number {0} : ", i + 1);
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    sum += numbers[i];
}

double average = (double)sum / count;

Console.WriteLine($"The sum of {count} numbers is: {sum}");
Console.WriteLine($"The average is: {average:F6}");
