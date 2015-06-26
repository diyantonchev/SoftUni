using System;

namespace FractionCalculator
{
    class FractionCalculatorMain
    {
        static void Main()
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            
            Fraction result = fraction1 + fraction2;
            
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);

            Fraction fraction3 = new Fraction(0, 10);
            Fraction fraction4 = new Fraction(5, 10);

            var result2 = fraction3 - fraction4;

            Console.WriteLine(result2.Numerator);
            Console.WriteLine(result2.Denominator);
            Console.WriteLine(result2);
        }
    }
}
