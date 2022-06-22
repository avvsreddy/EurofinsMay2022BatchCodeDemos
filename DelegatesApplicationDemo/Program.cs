using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplicationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.notification += Alert.SendMail; // subscribe
            //acc1.Subscribe(Alert.SendMail);
            //acc1.Subscribe(Alert.SendSMS);
            acc1.notification += Alert.SendSMS; // subscribe
            //acc1.notification.Invoke("EMAIL : Your account has been deposited $999999999999999999999");
            acc1.Deposit(1000);
            //acc1.Withdraw(100);
        }
    }

    class Account
    {
        public int Balance { get; private set; }
        public event Notification notification = null; //new Notification(Alert.SendMail);


        //public void Subscribe(Notification n)
        //{
        //    notification += n;
        //}

        //public void Unsubscribe(Notification n)
        //{
        //    notification -= n;
        //}
        public void Deposit(int amount)
        {
            Balance += amount;
            if (notification != null)
            {
                notification($"Deposited : {amount}");
            }
            //Alert.SendMail($"Deposited : {amount}");
            //Alert.SendSMS($"Deposited : {amount}");
            //Console.WriteLine($"EMAIL - Deposited : {amount}");
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
            if (notification != null)
            {
                notification($"Withdran:{ amount}");
            }
            //Console.WriteLine($"EMAIL - Withdran :{amount}");
            //Alert.SendMail($"Withdran:{ amount}");
            //Alert.SendSMS($"Withdran:{ amount}");
        }
    }

    // declare a delegate
    delegate void Notification(string str);


    class Alert
    {
        public static void SendMail(string msg)
        {
            Console.WriteLine("Email: " + msg);
        }

        public static void SendSMS(string msg)
        {
            Console.WriteLine("SMS :" + msg);
        }
    }
}
