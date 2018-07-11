using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(20,ErrorMessage ="长度在3-20之间",MinimumLength =3)]
        public string Title { get; set; }
        [Display(Name ="发布日期"), DataType(DataType.Date)]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDbContext :DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }   
}