using LibraryData.Models;
using System.Collections.Generic;

namespace ProiectPractica.Services
{
    public interface IMovieCollection
    {
        IEnumerable<MovieCollection> GetAll();
        MovieCollection getById(int idCollection);
        void Add(MovieCollection movieCollection);
        void Delete(int idCollection);

        IEnumerable<Movie> GetMoviesFromCollection(int idCollection);
        void AddMovieIn(int idCollection, int idMovie);
        void RemoveMovie(int idCollection, int idMovie);

    }
}
