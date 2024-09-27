using Microsoft.EntityFrameworkCore;
using AT_Net_Q7.Models;

namespace AT_Net_Q7.Data
{
    public class Contexto:DbContext
    {

        public Contexto (DbContextOptions<Contexto> options):base(options) { }
        public DbSet<Livro> Livro { get; set; } 
    }
}
