using LibraryData.Models;
using System.Collections.Generic;

namespace ProiectPractica.Models
{
    public class MovieCollectionVM
    {
        public int CollectionId { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<MovieCollection> Collections { get; set; }
    }
}
