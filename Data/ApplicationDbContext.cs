using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FCIT_Event_Finder.Models;

namespace FCIT_Event_Finder.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<FCIT_Event_Finder.Models.Event> Event { get; set; } = default!;
    }
}
