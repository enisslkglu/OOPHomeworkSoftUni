using System;
using System.Text;
using _02.BankofKurtovoKonare.Customer;

namespace _02.BankofKurtovoKonare.Account
{
    public abstract class MainAccount : IInterest
    {
        private CustomerType customer;
        private decimal balance;
        private decimal interestRate;
        public MainAccount(CustomerType customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public CustomerType Customer { get; set; }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value","Balance cannot be negative!");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate","Interest rate cannot be negative!");
                }
                this.interestRate = value;
            }
        }
        
        public abstract decimal CalculateInterest(int month);

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Account type: {0}\nCustomer type: {1}", this.GetType().Name, this.Customer));
            result.AppendLine(string.Format("Balance: {0:F2}\nInterest rate: {1:F2}", this.Balance, this.InterestRate));
            return result.ToString();
        }
    }
}