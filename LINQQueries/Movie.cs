﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LINQQueries
{
    public class Movie
    {
        public string Title { get; set; }
        public float Raiting { get; set; }

        private int _year;
        public int Year
        {
            get
            {
                Console.WriteLine($"Returning {_year} for {Title}");
                return _year;
            }
            set
            {
                _year = value;
            }
        }

    }
}
