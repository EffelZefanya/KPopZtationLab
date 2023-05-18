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
        int artistId;
        public string userRole;
        protected void Page_Load(object sender, EventArgs e)
        {
            artistId = Convert.ToInt32(Request["ID"]);
            userRole = (string)Session["role"];

            artistGridView.DataSource = Repositories.ArtistRepository.getArtistForGridView(artistId);
            artistGridView.DataBind();

            AlbumGridView.DataSource = AlbumRepositories.GetAllAlbumsFromArtist(artistId);
            AlbumGridView.DataBind();

            AlbumGridView1.DataSource = AlbumRepositories.GetAllAlbumsFromArtist(artistId);
            AlbumGridView1.DataBind();
        }

        protected void AlbumGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = artistGridView.Rows[e.RowIndex];
            string id = row.Cells[0].Text.ToString();
            int intId = int.Parse(id);

            AlbumRepositories.deleteAlbum(intId);

            artistGridView.DataSource = AlbumRepositories.GetAllAlbums();
            artistGridView.DataBind();
        }


        protected void AlbumGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = AlbumGridView.Rows[e.NewSelectedIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("~/Views/Shared/AlbumDetail.aspx?ID=" + id);
        }

        protected void InsertAlbumBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertAlbum.aspx?ID=" + artistId);
        }

        protected void AlbumGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = AlbumGridView.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("~/Views/Admin/UpdateAlbum.aspx?ID=" + id);
        }

        protected void AlbumGridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = AlbumGridView.Rows[e.NewSelectedIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("~/Views/Shared/AlbumDetail.aspx?ID=" + id);
        }
    }
}