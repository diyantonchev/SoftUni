using Bank.Accounts;
namespace Bank.Interfaces
{   
    interface IAccount
    {
        Customer Customer { get;}
        
        decimal Balance {get; set;}
    
        double InterestRate { get; set;}

        decimal CalculateInterest(int months);

        decimal Deposit(decimal money);
    }
}
