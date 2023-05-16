using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KPopZtation.Views.Guest
{
    public partial class GuestHome : System.Web.UI.Page
    {
        private Database1Entities db = Repositories.Database.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            listUserContainer.Visible = false;
            if(Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                Customer user;
                if(Session["user"] == null)
                {
                    var id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    user = (from x in db.Customers where x.CustomerId == id select x).FirstOrDefault();
                    Session["user"] = user;

                }
                else
                {
                    user = (Customer) Session["user"];
                }
                name.Text = user.CustomerName;

                if(Application["count_user"] != null)
                {
                    userLoggedInCount.Text = Application["count_user"] + " user(s) online";
                }

                if (user.CustomerRole.Equals("admin"))
                {
                    listUserContainer.Visible = true;

                    var u = (from x in db.Customers select x);

                    foreach(var x in u)
                    {
                        listUser.Items.Add(x.CustomerName);
                    }
                }
            }
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;

            foreach(string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            Application["count_user"] = ((int)Application["count_user"]) - 1;
            Session.Remove("user");
            Response.Redirect("LogIn.aspx");
        }
    }
}