using System;

public class Fraction
{
    private readonly int _numerator;
    private readonly int _denominator;

    public Fraction() : this(1, 1)
    {
    }

    public Fraction(int wholeNumber) : this(wholeNumber, 1)
    {
    }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        int gcd = Gcd(numerator, denominator);

        _numerator = numerator / gcd;
        _denominator = denominator / gcd;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }

    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }
}
