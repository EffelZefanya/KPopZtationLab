using KPopZtation.Factories;
using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Repositories
{
    public class CustomerRepository
    {
        private static Database1Entities db = Repositories.Database.GetInstance();
        //add edit get should be here :))
        public static Customer GetCustomer(string email, string password)
        {
            return (from x in db.Customers where x.CustomerEmail.Equals(email) && x.CustomerPasword.Equals(password) select x).FirstOrDefault();//untuk mengambil data pertama yang ditemukan dan selain itu null.
        }

        public static void AddCustomer(string name, string email, string gender, string address, string password)
        {
            Customer customer = CustomerFactory.createCustomer(name, email, gender, address, password);
            db.Customers.Add(customer);
            db.SaveChanges();
        }
    }
}