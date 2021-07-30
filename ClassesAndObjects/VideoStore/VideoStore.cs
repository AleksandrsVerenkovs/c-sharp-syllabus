using System;
using System.Linq;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _movieList = new List<Video>();
        public VideoStore()
        {
            _movieList = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _movieList.Add(new Video(title));
        }

        public void Checkout(string title)
        {
            var movie = FindMovie(title);
            movie.BeingCheckedOut();
        }

        public void ReturnVideo(string title)
        {
            var movie = FindMovie(title);
            movie.BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            var movie = FindMovie(title);
            movie.ReceivingRating(rating);
        }

        public void ListInventory()
        {
            foreach (var movie in _movieList)
            {
                Console.WriteLine(movie.ToString());
            }
        }
        public Video FindMovie(string title)
        {
            return _movieList.FirstOrDefault(mov => mov.Title == title);
        }
    }
}
