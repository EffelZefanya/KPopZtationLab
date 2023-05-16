using KPopZtation.Models;
using KPopZtation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Handlers
{
    public class generalHandlers
    {
        public static void deleteArtistWithAlbum(int id)
        {
            Artist artist = ArtistRepository.getArtist(id);

            if(id.ToString() == null)
            {
                return;
            }

            else if(artist.Albums.Count > 0)
            {
                AlbumRepositories.deleteSomeAlbums(artist.Albums.ToList());

                ArtistRepository.deleteArtist(id);
            }
        }
    }
}