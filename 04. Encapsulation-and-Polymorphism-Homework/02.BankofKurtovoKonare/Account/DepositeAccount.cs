using System;
using _02.BankofKurtovoKonare.Customer;

namespace _02.BankofKurtovoKonare.Account
{
    public class DepositeAccount : MainAccount
    {
        public DepositeAccount(CustomerType customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int month)
        {
            if (this.Balance < 1000)
            {
                Console.WriteLine("Balance is smaller than 1000.There has no interest rate!");
                return 0;
            }
            return this.InterestRate = this.Balance*(1 + this.InterestRate*month);
        }

        public void WithDrow(decimal money)
        {
            this.Balance -= money;
        }

        public void Deposite(decimal money)
        {
            this.Balance += money;
        }
    }
}