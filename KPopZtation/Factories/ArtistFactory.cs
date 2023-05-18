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
            Artist firstArtist = (from x in db.Artists select x).FirstOrDefault();
            Artist artist = new Artist();
            if(firstArtist == null)
            {
                artist.ArtistId = 1;
            }
            else
            {
                artist.ArtistId = 2;
                //please change this later to (from x in db.Artists select x.ArtistId).ToList().LastOrDefault() + 1
            }
            artist.ArtistName = name;
            artist.ArtistImage = imagePath;
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