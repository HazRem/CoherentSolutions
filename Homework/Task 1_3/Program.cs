Console.WriteLine("Enter the number of elements in the array:");
int n = int.Parse(Console.ReadLine());

int[] originalArray = new int[n];

Console.WriteLine("Enter the elements of the array:");
for (int i = 0; i < n; i++)
{
    originalArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Original array:");
for (int i = 0; i < n; i++)
{
    Console.Write(originalArray[i] + " ");
}
Console.WriteLine();

int[] uniqueArray = new int[n];
int uniqueCount = 0;

for (int i = 0; i < n; i++)
{
    bool isDuplicate = false;

    for (int j = 0; j < uniqueCount; j++)
    {
        if (originalArray[i] == uniqueArray[j])
        {
            isDuplicate = true;
            break;
        }
    }

    if (!isDuplicate)
    {
        uniqueArray[uniqueCount] = originalArray[i];
        uniqueCount++;
    }
}

Console.WriteLine("Array with unique values:");
for (int i = 0; i < uniqueCount; i++)
{
    Console.Write(uniqueArray[i] + " ");
}
Console.WriteLine();