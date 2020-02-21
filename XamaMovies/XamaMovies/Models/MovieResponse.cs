using System;
using System.Collections.Generic;
using System.Text;

namespace XamaMovies.Models
{
    class MovieResponse
    {
        public Movie[] Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
    }
}
