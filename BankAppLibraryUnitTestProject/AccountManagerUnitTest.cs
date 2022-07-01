using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAppLibrary;

namespace BankAppLibraryUnitTestProject
{
    [TestClass]
    public class AccountManagerUnitTest
    {
        Account a = null;
        AccountManager target = null;


        [TestInitialize]
        public void Initialize()
        {
            a = new Account { AccNo = 111, Balance = 5000, IsActive = true, Pin = 1234 };
            target = new AccountManager();
        }

        [TestCleanup]
        public void Cleanup()
        {
            a = null;
            target = null;
        }

        [TestMethod]
        // Feature_What_Result
        public void WithdrawTest_OnSuccess_BalanceShouldReduce() // Test Case
        {

            target.Withdraw(a, 1000, 1234);
            Assert.AreEqual(4000, a.Balance);
        }

        [TestMethod]
        public void WithdrawTest_OnSuccess_TransactionDateShouldUpdate()
        {
            target.Withdraw(a, 1000, 1234);
            Assert.AreEqual(DateTime.Now, a.TransactionDate);
        }

        [TestMethod]
        [ExpectedException(typeof(AccountInactiveException))]
        public void WithdrawTest_WithInactiveAccount_ThrowsExp()
        {
            a.IsActive = false;
            target.Withdraw(a, 1000, 1234);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPinException))]
        public void WithdrawTest_WithIncorrectPin_ThrowsExp()
        {
            target.Withdraw(a, 1000, 5678);
        }

        [TestMethod]
        [ExpectedException(typeof(InssucciffientBalanceException))]
        public void WithdrawTest_WithInsufficcientBalance_ThrowsExp()
        {
            target.Withdraw(a, 10000, 1234);
        }

    }
}
