using System.ComponentModel.DataAnnotations;

namespace WorkFlow.API.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        public string AvatarUrl { get; set; } = string.Empty;

        // Determina si es "Profesor", "Alumno", etc. (Mapea a SubtitleRole en XAML)
        public string Role { get; set; } = string.Empty;

        // Relaciones de Entity Framework
        public ICollection<Curso> CursosImpartidos { get; set; } = new List<Curso>();
    }
}
