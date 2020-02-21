using System;
using System.Collections.Generic;
using System.Text;

namespace XamaMovies.Models
{
    public class Movie
    {
        public string ImdbId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Plot { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Poster { get; set; }
        public List<Rating> Ratings { get; set; }
        public string ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string Response { get; set; }
    }
}
