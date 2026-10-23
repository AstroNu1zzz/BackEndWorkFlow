using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkFlow.API.Models
{
    public class Inscripcion
    {
        [Key]
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Alumno { get; set; } = null!;

        public int CursoId { get; set; }
        [ForeignKey("CursoId")]
        public Curso Curso { get; set; } = null!;

        public DateTime FechaInscripcion { get; set; } = DateTime.UtcNow;
    }
}