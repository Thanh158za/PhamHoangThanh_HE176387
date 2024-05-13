// See https://aka.ms/new-console-template for more information
int size;
Console.Write("Input the size of the array: ");
size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];
Console.WriteLine("Input {0} elements in the array in ascending order:", size);
for (int i = 0; i < size; i++)
{
    Console.Write("element - {0} : ", i);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Input the position where to delete: ");
int position = Convert.ToInt32(Console.ReadLine());

if (position < 0 || position >= size)
{
    Console.WriteLine("Invalid position!");
}
else
{
    int[] newArr = new int[size - 1];
    int newIndex = 0;

    for (int i = 0; i < size; i++)
    {
        if (i != position)
        {
            newArr[newIndex] = arr[i];
            newIndex++;
        }
    }

    Console.Write("The new list is: ");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write(newArr[i] + " ");
    }
}
