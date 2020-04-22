using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace LINQQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = ProcessMovies("data/movies.csv");

            var filter = new Filter();
            filter.MoviesWhere(movies);
            filter.MoviesMyLinqFilter(movies);
            filter.MoviesMyLinqCount(movies);
            filter.MoviesMyLinqCountList(movies);
            filter.MoviesMyLinqOrder(movies);
            filter.MoviesMyLinqOrderQuerySyntax(movies);

        }

        private static List<Movie> ProcessMovies(string path)
        {
            var query =

                File.ReadAllLines(path)
                    .Skip(1)
                    .Where(l => l.Length > 1)
                    .ToMovie();

            return query.ToList();
        }
    }
}
