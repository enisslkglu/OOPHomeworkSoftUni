using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.BankofKurtovoKonare.Account;
using _02.BankofKurtovoKonare.Customer;

namespace _02.BankofKurtovoKonare
{
    class MainBankProgram
    {
        static void Main()
        {
            DepositeAccount accountInfo = new DepositeAccount(CustomerType.Company, 2435m,3.4m);
            accountInfo.WithDrow(150m);
            accountInfo.Deposite(250m);
            accountInfo.CalculateInterest(14);
            Console.WriteLine("Account information\n{0}",accountInfo);
            Console.WriteLine();
            MortgageAccount mortgage = new MortgageAccount(CustomerType.Individual, 35345.23m, 6.5m);
            mortgage.CalculateInterest(14);
            Console.WriteLine("Account information\n{0}", mortgage);
        }
    }
}
