// See https://aka.ms/new-console-template for more information
List<int> numbers = new List<int>();

while (true)
{
    Console.WriteLine("Input a list of integers (Input 'exit' to finish):");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        break;
    }

    try
    {
        int num = Convert.ToInt32(input);
        numbers.Add(num);
        Console.WriteLine("Number added successfully!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

if (numbers.Count > 0)
{
    Console.WriteLine("Here are the collected integers:");
    foreach (int num in numbers)
    {
        Console.WriteLine(num);
    }
}
else
{
    Console.WriteLine("No integers were entered.");
}