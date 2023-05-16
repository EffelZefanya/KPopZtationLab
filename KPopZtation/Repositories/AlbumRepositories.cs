using KPopZtation.Factories;
using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Repositories
{
    public class AlbumRepositories
    {
        private static Database1Entities db = Repositories.Database.GetInstance();
        public static List<Album> GetAllAlbums()
        {
            return db.Albums.ToList();
        }

        public static Album GetAlbum(int id)
        {
            return (from x in db.Albums where x.AlbumId == id select x).FirstOrDefault();
        }
        /*
        public static string addAlbum()
        {

        }
        */

        public static string deleteAlbum(int id)
        {
            Album album = GetAlbum(id);
            db.Albums.Remove(album);
            db.SaveChanges();
            return "Artist succesfully removed";
        }

        public static int deleteSomeAlbums(List<Album> listOfArlbum)
        {
            db.Albums.RemoveRange(listOfArlbum);
            return db.SaveChanges();
        }

    }
}