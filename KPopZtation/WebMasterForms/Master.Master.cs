using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KPopZtation.WebMasterForms
{
    public partial class Guest : System.Web.UI.MasterPage
    {
        public string userRole = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            userRole = (String) Session["role"];
        }

        protected void LogOutBtn_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;

            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            Session.Remove("user");
            Session.Remove("role");
            Response.Redirect("~/Views/Guest/LogIn.aspx");
        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Shared/Home.aspx");
        }

        protected void updateProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Shared/UpdateProfile.aspx");
        }

        protected void transactionBtn_Click(object sender, EventArgs e)
        {

        }

        protected void LogInBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Guest/LogIn.aspx");
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Guest/Register.aspx");
        }
    }
}