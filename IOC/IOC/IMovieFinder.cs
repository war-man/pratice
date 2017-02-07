using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public interface IMovieFinder
    {
        List<Movie> FindMovies();
    }
}
