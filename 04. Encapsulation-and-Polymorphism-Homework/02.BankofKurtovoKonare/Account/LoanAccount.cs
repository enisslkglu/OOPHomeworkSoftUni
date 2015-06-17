using _02.BankofKurtovoKonare.Customer;

namespace _02.BankofKurtovoKonare.Account
{
    public class LoanAccount : MainAccount
    {
        public LoanAccount(CustomerType customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int month)
        {
            if (this.Customer == CustomerType.Individual && month < 3)
            {
                return 0;
            }
            else if (this.Customer == CustomerType.Company && month < 2)
            {
                return 0;
            }
            return this.InterestRate = this.Balance*(1 + this.InterestRate*month);
        }


    }
}