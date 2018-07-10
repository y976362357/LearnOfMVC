using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }
        [Display(Name ="发布日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

        public string Rating { get; set; }
    }

    public class MovieDbContext :DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }   
}