using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Factories
{
    public class CustomerFactory
    {
        private static Database1Entities db = Repositories.Database.GetInstance();
        public static Customer createCustomer(string name, string email, string gender, string address, string password)
        {
            Customer customer = new Customer();
            customer.CustomerName = name;
            customer.CustomerEmail = email;
            customer.CustomerGender = gender;
            customer.CustomerAddress = address;
            customer.CustomerPasword = password;
            customer.CustomerId = (from x in db.Customers select x.CustomerId).ToList().LastOrDefault() + 1;
            customer.CustomerRole = "cust";
            return customer;
        }

        public static Customer createCustomerWithId(int id, string name, string email, string gender, string address, string password)
        {
            Customer customer = new Customer();
            customer.CustomerName = name;
            customer.CustomerEmail = email;
            customer.CustomerGender = gender;
            customer.CustomerAddress = address;
            customer.CustomerPasword = password;
            customer.CustomerId = id;
            customer.CustomerRole = (from x in db.Customers where x.CustomerId == id select x.CustomerRole).FirstOrDefault();
            return customer;
        }
    }
}