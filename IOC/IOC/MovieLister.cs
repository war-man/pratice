using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class MovieLister
    {
        IMovieFinder finder;
        public MovieLister(IMovieFinder movieFinder)
        {
            this.finder = movieFinder;
        }

        public List<Movie> ListMovie()
        {
            return finder.FindMovies();
        }
    }
}
