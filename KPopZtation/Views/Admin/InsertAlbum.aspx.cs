using KPopZtation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KPopZtation.Views.Admin
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertAlbumBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["ID"]);

            FileUpload image = albumImageFile;
            string name = nameTbx.Text;
            string desc = descTbx.Text;
            int price = Convert.ToInt32(priceTbx.Value);
            int stock = Convert.ToInt32(stockTbx.Value);

            errorLbl.ForeColor = System.Drawing.Color.Red;
            errorLbl.Text = AlbumController.doInsertAlbum(id, name, desc, image, price, stock);

            if (errorLbl.Text == "")
            {
                albumImageFile.SaveAs(Server.MapPath("~/Assets/Images/" + albumImageFile.FileName));
                errorLbl.ForeColor = System.Drawing.Color.Green;
                errorLbl.Text = "Album Inserted succesfully";
                Response.Redirect("~/Views/Shared/Home.aspx");
            }
        }
    }
}