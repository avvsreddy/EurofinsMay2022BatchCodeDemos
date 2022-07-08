using EFCodeFirstDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Manage my contacts
            // add new contact
            //Contact c = new Contact { Name = "Dhoni", Email = "dhoni@bcci.in", Location = "Mumbai", Mobile = "234234234" };
            ContactsDbContext db = new ContactsDbContext();
            db.Database.Log = Console.WriteLine;
            //db.Contacts.Add(c);
            //db.SaveChanges();

            var contacts = db.Contacts;
            foreach (var c in contacts)
            {
                Console.WriteLine(c.Name);
            }

        }
    }
}
