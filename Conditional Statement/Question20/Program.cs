﻿// See https://aka.ms/new-console-template for more information
Console.Write("Enter the day number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

string dayName;

switch (dayNumber)
{
    case 1:
        dayName = "Sunday";
        break;
    case 2:
        dayName = "Monday";
        break;
    case 3:
        dayName = "Tuesday";
        break;
    case 4:
        dayName = "Wednesday";
        break;
    case 5:
        dayName = "Thursday";
        break;
    case 6:
        dayName = "Friday";
        break;
    case 7:
        dayName = "Saturday";
        break;
    default:
        dayName = "Invalid day number";
        break;
}

Console.WriteLine("The day is: " + dayName);
