using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkFlow.API.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        // Mapea a {Binding Title} y ClassNameEntry
        [Required]
        public string Title { get; set; } = string.Empty;

        // Mapea a {Binding Group} y GroupEntry
        public string Group { get; set; } = string.Empty;

        // Mapea a SubjectEntry
        public string Subject { get; set; } = string.Empty;

        // Mapea a RoomEntry
        public string Room { get; set; } = string.Empty;

        // Código alfanumérico de 5-7 caracteres del JoinClassModalPage
        [Required]
        [MaxLength(7)]
        public string JoinCode { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        // Llave foránea del creador/profesor (Mapea indirectamente a {Binding Teacher})
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Usuario Teacher { get; set; } = null!;

        public ICollection<Publicacion> Publicaciones { get; set; } = new List<Publicacion>();
    }
}
