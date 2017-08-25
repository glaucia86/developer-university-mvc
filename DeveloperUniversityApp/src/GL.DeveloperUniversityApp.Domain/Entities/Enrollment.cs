

namespace GL.DeveloperUniversityApp.Domain.Entities
{
    /// <summary>
    /// Classe: Inscrição
    /// </summary>
    public class Enrollment
    {
        /// <summary>
        /// Id da Inscrição do Curso
        /// </summary>
        public int EnrollmentId { get; set; }

        /// <summary>
        /// Id do Curso
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// Id do Estudante
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// Nota (propriedade)
        /// </summary>
        public Grade? Grade { get; set; }

        /// <summary>
        /// Relacionamento de Inscrição -> Curso (relacionamento de n para 1)
        /// Foreign Key (Chave Estrangeira)
        /// </summary>
        public virtual Course Course { get; set; }

        /// <summary>
        /// Relacionamento de Inscrição -> Estudante (relacionamento de n para 1)
        /// </summary>
        public virtual Student Student { get; set; }
               
    }

    /// <summary>
    /// Nota tirada nos Cursos
    /// </summary>
    public enum Grade
    {
        A, B, C, D, E, F
    }
}
