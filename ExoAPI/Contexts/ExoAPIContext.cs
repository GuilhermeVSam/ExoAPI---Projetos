using ExoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoAPI.Contexts
{
    public class ExoAPIContext : DbContext
    {
        public ExoAPIContext()
        {
        }
        public ExoAPIContext(DbContextOptions<ExoAPIContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = PLAYSTATION-5\\SQLEXPRESS; initial catalog = ExoAPI; Integrated Security = true");
            }
        }
            public DbSet<Projetos> Projetos { get; set; }
            public DbSet<Usuario> Usuarios { get; set; }
    }
}
