using System;

public delegate double CalculateInterest(decimal sum, double interest, int years);

class InterestCalculatorMain
{
    static void Main()
    {
        CalculateInterest simple = GetSimpleInterest;
        CalculateInterest compound = GetCompoundInterest;

        var compoundInterestCalculator = new InterestCalculator(500, 5.6, 10, compound);
        var simpleInterestCalculator = new InterestCalculator(2500, 7.2, 15, simple);

        double simpleInterest = simpleInterestCalculator.Interest;
        double compoundInterest = compoundInterestCalculator.Interest;

        Console.WriteLine(compoundInterest);
        Console.WriteLine(simpleInterest);
    }

    public static double GetSimpleInterest(decimal sum, double interest, int years)
    {
       double simpleInterest = (double)sum * (1 + interest * years);
        return simpleInterest;
    }

    public static double GetCompoundInterest(decimal sum, double interest, int years)
    {
        int n = 12; //number of times per year the interest is compounded.
        double power = years * n;
        double interestForYears = 1;

        for (int i = 1; i <= power; i++)
        {
            interestForYears *= (1 + interest / n);
        }
        
        double compoundInterest = (double)sum * interestForYears;

        return compoundInterest;
    }
}