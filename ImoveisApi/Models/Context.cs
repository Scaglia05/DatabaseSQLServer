using Microsoft.EntityFrameworkCore;

namespace ImoveisApi.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Imovel> Imovel { get; set; }
    }
}
