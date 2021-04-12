using Lab22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Repositories
{
    public interface IMovieRepository
    {
        List<MovieModel> Get();
        void Save(MovieModel movie);
        List<MovieModel> GetByGenre();
        List<MovieModel> GetByTitle();
    }
}
