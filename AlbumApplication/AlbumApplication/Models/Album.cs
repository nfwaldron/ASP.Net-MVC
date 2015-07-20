﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbumApplication.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
    }
}