using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class FileMovieFinder : IMovieFinder
    {
        string fileName;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName">this parameter is useless but to indicate how windsor resolve a instance with some constructor parameter(s)</param>
        public FileMovieFinder(string fileName)
        {
            this.fileName = fileName;
        }
        public List<Movie> FindMovies()
        {
            return new List<Movie> {
                new Movie {  Name="file movie 1" },new Movie { Name="file movie 2" }
            };
        }
    }
}
