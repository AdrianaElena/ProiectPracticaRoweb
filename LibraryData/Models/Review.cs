using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Display(Name ="Name")]
        [StringLength(100, MinimumLength = 2)]
        public string UserName { get; set; }

        [Display(Name = "Review")]
        public string ReviewText { get; set; }

        [Display(Name = "Review Date")]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
