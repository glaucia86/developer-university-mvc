using System.Data.Entity.ModelConfiguration;
using GL.DeveloperUniversityApp.Domain.Entities;

namespace GL.DeveloperUniversityApp.Infra.Data.EntityConfig
{
    /// <summary>
    /// Classe responsável por adotar Configurações especiais inerentes a classe: Student
    /// </summary>
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasKey(s => s.StudentId);

            Property(s => s.FirstMidName)
                .IsRequired()
                .HasMaxLength(50);

            Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
