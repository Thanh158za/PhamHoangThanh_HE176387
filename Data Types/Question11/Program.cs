// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a decimal number to convert to binary (or type 'end' to exit):");
string input = Console.ReadLine();

while (input != "end")
{
    if (int.TryParse(input, out int number))
    {
        string binary = DecimalToBinary(number);
        Console.WriteLine("Binary: " + binary);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid decimal number or 'end' to exit.");
    }

    Console.WriteLine();
    Console.WriteLine("Enter a decimal number to convert to binary (or type 'end' to exit):");
    input = Console.ReadLine();
}
static string DecimalToBinary(int number)
{
    string binary = "";

    while (number > 0)
    {
        int remainder = number % 2;
        binary = remainder + binary;
        number /= 2;
    }

    return binary;
}
