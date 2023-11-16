using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();

        string frac1string = fraction1.GetFractionString();

        Console.WriteLine(frac1string);

        double frac1double = fraction1.GetDecimalValue();

        Console.WriteLine(frac1double.ToString("0.#"));

        Fraction fraction2 = new Fraction(5);

        string frac2string = fraction2.GetFractionString();

        Console.WriteLine(frac2string);

        double frac2double = fraction2.GetDecimalValue();

        Console.WriteLine(frac2double.ToString("0.#"));

        Fraction fraction3 = new Fraction(3, 4);

        string frac3string = fraction3.GetFractionString();

        Console.WriteLine(frac3string);

        double frac3double = fraction3.GetDecimalValue();

        Console.WriteLine(frac3double.ToString("F2"));
    }
}