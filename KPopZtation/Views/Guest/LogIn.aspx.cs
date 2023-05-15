using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KPopZtation.Views.Guest
{
    public partial class LogIn : System.Web.UI.Page
    {
        private Database1Entities db = Repositories.Database.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logInButton_Click(object sender, EventArgs e)
        {
            string email = emailBox.Value;
            string password = passwordBox.Value;
            bool isRemember = rememberMe.Checked;

            var user = (from x in db.Customers where x.CustomerEmail.Equals(email) && x.CustomerPasword.Equals(password) select x).FirstOrDefault();//untuk mengambil data pertama yang ditemukan dan selain itu null.

            if(user != null)
            {
                Session["user"] = user;
                //session bisa langsung menyimpan object
                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.CustomerId.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);

                    /*Untuk cek apakah si cookie ada atau engga. Buka chrome->inpsect->application->storage->cookies*/
                }

                if (Application["count_user"] == null)
                {
                    Application["count_user"] = 1;
                }
                else
                {
                    Application["count_user"] = ((int)Application["count_user"]) + 1;
                }

                Response.Redirect("GuestHome.aspx");
            }
            else
            {
                error.Text = "User not found";
            }
        }
    }
}