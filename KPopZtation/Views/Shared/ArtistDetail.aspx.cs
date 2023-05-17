using KPopZtation.Models;
using KPopZtation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KPopZtation.Views.Admin
{
    public partial class ArtistDetail : System.Web.UI.Page
    {
        Database1Entities db = Database.GetInstance();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request["ID"]);

            artistGridView.DataSource = Repositories.ArtistRepository.getArtistForGridView(id);
            artistGridView.DataBind();

            AlbumGridView.DataSource = AlbumRepositories.GetAllAlbumsFromArtist(id);
            AlbumGridView.DataBind();
        }

        protected void AlbumGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }


        protected void AlbumGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void InsertAlbumBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertAlbum.aspx?ID=" + id);
        }

        protected void AlbumGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}