using System;

class Worker : Human
{
    private double weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, double weekSalaray, double workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalaray;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public double WeekSalary
    {
        get { return this.weekSalary; }

        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The salary cannot be negative.");
            this.weekSalary = value;
        }
    }

    public double WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }

        set
        {
            if (value < 0 || value > 16)
                throw new ArgumentOutOfRangeException("Invalid working time.");
            this.workHoursPerDay = value;
        }
    }

    public double MoneyPerHour()
    {
        double moneyPerHour = this.weekSalary / (this.workHoursPerDay * 6); // one day off

        return moneyPerHour;
    }
}