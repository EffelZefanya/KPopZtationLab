using KPopZtation.Models;
using KPopZtation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Factories
{
    public class TransactionFactory
    {
        static Database1Entities db = Database.GetInstance();
        public static TransactionHeader createTransactionHeader(int customerId)
        {
            TransactionHeader firstTransactionHeader = (from x in db.TransactionHeaders select x).FirstOrDefault();
            TransactionHeader transactionHeader = new TransactionHeader();
            if (firstTransactionHeader == null)
            {
                transactionHeader.TransactionId = 1;
            }
            else
            {
                transactionHeader.TransactionId = (from x in db.TransactionHeaders select x.TransactionId).LastOrDefault() + 1;
            }
            transactionHeader.TransactionDate = DateTime.Today;
            transactionHeader.CustomerId = customerId;
            return transactionHeader;
        }

        public static TansactionDetail createTransactionDetail(int transactionId, int albumId, int qty)
        {
            TansactionDetail transactionDetail = new TansactionDetail();
            transactionDetail.TransactionId = transactionId;
            transactionDetail.AlbumId = albumId;
            transactionDetail.Qty = qty;
            return transactionDetail;
        }
    }
}