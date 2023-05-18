using KPopZtation.Controllers;
using KPopZtation.Models;
using KPopZtation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KPopZtation.Views.Shared
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        Database1Entities db = Database.GetInstance();
        Customer customer;
        protected void Page_Load(object sender, EventArgs e)
        {
            customer = (Customer)Session["user"];
            currentProfileGridView.DataSource = CustomerRepository.getCustomerFrorGridView(customer.CustomerId);
            currentProfileGridView.DataBind();

            List<string> genderList = new List<string>();
            genderList.Add("Male");
            genderList.Add("Female");
            genderDDL.DataSource = genderList;
            genderDDL.DataBind();
        }

        protected void updateProfileBtn_Click(object sender, EventArgs e)
        {
            customer = (Customer)Session["user"];

            string name = nameTxt.Text.ToString();
            string gender = genderDDL.SelectedValue.ToString();
            string address = addressTxt.Text.ToString();
            string email = emailTxt.Text.ToString().ToLower();
            string password = passwordTxt.Text.ToString();

            errorLbl.Text = CustomerController.doUpdate(customer.CustomerId, name, email, gender, address, password);
            if (errorLbl.Text.Equals("Customer Account Updated!"))
            {
                Response.Redirect("~/Views/Shared/Home.aspx");
            }
        }
    }
}