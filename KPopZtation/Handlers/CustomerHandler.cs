using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Handlers
{
    public class CustomerHandler
    {
        public static string doLogIn(string email, string password)
        {
            Customer customer = Repositories.CustomerRepository.GetCustomer(email, password);
            return customer != null ? "Success" : "Email or Password is incorrect";
        }
    }
}