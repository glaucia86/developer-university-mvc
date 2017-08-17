

using System;
using System.Collections.Generic;

namespace GL.DeveloperUniversityApp.Domain.Entities
{
    /// <summary>
    /// Classe: Estudante
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Id do Estudante
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// Nome e nome do meio do Estudante
        /// </summary>
        public string FirstMidName { get; set; }

        /// <summary>
        /// Sobrenome do Estudante
        /// </summary>
        public string LastName { get; set; }        

        /// <summary>
        /// Data de Inscrição
        /// </summary>
        public DateTime EnrollmentDate { get; set; }

        /// <summary>
        /// Relacionamento de Estudante -> Inscrição (Relacionamento de 1 para n)
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
