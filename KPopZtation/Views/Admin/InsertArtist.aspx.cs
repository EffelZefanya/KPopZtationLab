﻿using KPopZtation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KPopZtation.Views.Admin
{
    public partial class InsertArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            FileUpload image = artistImgFile;
            string name = ArtistNameTb.Text;

            errorLbl.ForeColor = System.Drawing.Color.Red;
            errorLbl.Text = ArtistController.doInsertArtist(name, image);

            if(errorLbl.Text == "")
            {
                artistImgFile.SaveAs(Server.MapPath("~/Assets/Images/" + artistImgFile.FileName));
                artistImg.ImageUrl = "~/Assets/Images/" + artistImgFile.FileName;
                    errorLbl.ForeColor = System.Drawing.Color.Green;
                errorLbl.Text = "Artist Inserted succesfully";
                Response.Redirect("~/Views/Shared/Home.aspx");
            }
        }
    }
}