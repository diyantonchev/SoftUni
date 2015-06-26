using System;
using System.Numerics;

namespace FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) :
            this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }

            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get { return this.denominator; }

            set
            {
                if (value < 0)
                    throw new DivideByZeroException("Denominator cannot be zero.");
                this.denominator = value;
            }
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            long numerator = fr1.Numerator * fr2.Denominator - fr2.Numerator * fr1.Denominator;
            long denominator = fr1.denominator * fr2.Denominator;
            
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            long numerator = fr1.Numerator * fr2.Denominator + fr2.Numerator * fr1.Denominator;
            long denominator = fr1.denominator * fr2.Denominator;

            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            decimal fraction = (decimal)this.Numerator / this.Denominator;

            return fraction.ToString();
        }
    }
}
