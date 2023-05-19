using KPopZtation.Models;
using KPopZtation.Repositories;
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

        public static string doUpdate(int id, string name, string email, string gender, string address, string password)
        {
            Repositories.CustomerRepository.updateCustomer(id, name, email, gender, address, password);
            Customer customer = Repositories.CustomerRepository.GetCustomer(email, password);
            return customer != null ? "Customer Account Updated!" : "An error occured, account failed to be created.";
        }

        public static string doCheckOut(int customerId)
        {
            List<Cart> carts = CartRepository.getAllCart(customerId);
            TransactionRepository.addTransactionHeader(customerId);
            int transactionHeaderId = TransactionRepository.getLatestTransactionHeaderIdFromCustomer(customerId);
            if(transactionHeaderId == 0)
            {
                return "the transactionHeader isn't created";
            }
            foreach (Cart cart in carts)
            {
                TransactionRepository.addTransactionDetail(transactionHeaderId, cart.AlbumId, cart.Qty);
            }
            CartRepository.removeSomeCarts(customerId);
            return "succesfully created transaction";
        }

    }
}