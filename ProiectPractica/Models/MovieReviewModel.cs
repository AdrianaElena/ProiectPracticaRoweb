using LibraryData.Models;

namespace ProiectPractica.Models
{
    public class MovieReviewModel
    {
        public Movie Movie { get; set; }
        public string UserName { get; set; }
        public string ReviewText { get; set; }
        public int Id { get; set; }
    }
}
