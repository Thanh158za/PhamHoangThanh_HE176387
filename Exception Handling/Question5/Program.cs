// See https://aka.ms/new-console-template for more information

Console.Write("Enter size of Array:");
int sizeOfArray = checkInputNumber();

int[] numbers = new int[sizeOfArray];
for (int i = 0; i < sizeOfArray; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    numbers[i] = checkInputNumber();
    Console.WriteLine();
}
Console.WriteLine($"Average:{CalculateAverage(numbers)}");
static double CalculateAverage(int[] numbers)
{
    if (numbers.Length == 0)
    {
        Console.WriteLine("Array Empty");
    }

    double sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

static int checkInputNumber()
{
    string str;
    while (true)
    {
        try
        {
            str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            return num;
        }
        catch (Exception e)
        {
            Console.WriteLine("Enter number again:");
        }
    }
}
