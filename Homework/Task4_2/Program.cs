RationalNumber r1 = new RationalNumber(2, 6);
RationalNumber r2 = new RationalNumber(3, 4);

Console.WriteLine($"r1: {r1}"); // Output: r1: 1/3
Console.WriteLine($"r2: {r2}"); // Output: r2: 3/4

// Arithmetic operations
RationalNumber sum = r1 + r2;
RationalNumber difference = r1 - r2;
RationalNumber product = r1 * r2;
RationalNumber quotient = r1 / r2;

Console.WriteLine($"r1 + r2 = {sum}");       // Output: r1 + r2 = 13/12
Console.WriteLine($"r1 - r2 = {difference}"); // Output: r1 - r2 = -5/12
Console.WriteLine($"r1 * r2 = {product}");    // Output: r1 * r2 = 1/4
Console.WriteLine($"r1 / r2 = {quotient}");   // Output: r1 / r2 = 4/9

// Comparison
Console.WriteLine($"r1 == r2: {r1.Equals(r2)}"); // Output: r1 == r2: False

// Casting
double r1Double = (double)r1;
RationalNumber intToRational = 5;

Console.WriteLine($"r1 as double: {r1Double}");         // Output: r1 as double: 0.3333333333333333
Console.WriteLine($"Integer 5 as rational: {intToRational}"); // Output: Integer 5 as rational: 5/1