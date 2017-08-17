
using System.Data.Entity;
using GL.DeveloperUniversityApp.Domain.Entities;

namespace GL.DeveloperUniversityApp.Infra.Data.Context
{
    public class SchoolContext : DbContext        
    {
        public SchoolContext() : base("DeveloperUniversity")
        {
            //Default
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

    }
}
