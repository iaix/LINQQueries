using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie> {
            new Movie { Title = "Dark Knight", Raiting = 8.9f, Year = 2008 },
            new Movie { Title = "The King's Speach", Raiting = 8.0f, Year = 2010 },
            new Movie { Title = "Casablanca", Raiting = 8.5f, Year = 1942 },
            new Movie { Title = "Star Wars V", Raiting = 8.7f, Year = 1980 }
            };

            var filter = new Filter();
            filter.MoviesWhere(movies);
            filter.MoviesMyLinqFilter(movies);
            filter.MoviesMyLinqCount(movies);
            filter.MoviesMyLinqCountList(movies);
            filter.MoviesMyLinqOrder(movies);
            filter.MoviesMyLinqOrderQuerySyntax(movies);

        }
    }
}
