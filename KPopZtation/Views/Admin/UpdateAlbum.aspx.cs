using KPopZtation.Controllers;
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
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request["ID"]);

            currentAlbumGridView.DataSource = AlbumRepositories.GetAlbum(id);
            currentAlbumGridView.DataBind();

        }

        protected void updateAlbumBtn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request["ID"]);

            Album artist = AlbumRepositories.GetAlbum(id);

            FileUpload image = albumImageFile;
            string name = nameTbx.Text;
            string desc = descTbx.Text;
            int price = Convert.ToInt32(priceTbx.Value);
            int stock = Convert.ToInt32(stockTbx.Value);

            errorLbl.ForeColor = System.Drawing.Color.Red;
            errorLbl.Text = AlbumController.doUpdateAlbum(id, name, desc, albumImageFile, price, stock);

            if (errorLbl.Text == "")
            {
                albumImageFile.SaveAs(Server.MapPath("~/Assets/Images/" + albumImageFile.FileName));
                errorLbl.ForeColor = System.Drawing.Color.Green;
                errorLbl.Text = "Artist Updated succesfully";
                Response.Redirect("~/Views/Shared/Home.aspx");
            }
        }
    }
}