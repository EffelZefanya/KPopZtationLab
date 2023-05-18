using KPopZtation.Factories;
using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KPopZtation.Repositories
{
    public class ArtistRepository
    {
        private static Database1Entities db = Repositories.Database.GetInstance();
        public static List<Artist> getAllArtist()
        {
            List<Artist> artists = (from x in db.Artists select x).ToList();
            return artists;
        }

        public static Artist getArtist(int id)
        {
            return (from x in db.Artists where x.ArtistId == id select x).FirstOrDefault();
        }

        public static List<Artist> getArtistForGridView(int id)
        {
            return (from x in db.Artists where x.ArtistId == id select x).ToList();
        }

        public static string addArtist(string name, string imagePath)
        {
            Artist artist = ArtistFactory.createArtist(name, imagePath);
            db.Artists.Add(artist);
            db.SaveChanges();
            return "New artist data suceesfully inserted";
        }

        public static void deleteArtist(int id)
        {
            Artist artist = getArtist(id);
            db.Artists.Remove(artist);
            db.SaveChanges();
            return;
        }

        public static void updateArtist(int id, string name, string imagePath)
        {
            Artist artist = ArtistFactory.createArtist(name, imagePath);
            deleteArtist(id);
            db.Artists.Add(artist);
            db.SaveChanges();
            return;
        }
    }
}