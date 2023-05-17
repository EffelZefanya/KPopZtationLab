using KPopZtation.Models;
using KPopZtation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KPopZtation.Controllers
{
    public class AlbumController
    {
        private static Database1Entities db = Repositories.Database.GetInstance();
        public static string checkName(string name)
        {
            string response = "";
            if (name.Equals(""))
            {
                response = "Artis's name can't be empty";
            }
            else if (name.Length > 50)
            {
                response = "Name's length must be less than 50";
            }
            return response;
        }

        public static string checkDesc(string desc)
        {
            string response = "";
            if (desc.Equals(""))
            {
                response = "Description can't be empty";
            }
            else if (desc.Length > 255)
            {
                response = "Description's length must be less than 255";
            }
            return response;
        }

        public static string checkPrice(int price)
        {
            string response = "";
            if (price.ToString().Equals(""))
            {
                response = "Price can't be empty";
            }
            else if (price < 100000 || price > 1000000)
            {
                response = "Price must be between 100000 and 1000000";
            }
            return response;
        }

        public static string checkStock(int stock)
        {
            string response = "";
            if (stock.ToString().Equals(""))
            {
                response = "Stock can't be empty";
            }
            else if (stock < 0)
            {
                response = "Stock must be more than 0";
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
            if (response == "" && fileSize > 2097152)
            {
                response = "File must be lower than 2 MB";
            }
            if (response == "" && fileExtension != ".png" && fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".jfif")
            {
                response = "File's extension must be .png, .jpg, .jpeg, or .jfif";
            }
            return response;
        }

        public static string doInsertAlbum(int artistId, string name, string desc, FileUpload image, int price, int stock)
        {
            //untuk semua controller, kalau di akhir dia tetep kasih response kosong. Maka validasi aman semua. Note for debugging
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
                AlbumRepositories.addAlbum(artistId, name, desc, "~/Assets/Images/" + image.FileName, price, stock);
            }
            return response;
            
        }

        /*
        public static string doUpdateAlbum(int artistId, string name, string desc, FileUpload image, int price, int stock)
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
                AlbumRepositories.updateAlbum(artistId, name, desc, "~/Assets/Images/" + image.FileName, price, stock);
            }
            return response;
        }
        */
    }
}