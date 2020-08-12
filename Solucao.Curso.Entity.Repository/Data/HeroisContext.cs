using Microsoft.EntityFrameworkCore;
using Solucao.Curso.Entity.Dominio.Models;

namespace Solucao.Curso.Entity.Repository.Data
{
    public class HeroisContext : DbContext
    {
        public HeroisContext(DbContextOptions<HeroisContext> options): base(options) {}

        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<HeroisBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroisBatalha>(entity =>
           {
               entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
           });
        }
    }
}
