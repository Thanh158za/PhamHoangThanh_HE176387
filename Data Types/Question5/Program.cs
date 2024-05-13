// See https://aka.ms/new-console-template for more information
Console.Write("Input the radius of the circle: ");
double radius = checkInputNumber();

double perimeter = 2 * Math.PI * radius;
double area = Math.PI * radius * radius;

Console.WriteLine("Perimeter of Circle: {0}", perimeter.ToString("F2"));
Console.WriteLine("Area of Circle: {0}", area.ToString("F2"));

static int checkInputNumber()
{
    string str;
    while (true)
    {
        try
        {
            str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            if (num <= 0)
            {
                Console.Write("Enter radius > 0:");
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
