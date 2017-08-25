using System.Data.Entity.ModelConfiguration;
using GL.DeveloperUniversityApp.Domain.Entities;

namespace GL.DeveloperUniversityApp.Infra.Data.EntityConfig
{
    /// <summary>
    /// Classe responsável por adotar Configurações especiais inerentes a classe: Course
    /// </summary>
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            HasKey(c => c.CourseId);

            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(70);

            Property(c => c.Credits)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
