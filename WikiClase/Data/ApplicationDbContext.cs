using Microsoft.EntityFrameworkCore;
using WikiClase.Models;

namespace WikiClase.Data
{
    public class ApplicationDbContext : DbContext
    { 
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<WikiClase.Models.Tag> Tag { get; set; }

        public DbSet<WikiClase.Models.Post> Post { get; set; }
    }
}
