using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQQueries
{
    public class Filter
    {

        public void MoviesWhere(IEnumerable<Movie> movies)
        {
            Console.WriteLine("\n*** Where operator ***\n");

            var moviesAfter2000Where = movies.Where(m => m.Year > 2000)
                                             .Take(10);
            foreach (var movie in moviesAfter2000Where)
            {
                Console.WriteLine(movie.Title);
            }
        }

        public void MoviesMyLinqFilter(IEnumerable<Movie> movies)
        {

            Console.WriteLine("\n*** Filter by MyLinq class ***\n");

            var moviesAfter2000MyLinq = movies.Filter(m => m.Year > 2000)
                                                             .Take(10);

            var enumerator = moviesAfter2000MyLinq.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }
        }

        public void MoviesMyLinqCount(IEnumerable<Movie> movies)
        {
            Console.WriteLine("\n*** Filter by MyLinq class with Count() ***\n");

            var moviesAfter2000MyLinqCount = movies.Filter(m => m.Year > 2000)
                                                             .Take(10);

            Console.WriteLine(moviesAfter2000MyLinqCount.Count());
            var enumeratorCount = moviesAfter2000MyLinqCount.GetEnumerator();
            while (enumeratorCount.MoveNext())
            {
                Console.WriteLine(enumeratorCount.Current.Title);
            }
        }

        public void MoviesMyLinqCountList(IEnumerable<Movie> movies)
        {
            Console.WriteLine("\n*** Filter by MyLinq class with Count() and elements on list ***\n");

            var moviesAfter2000MyLinqCountList = movies.Filter(m => m.Year > 2000)
                                                             .Take(10)
                                                             .ToList();
            Console.WriteLine(moviesAfter2000MyLinqCountList.Count());
            var enumeratorCountList = moviesAfter2000MyLinqCountList.GetEnumerator();
            while (enumeratorCountList.MoveNext())
            {
                Console.WriteLine(enumeratorCountList.Current.Title);
            }
        }

        public void MoviesMyLinqOrder(IEnumerable<Movie> movies)
        {

            Console.WriteLine("\n*** Filter by MyLinq class with orderby ***\n");

            var moviesAfter2000MyLinqOrder = movies.Filter(m => m.Year > 2000)
                                                    .OrderBy(m => m.RottenTomatoes)
                                                    .Take(10);
            var enumeratorOrder = moviesAfter2000MyLinqOrder.GetEnumerator();
            while (enumeratorOrder.MoveNext())
            {
                Console.WriteLine(enumeratorOrder.Current.Title);
            }
        }

        public void MoviesMyLinqOrderQuerySyntax(IEnumerable<Movie> movies)
        {
            Console.WriteLine("\n*** Filter by MyLinq class with orderby. Query syntax ***\n");

            var moviesAfter2000MyLinqOrderQuerySyntax = from movie in movies
                                                        where movie.Year > 2000
                                                        orderby movie.RottenTomatoes
                                                        select movie;
            var enumeratorOrderQuerySyntax = moviesAfter2000MyLinqOrderQuerySyntax.GetEnumerator();
            while (enumeratorOrderQuerySyntax.MoveNext())
            {
                Console.WriteLine(enumeratorOrderQuerySyntax.Current.Title);
            }
        }

    }
}
