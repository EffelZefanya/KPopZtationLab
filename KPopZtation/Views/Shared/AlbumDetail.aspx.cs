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
        int id;
        string userRole = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request["ID"]);
            userRole = (string)Session["role"];

            AlbumGridView.DataSource = AlbumRepositories.GetAllAlbumsFromArtist(id);
            AlbumGridView.DataBind();
        }
    }
}