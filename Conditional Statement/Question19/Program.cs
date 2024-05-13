// See https://aka.ms/new-console-template for more information
Console.Write("Input the grade: ");
char grade = Console.ReadLine().ToUpper()[0];

string description;

switch (grade)
{
    case 'E':
        description = "Excellent";
        break;
    case 'V':
        description = "Very Good";
        break;
    case 'G':
        description = "Good";
        break;
    case 'A':
        description = "Average";
        break;
    case 'F':
        description = "Fail";
        break;
    default:
        description = "Unknown";
        break;
}

Console.WriteLine("You have chosen: " + description);
