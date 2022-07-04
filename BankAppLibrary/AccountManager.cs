using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BankAppLibrary
{

    public class AccountManager
    {
        INotification notification = null;
        public AccountManager() // in Production
        {
            notification = new RealNotification();
        }

        public AccountManager(INotification _notification) // in testing
        {
            notification = _notification;
        }
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
            //Notification notification = new Notification();
            notification.SendMail($"Your withdraw is successfull");
            //Notification.SendMail($"Your withdraw is successfull"); // Real


            return fromAcc;

        }


    }


    public interface INotification
    {
        void SendMail(string msg);
    }

    public class RealNotification : INotification // Real
    {
        public void SendMail(string msg)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 465;
            client.Credentials = null;

            MailMessage mailMsg = new MailMessage("frommail@gmail.com","tomail@abc.com");
            mailMsg.Subject = "Bank transaction";
            mailMsg.Body = msg;
            client.Send(mailMsg);

        }
    }
}
