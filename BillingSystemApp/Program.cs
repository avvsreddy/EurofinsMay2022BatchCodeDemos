using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BillingSystem billingSystem = new BillingSystem(TaxCalculatorFactory.Create());
            billingSystem.GenerateBill();
        }
    }


    class  TaxCalculatorFactory
    {
        public static ITaxCalculator Create()
        {

            string taxCalc = ConfigurationManager.AppSettings["TAX"];
            Type theType = Type.GetType(taxCalc);
            return (ITaxCalculator)Activator.CreateInstance(theType);
            //return new APTaxCalculator();
        }
    }

    public class BillingSystem
    {
        private ITaxCalculator taxCalculator = null;

        public BillingSystem(ITaxCalculator taxCalculator)
        {
            this.taxCalculator = taxCalculator;
        }
        public void GenerateBill()
        {
            // calculate the bill amount
            int billAmount = 5600;
            // calculate the tax
            //ITaxCalculator calculator = new APTaxCalculator();
            int tax = taxCalculator.CalculateTax(billAmount);
            // calculate the discount
            // generate the bill
        }
    }

    public interface ITaxCalculator
    {
        int CalculateTax(int amount);
    }

    public class KATaxCalculator : ITaxCalculator
    {
        public int CalculateTax(int amount)
        {
            int totalTax = 0;
            int es = 100;
            int kst = 120;
            int cst = 120;
            int sbt = 50;
            int ft = 75;
            int it = 20;
            totalTax = es + kst + cst + sbt + ft + it;
            Console.WriteLine("Using KA Tax Calculator");
            return totalTax;
        }
    }

    public class APTaxCalculator : ITaxCalculator
    {
        public int CalculateTax(int amount)
        {
            int totalTax = 0;
            int es = 100;
            int kst = 120;
            int cst = 120;
            int sbt = 150;
            int ft = 75;
           
            totalTax = es + kst + cst + sbt + ft ;
            Console.WriteLine("Using AP Tax Calculator");
            return totalTax;
        }
    }

    public class UPTaxCalculator : ITaxCalculator
    {
        public int CalculateTax(int amount)
        {
            int totalTax = 0;
            int es = 100;
            int kst = 120;
            int cst = 120;
            int sbt = 150;
            int ft = 75;

            totalTax = es + kst + cst + sbt + ft;
            Console.WriteLine("Using UP Tax Calculator");
            return totalTax;
        }
    }



}
