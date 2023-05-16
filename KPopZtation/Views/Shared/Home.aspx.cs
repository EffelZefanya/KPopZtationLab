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
    public partial class Home : System.Web.UI.Page
    {
        public static Database1Entities db = Repositories.Database.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            artistGridView.DataSource = Repositories.ArtistRepository.getAllArtist();
            artistGridView.DataBind();
        }

        protected void artistGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = artistGridView.Rows[e.RowIndex];
            string id = row.Cells[0].Text.ToString();
            int intId = Convert.ToInt32(id);

            ArtistRepository.deleteArtist(intId);

            artistGridView.DataSource = Repositories.ArtistRepository.getAllArtist();
            artistGridView.DataBind();
        }

        protected void artistGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = artistGridView.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("~/Views/Admin/UpdateArtist.aspx?ID="+id);
        }
    }
}