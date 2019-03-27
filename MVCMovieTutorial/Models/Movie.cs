using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovieTutorial.Models
{
    public class Movie
    {
        //Commented out attributes are for display. Current attributes are the commented out attributes combined into one line.
        public int Id { get; set; }

        //[StringLength(60, MinimumLength = 3)]
        //[Required]
        [Required, StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        //[Display(Name = "Release Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date"), DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        //[Required]
        //[StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

        //[Range(1, 100)]
        //[DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        //[StringLength(5)]
        //[Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(5)]
        public string Rating { get; set; }
    }
}
