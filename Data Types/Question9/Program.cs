// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input a symbol:");
char symbol = Console.ReadLine()[0];

if (char.IsDigit(symbol))
{
    Console.WriteLine("It's a digit.");
}
else if (IsVowel(symbol))
{
    Console.WriteLine("It's a lowercase vowel.");
}
else
{
    Console.WriteLine("It's any other symbol.");
}

static bool IsVowel(char c)
{
    char lowerC = char.ToLower(c);
    return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
}
