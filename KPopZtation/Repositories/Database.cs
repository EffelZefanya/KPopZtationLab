using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KPopZtation.Models;
namespace KPopZtation.Repositories
{
    public class Database
    {
        private static Database1Entities db = null;

        private Database()
        {

        }

        public static Database1Entities GetInstance()
        {
            if (db == null)
            {
                db = new Database1Entities();
            }
            return db;
        }
    }
}