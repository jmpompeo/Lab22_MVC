using Lab22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly List<MovieModel> _movies = new List<MovieModel>()
        {
            new MovieModel("Star Wars: A New Hope", "Sci-Fi"),
            new MovieModel("21 Jump Street", "Comedy"),
            new MovieModel("Star Wars: Force Awakens", "Sci-Fi"),
            new MovieModel("Avengers", "Action"),
            new MovieModel("Grown Ups", "Comedy"),
            new MovieModel("Top Gun", "Action"),
            new MovieModel("Saw", "Horror"),
            new MovieModel("Annabelle", "Horror"),
            new MovieModel("Avengers: Ultron", "Action"),
            new MovieModel("Avengers Infinity War", "Action"),
            new MovieModel("Step Brothers", "Comedy"),
            new MovieModel("Friends With Benefits", "RomCom"),
            new MovieModel("Runaway Bride", "RomCom"),
            new MovieModel("Star Wars: ROTS", "Sci-Fi"),
            new MovieModel("Avengers Endgame", "Action")
        };


        public List<MovieModel> GetByGenre()
        {
            return _movies;
        }

        public void Save(MovieModel movie)
        {
            _movies.Add(movie);
        }

        public List<MovieModel> GetByTitle()
        {
            return _movies;
        }

        public List<MovieModel> Get()
        {
            return _movies;
        }
    }
}
