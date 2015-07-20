using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbumApplication.Models
{
    public class EFRepository : AlbumApplication.Models.IRepository
    {
        private DataContext _db = new DataContext();

        //Method to get albums from database
        public IList<Album> ListAlbums()
        {
            // Remember to use the .ToList() method in order to actually return the data.
            // Its because of this we use the IList
            return _db.Albums.ToList();
        }

        // Create a new album
        public void CreateAlbum(Album album)
        {
            _db.Albums.Add(album);
            _db.SaveChanges();
        }

        // Find album by key id
        public Album FindAlbum(int id)
        {
            return _db.Albums.Find(id);
        }


        // Edit album
        public void Edit(Album album)
        {
            var original = this.FindAlbum(album.Id);
            original.Artist = album.Artist;
            original.Title = album.Title;
            original.Genre = album.Genre;
            _db.SaveChanges();
        }

        // Delete album
        public void Delete (int id)
        {
            var original = this.FindAlbum(id);
            _db.Albums.Remove(original);
            _db.SaveChanges();
        }

    }
}