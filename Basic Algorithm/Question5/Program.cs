// See https://aka.ms/new-console-template for more information

Console.WriteLine(addIfStart("if else"));
Console.WriteLine(addIfStart("fish"));
static string addIfStart(string str)
{
    if(str.Length >2 && str.Substring(0, 2).Equals("if")){
        return str;
    }
    return "if " + str;
}
