using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do some withdraw
            try
            {
                Account acc1 = new Account { AccNo = 12345678, Balance = 10000, Pin = 1234 };
                Account acc2 = new Account { AccNo = 34534534, Balance = 5000, Pin = 5674 };

                AccountManager mgr = new AccountManager();
                mgr.Withdraw(acc1, 1000, 12349);
                Console.WriteLine("Withdraw is succssfully done");
            }
            catch (InsufficcientBalanceException ex1)
            {
                // log -> nlog, serilog, 
                Console.WriteLine(ex1.Message);
            }
            catch (IncorrectPinException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (InvalidAmountException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
        }
    }


    class Account
    {
        public int AccNo { get; set; }
        public int Balance { get; set; }

        public int Pin { get; set; }
    }

    class AccountManager
    {
        public void Deposit(Account account, int amount)
        {
            // minimum amount is 1000 otherwise throw exp
            if (amount < 1000)
                throw new InvalidAmountException("Minimum deposit amount is 1000");

            account.Balance += amount;

        }
        /// <summary>
        /// Withdraw amount from an account
        /// </summary>
        /// <param name="account">from account</param>
        /// <param name="amount">amount</param>
        /// <param name="pin">account pin</param>
        /// <exception cref="InvalidAmountException"></exception>
        /// <exception cref="InsufficcientBalanceException"></exception>
        /// <exception cref="IncorrectPinException"></exception>
        public void Withdraw(Account account, int amount, int pin)
        {
            try
            {
                // check minimum amount is 100
                if (amount < 100)
                    throw new InvalidAmountException("Minimum withdraw amount is 100");
                // check sufficcient balance
                if (account.Balance < amount)
                    throw new InsufficcientBalanceException("you have no sufficcient balance");
                // check the pin
                if (account.Pin != pin)
                {
                    throw new IncorrectPinException("Provided pin is incorret");
                }
 account.Balance -= amount;
            }
               
            
            catch (Exception ex)
            {
                // 1. log
                // 2. admin
                // 3. conversion
                // 4. must rethrow
                throw ex;
            }
        }

        public void Transfer(Account fromAcc, Account toAcc, int amount, int pin)
        {
            // check minimum amount is 500
            if (amount < 500)
                throw new InvalidAmountException("Minimum transfer amount is 500");
            // check sufficcient balance in from account
            // check the pin of from acc
            this.Withdraw(fromAcc, amount,pin);
            this.Deposit(toAcc, amount);

        }
    }

    class InvalidAmountException : ApplicationException
    {
        public InvalidAmountException(string msg):base(msg)
        {

        }
    }

    class InsufficcientBalanceException : ApplicationException
    {
        public InsufficcientBalanceException(string msg):base(msg)
        {

        }
    }
    class IncorrectPinException : ApplicationException
    {
        public IncorrectPinException(string msg) : base(msg)
        {

        }
    }
}
