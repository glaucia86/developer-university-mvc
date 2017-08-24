
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

            //aqui estou identificando quem é a PK da Table
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //Configuração dos tipos dos campos que sejam 'varchar'
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //Configuração dos tamanhos dos campos do tipo 'varchar' (padrão: 100)
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }
    }
}
