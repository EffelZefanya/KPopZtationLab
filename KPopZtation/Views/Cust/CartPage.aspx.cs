using KPopZtation.Handlers;
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

        protected void cartGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = cartGridView.Rows[e.RowIndex];
            Customer currentCustomer = (Customer) Session["user"];
            int customerId = currentCustomer.CustomerId;
            int albumId = Convert.ToInt32(row.Cells[0].Text.ToString());

            CartRepository.removeCart(customerId, albumId);
            cartGridView.DataSource = CartRepository.getAllCart(currentCustomer.CustomerId);
            cartGridView.DataBind();
        }

        protected void checkOutBtn_Click(object sender, EventArgs e)
        {
            Customer currentCustomer = (Customer)Session["user"];
            int customerId = currentCustomer.CustomerId;
            errorLbl.Text = CustomerHandler.doCheckOut(customerId);
            cartGridView.DataSource = CartRepository.getAllCart(currentCustomer.CustomerId);
            cartGridView.DataBind();
            Response.Redirect("~/Views/Shared/Home.aspx");
        }
    }
}