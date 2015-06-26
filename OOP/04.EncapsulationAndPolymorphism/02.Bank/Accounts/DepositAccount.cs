namespace Bank.Accounts
{
    using System;

    class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, double interestRate)
            :base (customer,balance, interestRate)
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
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return interest;
            }
            interest = this.Balance * (1 + (decimal)interestRate * months);

            return interest;
        }

        public decimal Withdraw(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentOutOfRangeException("Money cannot be negative or zero.");
            }
            this.Balance -= money;
            return money;
        }
    }
}
