// See https://aka.ms/new-console-template for more information
Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input operation (+,-,*,/): ");
char operation = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = 0;

switch (operation)
{
    case '+':
        result = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
        break;
    case '-':
        result = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
        break;
    case '*':
    case 'x':
        result = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
        break;
    case '/':
        if (secondNumber != 0)
        {
            result = firstNumber / secondNumber;
            Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        break;
    default:
        Console.WriteLine("Error: Invalid operation entered.");
        return;
}
    
