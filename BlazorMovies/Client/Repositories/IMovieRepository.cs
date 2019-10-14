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
                GetMovie("Splider-Man Far From Home", new DateTime(2019,7,2), "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_SY1000_CR0,0,674,1000_AL_.jpg"),
                GetMovie("Mohana", new DateTime(2019,7,2), "http://t0.gstatic.com/images?q=tbn:ANd9GcS0I_NLZX7ywKTPOE6dP5IORzdjWJvBLz7ZLeyVR0HHuXieSF6l"),
                GetMovie("Inception", new DateTime(2019,7,2), "https://images-na.ssl-images-amazon.com/images/I/912AErFSBHL._SY445_.jpg"),
            }.ToList();
        }

        private static Movie GetMovie(string title, DateTime publishDate, string poster) => new Movie
        {
            Title = title,
            PublishDate = publishDate,
            Poster =  poster,
        };
    }
}
