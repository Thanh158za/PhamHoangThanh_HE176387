// See https://aka.ms/new-console-template for more information
Console.Write("Enter the temperature in Celsius: ");
int temperature = Convert.ToInt32(Console.ReadLine());

string message;

if (temperature < 0)
{
    message = "Freezing weather";
}
else if (temperature >= 0 && temperature <= 10)
{
    message = "Very cold weather";
}
else if (temperature > 10 && temperature <= 20)
{
    message = "Cold weather";
}
else if (temperature > 20 && temperature <= 30)
{
    message = "Normal in temperature";
}
else if (temperature > 30 && temperature <= 40)
{
    message = "It's hot";
}
else
{
    message = "It's very hot";
}

Console.WriteLine(message);
