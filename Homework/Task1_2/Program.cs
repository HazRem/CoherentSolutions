Console.WriteLine("Enter the first 9 digits of the ISBN:");
string isbn9 = Console.ReadLine();

int sum = 0;
int checkDigit;

for (int i = 0; i < 9; i++)
{
    sum += (10 - i) * (isbn9[i] - '0');
}

checkDigit = 11 - (sum % 11);

string isbn10 = isbn9 + (checkDigit == 10 ? "X" : checkDigit.ToString());
Console.WriteLine("The complete 10-digit ISBN is: " + isbn10);
