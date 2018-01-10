using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlmajdoobUniversity.Models
{
    public class Student :Person
    {
        public Student () { }

       
        

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
            
        
        [Display(Name ="Email Address")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
