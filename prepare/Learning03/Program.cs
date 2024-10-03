using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine (frac1.GetDecimalValue());
        Console.WriteLine (frac1.GetFractionString());
        frac1.SetBottom(3);
        Console.WriteLine ("new" + frac1.GetDecimalValue());
        Console.WriteLine ("new" + frac1.GetFractionString());

        Fraction frac2 = new Fraction(3);
        Console.WriteLine (frac2.GetDecimalValue());
        Console.WriteLine (frac2.GetFractionString());
        frac2.SetTop(5);
        Console.WriteLine(frac2.GetTop());

        Fraction frac3 = new Fraction (5,20);
        Console.WriteLine (frac3.GetDecimalValue());
        Console.WriteLine (frac3.GetFractionString());

    }
}