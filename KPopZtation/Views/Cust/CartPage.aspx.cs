using KPopZtation.Models;
using KPopZtation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KPopZtation.Views.Cust
{
    public partial class CartPage : System.Web.UI.Page
    {
        Database1Entities db = Database.GetInstance();
        string userRole = "";
        int customerId;
        protected void Page_Load(object sender, EventArgs e)
        {
            userRole = (string)Session["role"];
            if (userRole != "cust")
            {
                Response.Redirect("Home.aspx");
            }

            Customer cust = (Customer)Session["user"];
            cartGridView.DataSource = CartRepository.getAllCart(cust.CustomerId);
            cartGridView.DataBind();

        }
    }
}