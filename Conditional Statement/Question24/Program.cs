// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geometry Calculator");
Console.WriteLine("-------------------");
Console.WriteLine("1. Calculate the area of a circle");
Console.WriteLine("2. Calculate the area of a rectangle");
Console.WriteLine("3. Calculate the area of a triangle");
Console.WriteLine("4. Quit");
Console.Write("Enter your choice (1-4): ");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        CalculateCircleArea();
        break;
    case 2:
        CalculateRectangleArea();
        break;
    case 3:
        CalculateTriangleArea();
        break;
    case 4:
        Console.WriteLine("Exiting the program...");
        break;
    default:
        Console.WriteLine("Invalid choice. Please try again.");
        break;
}
static void CalculateCircleArea()
{
    Console.Write("Input radius of the circle: ");
    double radius = Convert.ToDouble(Console.ReadLine());

    double area = Math.PI * radius * radius;

    Console.WriteLine($"The area is: {area:F5}");
}

static void CalculateRectangleArea()
{
    Console.Write("Input length of the rectangle: ");
    double length = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input width of the rectangle: ");
    double width = Convert.ToDouble(Console.ReadLine());

    double area = length * width;

    Console.WriteLine($"The area is: {area:F5}");
}

static void CalculateTriangleArea()
{
    Console.Write("Input base length of the triangle: ");
    double baseLength = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input height of the triangle: ");
    double height = Convert.ToDouble(Console.ReadLine());

    double area = 0.5 * baseLength * height;

    Console.WriteLine($"The area is: {area:F5}");
}
