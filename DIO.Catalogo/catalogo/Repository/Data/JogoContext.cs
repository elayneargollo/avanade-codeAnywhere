using catalogo.Entity;
using Microsoft.EntityFrameworkCore;

namespace catalogo.Repository.Data
{
    public class JogoContext : DbContext
    {
        public JogoContext(DbContextOptions<JogoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Jogo> Jogo { get; set; }
    }
}
