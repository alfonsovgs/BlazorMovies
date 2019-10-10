using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();
    }

    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetMovies()
        {
            return new []
            {
                GetMovie("Splider-Man Far From Home", new DateTime(2019,7,2)),
                GetMovie("Mohana", new DateTime(2019,7,2)),
                GetMovie("Inception", new DateTime(2019,7,2)),
            }.ToList();
        }

        private static Movie GetMovie(string title, DateTime publishDate) => new Movie
        {
            Title = title,
            PublishDate = publishDate,
        };
    }
}
