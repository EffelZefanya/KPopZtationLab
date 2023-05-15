using KPopZtation.Controllers;
using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KPopZtation.Views.Guest
{
    public partial class Register : System.Web.UI.Page
    {
        Database1Entities db = Repositories.Database.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> genderList = new List<string>();
            genderList.Add("Male");
            genderList.Add("Female");
            genderDDL.DataSource = genderList;
            genderDDL.DataBind();
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text.ToString();
            string gender = genderDDL.SelectedValue.ToString();
            string address = addressTxt.Text.ToString();
            string email = emailTxt.Text.ToString().ToLower();
            string password = passwordTxt.Text.ToString();

            errorLbl.Text = CustomerController.doRegister(name, email, gender, address, password);
            if (errorLbl.Text.Equals(""))
            {
                Response.Redirect("LogIn.aspx");
            }
        }

    }
}