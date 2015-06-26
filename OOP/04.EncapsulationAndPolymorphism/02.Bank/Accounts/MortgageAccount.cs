using System;
namespace Bank.Accounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, double interestRate)
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
            decimal interestForCompanies = 0;
            decimal interestForIndividuals = 0;

            if (this.Customer == Customer.Individual)
            {
                if (months <= 6)
                {
                    return interestForIndividuals;
                }
                else
                {
                    interestForIndividuals = this.Balance * (1 + (decimal)interestRate *( months - 6));

                    return interestForIndividuals;
                }

            }
            else 
            {
                interest = this.Balance * (1 + (decimal)interestRate * months);
                interestForCompanies = interest / 2;
                
                if (months <= 12)
                {      
                    return interestForCompanies;
                }
                else
                {
                    interest = this.Balance * (1 + (decimal)interestRate * ( months - 12 )) + interestForCompanies;
                    return interest;
                }
            }
        }
    }
}
