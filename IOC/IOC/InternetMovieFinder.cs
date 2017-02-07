using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class InternetMovieFinder : IMovieFinder
    {
        public List<Movie> FindMovies()
        {
            return new List<Movie> { new Movie { Name="internet movie 1" },new Movie {  Name="internet movie 2"} };
        }
    }
}
