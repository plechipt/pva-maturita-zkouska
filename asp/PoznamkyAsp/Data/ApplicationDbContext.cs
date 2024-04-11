using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using PoznamkyAsp.Models;

namespace PoznamkyAsp.Data
{
    public class ArchivPoznamekData : DbContext 
    {
        public DbSet<Uzivatel> Uzivatele { get; set; }
        public DbSet<Poznamka> Poznamky { get; set; }

        public ArchivPoznamekData(DbContextOptions<ArchivPoznamekData> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Poznamka>()
                .HasOne(u => u.Autor)
                .WithMany(a => a.Poznamky);
        }
    }
}
