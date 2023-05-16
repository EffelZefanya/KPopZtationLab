using KPopZtation.Models;
using KPopZtation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KPopZtation.Controllers
{
    public class ArtistController
    {
        private static Database1Entities db = Repositories.Database.GetInstance();
        public static string checkName(string name)
        {
            string response = "";
            if (name.Equals(""))
            {
                response = "Artis's name can't be empty";
            }else if ((from x in db.Artists where x.ArtistName.Equals(name) select x).FirstOrDefault() != null)
            {
                response = "Please input a new unique Artis's mame";
            }
            return response;
        }

        public static string checkImage(FileUpload image)
        {
            string response = "";
            if (!image.HasFile && response == "")
            {
                response = "Please input an image file for the artist";
            }
            string fileExtension = System.IO.Path.GetExtension(image.FileName);
            int fileSize = image.PostedFile.ContentLength;
            if(response == "" && fileSize > 2097152)
            {
                response = "File must be lower than 2 MB";
            }
            if(response == "" && fileExtension != ".png" && fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".jfif")
            {
                response = "File's extension must be .png, .jpg, .jpeg, or .jfif";
            }
            return response;
        }

        public static string doInsertArtist(string name, FileUpload image)
        {
            //untuk semua controller, kalau di akhir dia tetep kasih response kosong. Maka validasi aman semua. Note for debugging
            string response = "";
            if(response == "")
            {
                response = checkName(name);
            }if (response == "")
            {
                response = checkImage(image);
            }if(response == "")
            {
                ArtistRepository.addArtist(name, "~/Assets/Images/" + image.FileName);
            }
            return response;
        }

        public static string doUpdateArtist(int id, string name, FileUpload image)
        {
            string response = "";
            if (response == "")
            {
                response = checkName(name);
            }
            if (response == "")
            {
                response = checkImage(image);
            }
            if (response == "")
            {
                ArtistRepository.updateArtist(id, name, "~/Assets/Images/" + image.FileName);
            }
            return response;
        }
    }
}