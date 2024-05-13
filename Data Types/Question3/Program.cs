// See https://aka.ms/new-console-template for more information
int maxAttempts = 3;
int attempts = 0;
string expectedUserId = "admin";
string expectedPassword = "password";

while (attempts < maxAttempts)
{
    Console.Write("Enter User ID: ");
    string userId = Console.ReadLine();

    Console.Write("Enter Password: ");
    string password = Console.ReadLine();

    if (userId == expectedUserId && password == expectedPassword)
    {
        Console.WriteLine("Login successful!");
        break;
    }
    else
    {
        attempts++;
        Console.WriteLine("Invalid credentials. Attempts remaining: " + (maxAttempts - attempts));
    }
}

if (attempts == maxAttempts)
{
    Console.WriteLine("Login failed. Maximum attempts reached.");
}

Console.ReadLine();
