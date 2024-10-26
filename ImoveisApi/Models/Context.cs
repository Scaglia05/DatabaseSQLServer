using Microsoft.EntityFrameworkCore;
using ImoveisApi.Models;

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
        public DbSet<ImoveisApi.Models.Contrato> Contrato { get; set; } = default!;
        public DbSet<ImoveisApi.Models.Pagamento> Pagamento { get; set; } = default!;
        public DbSet<ImoveisApi.Models.Proprietario> Proprietario { get; set; } = default!;
    }
}
