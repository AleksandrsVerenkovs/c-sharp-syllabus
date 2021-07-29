using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _isAvailable;
        private List<double> _rating;

        //private double Rating { get; set; }
        //private bool IsAvailable { get; set; }

        public Video(string title)
        {
            _title = title;
            _isAvailable = true;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _isAvailable = false;
        }

        public void BeingReturned()
        {
            _isAvailable = true;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            return Enumerable.Range((int)_rating[0],_rating.Count()).Aggregate(0,(a,b) => a+b) / _rating.Count();
        }

        public bool Available()
        {
            return _isAvailable;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
