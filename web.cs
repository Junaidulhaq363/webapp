using System;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        public string MoviesWatched { get; set; }
        public int Rating { get; set; }
    }
}
