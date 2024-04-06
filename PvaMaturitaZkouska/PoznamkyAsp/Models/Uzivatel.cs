using Microsoft.AspNetCore.Identity;

namespace PoznamkyAsp.Models
{
    public class Uzivatel : IdentityUser
    {
        public ICollection<Poznamka> Poznamky { get; set; }
    }
}
