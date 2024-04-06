using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using PoznamkyAsp.Models;

namespace PoznamkyAsp.Data
{
    public class ApplicationDbContext : IdentityDbContext<Uzivatel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Poznamka> Poznamky { get; set; }
    }
}
