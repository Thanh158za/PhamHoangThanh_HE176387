// See https://aka.ms/new-console-template for more information
Console.Write($"Input a number:");
int number = checkInputNumber();
Console.WriteLine($"Number:{number}");
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
            Console.WriteLine("Invalid input. Please enter a valid integer.:");
        }
    }
}
