// See https://aka.ms/new-console-template for more information

int num1, num2;
Console.WriteLine("Enter number 1:");
num1 = checkInputNumber();
Console.WriteLine("Enter number 2:");
num2 = checkInputNumber();
if(num2 == 0)
{
    Console.WriteLine("Can't devide by 0");
}
else
{
    Console.WriteLine($"{num1}/{num2}={(float)num1/num2}");
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
