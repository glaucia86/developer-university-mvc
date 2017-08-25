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
        }
    }
}
