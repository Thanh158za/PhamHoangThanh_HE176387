// See https://aka.ms/new-console-template for more information
Console.Write("Enter the month number: ");
int monthNumber = Convert.ToInt32(Console.ReadLine());

int numberOfDays = GetNumberOfDays(monthNumber);
Console.WriteLine("Month has {0} days", numberOfDays);

Console.ReadLine();

static int GetNumberOfDays(int monthNumber)
{
    switch (monthNumber)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            return 31;

        case 4:
        case 6:
        case 9:
        case 11:
            return 30;

        case 2:
            return 28;
        default:
            return -1;
    }
}
