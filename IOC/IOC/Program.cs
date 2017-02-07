using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindsorContainer container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<IMovieFinder>().ImplementedBy<FileMovieFinder>());
            IMovieFinder movieFinder = container.Resolve<IMovieFinder>(new { fileName = "aa" });
            var movies = movieFinder.FindMovies();
            movies.ForEach(i => Console.WriteLine(i.Name));
            Console.Read();
        }
    }
}
