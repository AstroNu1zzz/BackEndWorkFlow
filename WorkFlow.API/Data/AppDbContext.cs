using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WorkFlow.API.Models;

namespace WorkFlow.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Evita que un mismo usuario se inscriba dos veces al mismo curso
            modelBuilder.Entity<Inscripcion>()
                .HasIndex(i => new { i.UsuarioId, i.CursoId })
                .IsUnique();
        }
    }
}