using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareCourse.Models
{
    public class CoursesContext:DbContext
    {
        public CoursesContext(DbContextOptions<CoursesContext> options):base(options)
        {
                
        }
        public DbSet<Courses> Coursess { get; set; }
}
}
