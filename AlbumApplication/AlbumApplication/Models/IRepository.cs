using System;
namespace AlbumApplication.Models
{
    // Make interface public
    public interface IRepository
    {
        void CreateAlbum(Album album);
        void Delete(int id);
        void Edit(Album album);
        Album FindAlbum(int id);
        System.Collections.Generic.IList<Album> ListAlbums();
    }
}
