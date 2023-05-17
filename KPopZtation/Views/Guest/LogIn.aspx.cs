using KPopZtation.Controllers;
using KPopZtation.Handlers;
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
        public string userRole = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            userRole = (string) Session["role"];
            if(userRole != null)
            {
                Response.Redirect("~/Views/Shared/Home.aspx");
            }
        }

        protected void logInButton_Click(object sender, EventArgs e)
        {
            string email = emailBox.Value;
            string password = passwordBox.Value;
            bool isRemember = rememberMe.Checked;

            Customer user = CustomerController.doLogIn(email, password);

            if(user != null)
            {
                Session["user"] = user;
                Session["role"] = user.CustomerRole;
                //session bisa langsung menyimpan object
                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.CustomerId.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                    

                    HttpCookie roleCookie = new HttpCookie("role_cookie");
                    roleCookie.Value = user.CustomerRole;
                    roleCookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(roleCookie);

                    /*Untuk cek apakah si cookie ada atau engga. Buka chrome->inpsect->application->storage->cookies*/
                }
                
                /*
                if (Application["count_user"] == null)
                {
                    Application["count_user"] = 1;
                }
                else
                {
                    Application["count_user"] = ((int)Application["count_user"]) + 1;
                }
                */

                Response.Redirect("~/Views/Shared/Home.aspx");
            }
            else
            {
                error.Text = "Email or Password is incorrect";
            }
        }
    }
}