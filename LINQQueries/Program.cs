using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;

namespace LINQQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = ProcessMovies("data/movies.csv");

            CreateXML(movies);
            QueryXML();


            var filter = new Filter();
            //filter.MoviesWhere(movies);
            //filter.MoviesMyLinqFilter(movies);
            //filter.MoviesMyLinqCount(movies);
            //filter.MoviesMyLinqCountList(movies);
            //filter.MoviesMyLinqOrder(movies);
            //filter.MoviesMyLinqOrderQuerySyntax(movies);
            //filter.BestMovie(movies);
            filter.TopMovies(movies);

        }

        private static void QueryXML()
        {
            var document = XDocument.Load("movies.xml");

            var query =
                from element in document.Element("Movies").Elements("Movie")
                select element.Attribute("Title").Value;

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        }

        private static void CreateXML(List<Movie> records)
        {

            var document = new XDocument();
            var movies = new XElement("Movies",
                from record in records
                select new XElement("Movie",
                        new XAttribute("Title", record.Title),
                        new XAttribute("Year", record.Year),
                        new XAttribute("RottenTomatoesScore", record.RottenTomatoes),
                        new XAttribute("AudienceScore", record.AudienceScore))
                );
            document.Add(movies);
            document.Save("movies.xml");
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
