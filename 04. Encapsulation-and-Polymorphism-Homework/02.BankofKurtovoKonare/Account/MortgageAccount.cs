using _02.BankofKurtovoKonare.Customer;

namespace _02.BankofKurtovoKonare.Account
{
    public class MortgageAccount : MainAccount
    {
        public MortgageAccount(CustomerType customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int month)
        {
            if (this.Customer == CustomerType.Company && month < 12)
            {
                return this.InterestRate = (this.Balance*(1 + this.InterestRate*month)/2);
            }
            else if (this.Customer == CustomerType.Individual && month < 6)
            {
                return 0;
            }
            return InterestRate = this.Balance*(1 + this.InterestRate*month);
        }
    }
}