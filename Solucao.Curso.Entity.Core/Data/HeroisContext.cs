using Microsoft.EntityFrameworkCore;
using Solucao.Curso.Entity.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solucao.Curso.Entity.Core.Data
{
    public class HeroisContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<HeroisBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)                                               
        {
            optionsBuilder.UseSqlServer("Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=EFTeste01;Data Source=DESKTOP-EUD6FT9\\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroisBatalha>(entity =>
           {
               entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
           });
        }  
    }
}
