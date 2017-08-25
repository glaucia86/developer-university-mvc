using System.Data.Entity.ModelConfiguration;
using GL.DeveloperUniversityApp.Domain.Entities;

namespace GL.DeveloperUniversityApp.Infra.Data.EntityConfig
{
    public class EnrollmentConfiguration : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentConfiguration()
        {
            HasKey(e => e.EnrollmentId);

            Property(e => e.Grade)
                .IsRequired();

            //Configuração do relacionamento:  Course to Enrollment (1 -> n)
            //Definição da FK: CourseId
            HasRequired(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            //Configuração do relacionamento: Student to Enrollment (1 - n)
            //Definição da FK: StudentId
            HasRequired(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);
        }
    }
}
