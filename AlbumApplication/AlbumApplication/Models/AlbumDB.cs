using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlbumApplication.Models
{
    public class AlbumDB:DbContext
    {
        public AlbumDB()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Album> Albums { get; set; }

    }
}