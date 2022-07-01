using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppLibrary
{

    public class AccountManager
    {
        public Account Withdraw(Account fromAcc, int amount, int pin)
        {
            // 1. account should be active - opened
            if (!fromAcc.IsActive)
                throw new AccountInactiveException("Account is closed or not active");
            // 2. pin must match
            if (fromAcc.Pin != pin)
                throw new InvalidPinException("Incorrect Pin");
            // 3. sufficcient balance
            if (fromAcc.Balance < amount)
                throw new InssucciffientBalanceException("You have not balance in your account");
            // 4. update the transaction date
            fromAcc.TransactionDate = System.DateTime.Now;
            // 5. reduce the balance
            fromAcc.Balance -= amount;
            return fromAcc;

        }


    }
}
