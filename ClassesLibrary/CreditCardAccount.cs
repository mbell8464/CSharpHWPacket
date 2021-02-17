using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //fields

        //properties
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }
        //constructors
        public CreditCardAccount()
        {

        }

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        //methods

        public override string ToString()
        {
            return string.Format($"The account number for {CustomerInfo.FirstName} " + $"{CustomerInfo.LastName} is {AccountNumber}.\nBalance: {Balance}\nPast Due? {IsPastDue}\nYour annual interest rate: {AnnualInterestRate}%\n");
        }

    }
}
