Console.WriteLine("Please input the first number...");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please input the second number...");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
    SwapVariableValues(firstNumber, secondNumber);
Console.WriteLine("Instances of numbers with 2 A's in duodecimal system:");
for (int i = firstNumber; i <= secondNumber; i++)
{
    string duodecimal = ConvertToDuoDecimal(i);
    if (CountACharOccurences(duodecimal) == 2)
        Console.WriteLine(i);
}
Console.WriteLine("Press any key to leave...");
Console.ReadKey();


static string ConvertToDuoDecimal(int number)
{
    if (number == 0)
        return "0";

    int remainder = number % 12;
    string result;

    if (remainder == 10)
        result = "A";
    else if (remainder == 11)
        result = "B";
    else
        result = remainder.ToString();

    if (number / 12 > 0)
        return ConvertToDuoDecimal(number / 12) + result;
    else
        return result;
}

static int CountACharOccurences(string input)
{
    int count = 0;
    foreach (char c in input)
        if (c == 'A')
            count++;
    return count;
}

static void SwapVariableValues(int a, int b)
{
    int tempInt = b;
    b = a;
    a = tempInt;
}
