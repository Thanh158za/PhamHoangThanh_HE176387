// See https://aka.ms/new-console-template for more information
Console.Write("Input the number of elements to be stored in the array: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Console.WriteLine($"Input {n} elements in the array:");

for (int i = 0; i < n; i++)
{
    Console.Write($"element - {i} : ");
    arr[i] = int.Parse(Console.ReadLine());
}

Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

foreach (int num in arr)
{
    if (frequencyMap.ContainsKey(num))
        frequencyMap[num]++;
    else
        frequencyMap[num] = 1;
}

Console.WriteLine("Frequency of all elements of array:");
foreach (var kvp in frequencyMap)
{
    Console.WriteLine($"{kvp.Key} occurs {kvp.Value} times");
}
