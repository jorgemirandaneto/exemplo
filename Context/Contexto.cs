using exemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace exemplo.Context {
    public class Contexto : DbContext {

        public DbSet<Participante> Participantes { get; set; }
        public Contexto (DbContextOptions<Contexto> options):
            base (options) { }
    }
}