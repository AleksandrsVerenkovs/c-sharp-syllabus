using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Movie
    {
        private string Title;
        private string Studio;
        private string Rating;
        private List<Movie> PGMovies;

        public Movie(string title, string studio, string rating)
        {
            Title = title;
            Studio = studio;
            Rating = rating;
        }
        public Movie(string title, string studio)
        {
            Title = title;
            Studio = studio;
            Rating = "PG";
        }

        public Movie[] GetPG(List<Movie> movies)
        {
            return PGMovies.Where(movie => movie.Rating == "PG").ToArray();
        }
    }
}
