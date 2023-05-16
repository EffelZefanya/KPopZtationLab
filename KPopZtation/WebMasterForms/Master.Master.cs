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
    }
}