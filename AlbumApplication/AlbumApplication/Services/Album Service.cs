using AlbumApplication.Models;
using CoderCamps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbumApplication.Services
{
    public class AlbumService : AlbumApplication.Services.IAlbumService
    {
        private IGenericRepository _repo;

        public AlbumService( IGenericRepository repo)
        {
            _repo = repo;
        }

        // Querying the Database
        public IList<Album> List()
        {
            return _repo.Query<Album>().ToList();
        }

        // Find Album
        public Album Find(int id)
        {
            return _repo.Find<Album>(id);
        }

        // Create Album
        public void Create(Album album)
        {
            _repo.Add<Album>(album);
            _repo.SaveChanges();
        }

        public void Edit(Album album)
        {
            var original = this.Find(album.Id);
            original.Title = album.Title;
            original.Artist = album.Artist;
            original.Genre = album.Genre;
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete<Album>(id);
            _repo.SaveChanges();
        }


    }
}