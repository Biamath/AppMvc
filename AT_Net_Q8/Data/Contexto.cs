using AT_Net_Q8.Models;
using Microsoft.EntityFrameworkCore;

namespace AT_Net_Q8.Data
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
