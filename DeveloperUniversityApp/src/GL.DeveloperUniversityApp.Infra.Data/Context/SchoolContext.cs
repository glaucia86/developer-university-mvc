
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using GL.DeveloperUniversityApp.Domain.Entities;

namespace GL.DeveloperUniversityApp.Infra.Data.Context
{
    public class SchoolContext : DbContext        
    {
        public SchoolContext() 
            : base("DeveloperUniversity")
        {
            //Default
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

        //Método responsável por realizar convenções das tables criadas no EF
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
