﻿using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        public string Title { get; set; }
        public bool CheckedOut { get; private set; }
        public List<double> _rating { get; set; }

        public Video(string title, double averageUserRating)
        {
            Title = title;
            _rating = new List<double> {averageUserRating};
        }

        public Video(string title)
        {
            Title = title;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            CheckedOut = true;
        }

        public void BeingReturned()
        {
            CheckedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            return _rating.Average();
        }

        public bool Available()
        {
            return CheckedOut;
        }

        public string title => Title;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }

        public double Average()
        {
            return _rating.Sum() / _rating.Count;
        }
    }
}
