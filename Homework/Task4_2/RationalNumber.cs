public sealed class RationalNumber : IComparable<RationalNumber>
{
    public int Numerator { get; }
    public int Denominator { get; }

    public RationalNumber(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));

        int gcd = SimplifyToIrreducibleFraction(Math.Abs(numerator), Math.Abs(denominator));
        Numerator = numerator / gcd;
        Denominator = denominator / gcd;

        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
    }

    private static int SimplifyToIrreducibleFraction(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }

    public override bool Equals(object obj) =>
        obj is RationalNumber other &&
        Numerator == other.Numerator &&
        Denominator == other.Denominator;

    public override int GetHashCode() =>
        HashCode.Combine(Numerator, Denominator);

    public override string ToString() => $"{Numerator}/{Denominator}";

    public int CompareTo(RationalNumber other)
    {
        if (other is null) return 1;
        return (Numerator * other.Denominator).CompareTo(Denominator * other.Numerator);
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2) =>
        new RationalNumber(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2) =>
        new RationalNumber(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2) =>
        new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        if (r2.Numerator == 0)
            throw new DivideByZeroException("Cannot divide by a rational number with a numerator of zero.");

        return new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
    }

    public static explicit operator double(RationalNumber r) =>
        (double)r.Numerator / r.Denominator;

    public static implicit operator RationalNumber(int value) =>
        new RationalNumber(value, 1);
}