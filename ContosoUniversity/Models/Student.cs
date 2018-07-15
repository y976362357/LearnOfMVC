using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50,MinimumLength =1, ErrorMessage = "Last Name can not be longer than 50 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string LastName { get; set; }


        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First Name can not be longer than 50 characters")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }


        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }


        [Display(Name ="Full Name")]
        public string FullName {
            get {
                return FirstMidName+", " + LastName;
            }
        }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}