using KPopZtation.Handlers;
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
    public partial class AlbumDetail : System.Web.UI.Page
    {
        Database1Entities db = Database.GetInstance();
        int albumId;
        public string userRole = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            albumId = Convert.ToInt32(Request["ID"]);
            userRole = (string)Session["role"];

            AlbumGridView.DataSource = AlbumRepositories.GetAlbumForGridView(albumId);
            AlbumGridView.DataBind();
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            Customer user = (Customer)Session["user"];
            int customerId = user.CustomerId;
            int qty = Convert.ToInt32(qtyTbx.Value);

            CartRepository.addCart(customerId, albumId, qty);
            Response.Redirect("~/Views/Shared/Home.aspx");
        }
    }
}