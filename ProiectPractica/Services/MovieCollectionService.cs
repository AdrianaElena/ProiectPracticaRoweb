using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ProiectPractica.Services
{
    public class MovieCollectionService : IMovieCollection
    {
        private MovieContext _context;

        public MovieCollectionService(MovieContext context)
        {
            _context = context;
        }

        public void Add(MovieCollection movieCollection)
        {
            _context.Add(movieCollection);
            _context.SaveChanges();
        }

        public void AddMovieIn(int idCollection, int idMovie)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == idMovie);
            GetMoviesFromCollection(idCollection).ToList().Add(movie);
        }

        public void Delete(int idCollection)
        {
            var collection = getById(idCollection);
            _context.Remove(collection);
            _context.SaveChanges();
        }

        public IEnumerable<MovieCollection> GetAll()
        {
            return _context.MovieCollections.Include(m => m.Movies);
        }

        public MovieCollection getById(int idCollection)
        {
            return _context.MovieCollections
                .Include(m=>m.Movies)
                .FirstOrDefault(c => c.Id == idCollection);
        }

        public IEnumerable<Movie> GetMoviesFromCollection(int idCollection)
        {
            return getById(idCollection).Movies;
        }

        public void RemoveMovie(int idCollection, int idMovie)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == idMovie);
            GetMoviesFromCollection(idCollection).ToList().Remove(movie);
        }
    }
}
