using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LINQQueries
{
    public static class ParseData
    {
        public static IEnumerable<Movie> ToMovie(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                var columns = line.Split(',');

                yield return new Movie
                {
                    Title = columns[0],
                    Genre = columns[1],
                    LeadStudio = columns[2],
                    AudienceScore = int.Parse(columns[3]),
                    Profitability = float.Parse(columns[4], CultureInfo.InvariantCulture),
                    RottenTomatoes = int.Parse(columns[5]),
                    WorldWideGross = ParseStringToDouble(columns[6]),
                    Year = int.Parse(columns[7])
                };
            }
        }

        private static double ParseStringToDouble(string grossValue)
        {
            var a = String.Concat(grossValue.Skip(1));
            double d = Double.Parse(a, CultureInfo.InvariantCulture);
            return d;
        }
    }
    }
