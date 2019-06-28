using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationCursos.Models;

namespace WebApplicationCursos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplicationCursos.Models.Categoria> Categoria { get; set; }
        public DbSet<WebApplicationCursos.Models.Curso> Curso { get; set; }
        public DbSet<WebApplicationCursos.Models.Estudiante> Estudiante { get; set; }
        public DbSet<WebApplicationCursos.Models.Instructor> Instructor { get; set; }
        public DbSet<WebApplicationCursos.Models.Persona> Persona { get; set; }
        public DbSet<WebApplicationCursos.Models.Asignacion> Asignacion { get; set; }
    }
}
