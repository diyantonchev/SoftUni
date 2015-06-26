using System;
using System.Collections.Generic;
using System.Linq;
using Bank.Interfaces;
using Bank.Accounts;

namespace Bank
{
    class BankMain
    {
        static void Main()
        {
            var bajPesho = Customer.Individual;
            var leliaMarche = Customer.Individual;
            var mrAnderson = Customer.Individual;

            var google = Customer.Company;
            var microsoft = Customer.Company;
            var facebook = Customer.Company;

            var bajPeshoAccount = new DepositAccount(bajPesho, 200, 7);
            var leliaMarcheAccount = new MortgageAccount(leliaMarche, 200, 7);
            var mrAndersonAccount = new LoanAccount(mrAnderson, 200, 7);

            var googleAccount = new DepositAccount(google, 200, 7);
            var microsoftAccount = new MortgageAccount(microsoft, 200, 7);
            var facebookAccount = new LoanAccount(facebook, 200, 7);

            googleAccount.Withdraw(100);
           // Console.WriteLine(googleAccount.Balance);
            facebookAccount.Deposit(100);
           // Console.WriteLine(facebookAccount.Balance);

            var accounts = new List<IAccount>() 
            {
                googleAccount, 
                microsoftAccount,
                facebookAccount,
                bajPeshoAccount,
                leliaMarcheAccount,
                mrAndersonAccount 
            };

            var sortedAccounts = accounts.OrderByDescending(account => account.Balance);
            
            foreach (var account in sortedAccounts)
            {
                decimal interestFirstMonths = account.CalculateInterest(3);
                decimal interest = account.CalculateInterest(13);

                Console.WriteLine("customer: {0} - balance: {1}; first months interest: {2}; interest: {3}"
                    , account.Customer, account.Balance, interestFirstMonths, interest);
            }
        }
    }
}
