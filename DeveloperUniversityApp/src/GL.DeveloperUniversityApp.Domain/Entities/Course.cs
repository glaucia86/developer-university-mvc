using System.Collections.Generic;

namespace GL.DeveloperUniversityApp.Domain.Entities
{
    /// <summary>
    /// Classe: Curso
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Id do Curso
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// Título do Curso
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Créditos do Curso
        /// </summary>
        public string Credits { get; set; }

        /// <summary>
        /// Relacionamento de Curso -> Inscrições (relacionamento 1 para n)
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
