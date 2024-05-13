// See https://aka.ms/new-console-template for more information
Console.Write("Enter number: ");
Console.WriteLine(checkInputNumber());
static int checkInputNumber()
{
    string str;
    while (true)
    {
        try
        {
            str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            if (num < 0)
            {
                Console.Write("Enter number > 0:");
                continue;
            }
            else
            {
                return num;
            }
        }
        catch (Exception e)
        {
            Console.Write("Enter number again:");
        }
    }
}
