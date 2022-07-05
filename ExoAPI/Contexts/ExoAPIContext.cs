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
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-JPQNRAT; initial catalog = ExoAPI; Integrated Security = true");
            }
        }
            public DbSet<Projetos> Projetos { get; set; }
    }
}
