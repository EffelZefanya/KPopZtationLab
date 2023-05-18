using KPopZtation.Models;
using KPopZtation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Factories
{
    public class AlbumFactory
    {
        private static Database1Entities db = Database.GetInstance();

        public static Album createAlbum(int artistId, string name, string desc, string image, int price, int stock)
        {
            Album album = new Album();
            album.AlbumId = (from x in db.Albums select x.AlbumId).ToList().LastOrDefault() + 1;
            album.AlbumName = name;
            album.AlbumDescription = desc;
            album.AlbumImage = image;
            album.AlbumPrice = price;
            album.AlbumStock = stock;
            album.ArtistId = artistId;

            return album;
        }

        public static Album createAlbumImportedId(int albumId, int artistId, string name, string desc, string image, int price, int stock)
        {
            Album album = new Album();
            album.AlbumId = albumId;
            album.AlbumName = name;
            album.AlbumDescription = desc;
            album.AlbumImage = image;
            album.AlbumPrice = price;
            album.AlbumStock = stock;
            album.ArtistId = artistId;

            return album;
        }
    }
}