﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LINQQueries
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string LeadStudio { get; set; }
        public int AudienceScore { get; set; }
        public float Profitability { get; set; }
        public int RottenTomatoes { get; set; }
        public double WorldWideGross { get; set; }

        private int _ratingDifference;
        public int RatingDifference
        {
            get
            {
                return _ratingDifference = Math.Abs(AudienceScore - RottenTomatoes);

            }
            set
            {
                _ratingDifference = value;

            }
        }

        private int _year;
        public int Year
        {
            get
            {
                Console.WriteLine($"   (Returning {_year} for {Title})");
                return _year;
            }
            set
            {
                _year = value;
            }
        }

    }
}
