using System;
namespace AlbumApplication.Services
{
    // Must be public 
    public interface IAlbumService
    {
        void Create(AlbumApplication.Models.Album album);
        void Delete(int id);
        void Edit(AlbumApplication.Models.Album album);
        AlbumApplication.Models.Album Find(int id);
        System.Collections.Generic.IList<AlbumApplication.Models.Album> List();
    }
}
