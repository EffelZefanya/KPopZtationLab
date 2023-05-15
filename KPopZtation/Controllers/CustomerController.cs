using KPopZtation.Handlers;
using KPopZtation.Models;
using KPopZtation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace KPopZtation.Controllers
{
    public class CustomerController
    {
        private static Database1Entities db = Repositories.Database.GetInstance();
        public static string checkName(string name)
        {
            string response = "";
            if (name.Equals(""))
            {
                response = "Name can't be empty";
            }
            else if (name.Length < 5 && name.Length > 50)
            {
                response = "Name must be more than 5 characters and less than 50 characters";
            }
            return response;
        }

        public static string checkPassword(string password)
        {
            string response = "";
           if (password.Equals(""))
            {
                response = "Password can't be empty";
            }else if(!Regex.IsMatch(password, "^[a-zA-Z0-9]*$"))
            {
                response = "Password must be alphanumeric";
            }
            return response;
        }

        public static string checkEmail(string email)
        {
            string response = "";
            if(email.Equals(""))
            {
                response = "email can't be empty";
            }else if((from x in db.Customers where x.CustomerEmail == email select x).FirstOrDefault() != null)
            {
                response = "Email's already registered, please register with a new unique email";
            }
            return response;
        }

        public static string checkGender(string gender)
        {
            string response = "";
            if (gender.Equals(""))
            {
                response = "email can't be empty";
            }
            return response;
        }

        public static string checkAddress(string address)
        {
            string response = "";
            if (address.Equals(""))
            {
                response = "Address can't be null";
            }else if(address.EndsWith("Street") != true)
            {
                response = "Address must end with 'Street' with capital 'S'";
            }
            return response;
        }

        public static string doLogIn(string name, string password)
        {
            string response = checkName(name);
            if (response.Equals(""))
            {
                response = checkPassword(password);
            }
            if (response.Equals(""))
            {
                response = CustomerHandler.doLogIn(name, password);
            }
            return response;
        }

        public static string doRegister(string name, string email, string gender, string address, string password)
        {
            string response = checkName(name);
            if (response.Equals(""))
            {
                response = checkGender(gender);
            }
            if (response.Equals(""))
            {
                response = checkAddress(address);
            }
            if (response.Equals(""))
            {
                response = checkEmail(email);
            }
            if (response.Equals(""))
            {
                response = checkPassword(password);
            }
            if (response.Equals(""))
            {
                CustomerRepository.AddCustomer(name, email, gender, address, password);
            }
            return response;
        }

    }
}