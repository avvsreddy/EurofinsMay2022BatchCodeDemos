using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();
            Customer c4 = new Customer();
            Customer c5 = new Customer();
            RegCustomer rc1 = new RegCustomer();
            RegCustomer rc2 = new RegCustomer();
            RegCustomer rc3 = new RegCustomer();

            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);
            customers.Add(rc1);
            customers.Add(rc2);
            customers.Add(rc3);

            // How many customers?
            Console.WriteLine($"Total customers: {customers.Count}");
            int custCount = 0;
            int regCustCount = 0;
            //foreach (Customer customer in customers)
            //{
            //    //if (customer is Customer)
            //    //    custCount++;
            //    //else 
            //    if (customer is RegCustomer)
            //        regCustCount++;
            //}

            int rc = customers.OfType<RegCustomer>().Count();

            int regcust = (from c in customers.OfType<RegCustomer>()
                           select c).Count();

            Console.WriteLine($"Normal customer count: {custCount}");
            Console.WriteLine($"Reg Customer count: {rc}");



        }
    }

    class Customer
    {
        public string Name { get; set; }

    }

    class RegCustomer : Customer
    {
        public int Discount { get; set; }
    }
}
