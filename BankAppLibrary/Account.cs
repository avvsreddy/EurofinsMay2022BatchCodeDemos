using System;

namespace BankAppLibrary
{
    public class Account
    {
        //An Account has accno, name, balance, pin number, isActive openingDate and 
        //closingDate properties
        public int AccNo { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int Pin { get; set; }
        public bool IsActive { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
