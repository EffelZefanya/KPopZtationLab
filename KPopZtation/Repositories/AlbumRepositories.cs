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

        public static List<Album> GetAllAlbumsFromArtist(int id)
        {
            return (from x in db.Albums where x.ArtistId == id select x).ToList();
        }
        public static string addAlbum(int artistId, string name, string desc, string image, int price, int stock)
        {

            Album album = AlbumFactory.createAlbum(artistId, name, desc, image, price, stock);
            db.Albums.Add(album);
            db.SaveChanges();
            return "Album succesfully inserted";
        }

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

        public static string updateAlbum(int albumId, string name, string desc, string image, int price, int stock)
        {
            int artistId = (from x in db.Albums where x.AlbumId == albumId select x.ArtistId).FirstOrDefault();
            Album album = AlbumFactory.createAlbumImportedId(albumId, artistId, name, desc, image, price, stock);
            deleteAlbum(albumId);
            db.Albums.Add(album);
            db.SaveChanges();
            return "Album succefully updated";
        }

    }
}