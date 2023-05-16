using KPopZtation.Models;
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
            List<Artist> artists = Repositories.ArtistRepository.getAllArtist();

            artistGridView.DataSource = artists;
            artistGridView.DataBind();
        }

    }
}