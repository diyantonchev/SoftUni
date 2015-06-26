using System;

namespace Bank.Accounts
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("Months cannot be negative or zero.");
            }
            double interestRate = this.InterestRate / 100;
            decimal interest = 0;

            if (this.Customer == Customer.Company)
            {
                if (months <= 3)
                {
                    return interest;
                }
                else
                {
                    interest = this.Balance * (1 + (decimal)interestRate * (months - 3));
                    return interest;
                }
            }
            else
            {
                if (months <= 2)
                {
                    return interest;
                }
                else
                {
                    interest = this.Balance * (1 + (decimal)interestRate * (months - 2));
                    return interest;
                }
            }
        }
    }
}
