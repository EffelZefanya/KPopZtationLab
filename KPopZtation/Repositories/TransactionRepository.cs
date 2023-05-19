using KPopZtation.Factories;
using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Repositories
{
    public class TransactionRepository
    {
        static Database1Entities db = Database.GetInstance();
        public static void addTransactionHeader(int customerId)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader = TransactionFactory.createTransactionHeader(customerId);
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
            return;
            
        }

        public static void addTransactionDetail(int transactionId, int albumId, int qty)
        {
            TansactionDetail transactionDetail = new TansactionDetail();
            transactionDetail = TransactionFactory.createTransactionDetail(transactionId, albumId, qty);
            db.TansactionDetails.Add(transactionDetail);
            db.SaveChanges();
            return;
        }

        public static int getLatestTransactionHeaderIdFromCustomer(int customerId)
        {
            TransactionHeader transactionHeader = (from x in db.TransactionHeaders where x.CustomerId == customerId select x).ToList().LastOrDefault();
            if (transactionHeader == null)
            {
                return 0;
            }
            else
            {
                return transactionHeader.TransactionId;
            }
        }
    }
}