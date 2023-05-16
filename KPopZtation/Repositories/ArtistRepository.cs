using KPopZtation.Factories;
using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public static string addArtist(string name, string imagePath)
        {
            Artist artist = ArtistFactory.createArtist(name, imagePath);
            db.Artists.Add(artist);
            db.SaveChanges();
            return "New artist data suceesfully inserted";
        }
    }
}