// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the file path: ");
string filePath = Console.ReadLine();

try
{
    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
    Console.WriteLine("File opened successfully!");
}
catch (Exception ex)
{
    Console.WriteLine("Error");
    Console.WriteLine(ex.Message);
}
