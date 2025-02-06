using System;

namespace Learning03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction(6);
            Fraction fraction3 = new Fraction(6, 7);

            Console.WriteLine(fraction1.GetFractionString());
            Console.WriteLine(fraction1.GetDecimalValue());

            Console.WriteLine(fraction2.GetFractionString());
            Console.WriteLine(fraction2.GetDecimalValue());

            Console.WriteLine(fraction3.GetFractionString());
            Console.WriteLine(fraction3.GetDecimalValue());

            fraction1.SetTop(5);
            fraction1.SetBottom(2);
            Console.WriteLine(fraction1.GetFractionString());
            Console.WriteLine(fraction1.GetDecimalValue());
        }
    }
}
