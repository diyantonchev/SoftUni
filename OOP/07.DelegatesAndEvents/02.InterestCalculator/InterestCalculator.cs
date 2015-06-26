using System;

class InterestCalculator
{
    private decimal money;
    private double interestRate;
    private int years;
    private CalculateInterest calculateInterest;

    public InterestCalculator(decimal money, double interestRate, int years, CalculateInterest calculateInterest)
    {
        this.Money = money;
        this.Years = years;
        this.InterestRate = interestRate;
        this.CalculateInterest = calculateInterest;
    }

    public double Interest
    {
        get 
        {
            return this.Calculator(this.CalculateInterest);
        }
    }

    public decimal Money
    {
        get { return this.money; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value", "Sum of money cannot be negative");
            }
            this.money = value;
        }
    }

    public int Years
    {
        get { return this.years; }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Years cannot be negative or zero.");
            }
            this.years = value;
        }
    }

   public double InterestRate 
    {
        get { return this.interestRate; }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Interest rate cannot be negative or zero.", "value"); 
            }
            this.interestRate = value / 100;
        }
    }

    private CalculateInterest CalculateInterest
    {
        get { return this.calculateInterest; }

        set { this.calculateInterest = value; }
    }

    private double Calculator(CalculateInterest calculateInterest)
    {
        double interest = calculateInterest(this.Money, this.InterestRate, this.Years);
        return Math.Round(interest, 4);
    }
}