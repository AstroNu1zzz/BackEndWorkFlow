using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkFlow.API.Models
{
    
        public class Publicacion
        {
            [Key]
            public int Id { get; set; }

            public int CourseId { get; set; }
            [ForeignKey("CourseId")]
            public Curso Course { get; set; } = null!;

            public int AuthorId { get; set; }
            [ForeignKey("AuthorId")]
            public Usuario Author { get; set; } = null!;

            // Mapea a {Binding Title}
            [Required]
            public string Title { get; set; } = string.Empty;

            // Mapea a {Binding Subtitle}
            public string Content { get; set; } = string.Empty;

            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

            // Mapea a {Binding IsAssignment} y {Binding HasDueDate}
            public bool IsAssignment { get; set; }

            // Mapea a la lógica detrás de {Binding DueText} y {Binding DueDateText}
            public DateTime? DueDate { get; set; }

            // Mapea a {Binding IconSymbol} y {Binding Icon} (ej. "📢", "📋")
            public string IconSymbol { get; set; } = string.Empty;

            // Mapea a la lógica detrás de {Binding StatusText} (ej. "Entregado", "Sin entregar")
            public string Status { get; set; } = string.Empty;
        }
    }

