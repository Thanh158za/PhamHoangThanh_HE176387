// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter an alphabet letter:");
char letter = Convert.ToChar(Console.ReadLine().ToLower());

if (char.IsLetter(letter))
{
    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
    {
        Console.WriteLine("The alphabet is a vowel.");
    }
    else
    {
        Console.WriteLine("The alphabet is a consonant.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid alphabet letter.");
}
