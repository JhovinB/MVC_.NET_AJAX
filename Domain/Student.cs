using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        public string studentName { get; set; }

        [Required]
        public string studentLastName { get; set; }


        [Required]
        public string studentCode { get; set; }

        public DateTime startDate { get; set; }

        public DateTime EnrollmentDate { get; set; }

        [Required]
        public string studentAddress { get; set; }
    }
}
