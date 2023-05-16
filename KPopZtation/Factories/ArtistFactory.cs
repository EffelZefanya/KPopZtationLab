using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Factories
{
    public class ArtistFactory
    {
        private static Database1Entities db = Repositories.Database.GetInstance();
        public static Artist createArtist(string name, string imagePath)
        {
            Artist artist = new Artist();
            artist.ArtistName = name;
            artist.ArtistImage = imagePath;
            artist.ArtistId = (from x in db.Artists select x.ArtistId).ToList().LastOrDefault() + 1;
            return artist;
        }

        public static Artist updateArtist(int id, string name, string imagePath)
        {
            Artist artist = new Artist();
            artist.ArtistName = name;
            artist.ArtistImage = imagePath;
            artist.ArtistId = id;
            return artist;
        }
    }
}