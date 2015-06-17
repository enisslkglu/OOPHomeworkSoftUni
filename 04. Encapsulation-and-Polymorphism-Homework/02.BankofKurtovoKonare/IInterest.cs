using System.Dynamic;
using _02.BankofKurtovoKonare.Customer;

namespace _02.BankofKurtovoKonare
{
    public interface IInterest
    {
        decimal CalculateInterest(int month);
        CustomerType Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
        
    }
}