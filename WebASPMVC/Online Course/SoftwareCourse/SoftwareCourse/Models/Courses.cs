using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareCourse.Models
{
    public class Courses
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string CourseName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string CourseDescription { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string CourseTeacher { get; set; }
    }
}
