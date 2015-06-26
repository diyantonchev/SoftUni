namespace Bank.Accounts
{
    using System;
    using Interfaces;

   public abstract class Account : IAccount
    {
      // private const decimal MinStartBalance = 0;

       private readonly Customer customer;
       private decimal balance;
       private double interestRate;

       public Account(Customer customer, decimal balance, double interestRate)
       {
           this.customer = customer;
           this.Balance = balance;
           this.InterestRate = interestRate;
       }

       public Customer Customer 
       {
           get { return this.customer; }
       }

       public decimal Balance 
       {
           get { return this.balance; }
           
           set
           {
               //if (value < MinStartBalance)
               //    throw new ArgumentOutOfRangeException("value", "Start balance cannot be negative.");
               this.balance = value;
           }
       }

       public double InterestRate 
       {
           get { return this.interestRate; }
           
           set
           {
               if (value < 0)
                   throw new ArgumentOutOfRangeException("value", "Interest rate cannot be negative.");
               this.interestRate = value;
           }
       }

       public abstract decimal CalculateInterest(int months);

       public decimal Deposit(decimal money)
       {
           this.Balance += money;

           return this.Balance;
       }
    }
}
