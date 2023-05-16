using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Handlers
{
    public class CustomerHandler
    {
        public static Customer doLogIn(string email, string password)
        {
            Customer customer = Repositories.CustomerRepository.GetCustomer(email, password);
            return customer;
        }

        public static string doRegister(string name, string email, string gender, string address, string password)
        {
            Repositories.CustomerRepository.AddCustomer(name, email, gender, address, password);
            Customer customer = Repositories.CustomerRepository.GetCustomer(email, password);
            return customer != null ? "Customer Account Created!" : "An error occured, account failed to be created.";
        }
    }
}