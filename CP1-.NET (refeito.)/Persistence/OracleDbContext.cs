using CP1_.NET__refeito._.Models;
using Microsoft.EntityFrameworkCore;

namespace CP1_.NET__refeito._.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<TipoQuarto> TipoQuartos { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
        {

        }
    }
}
