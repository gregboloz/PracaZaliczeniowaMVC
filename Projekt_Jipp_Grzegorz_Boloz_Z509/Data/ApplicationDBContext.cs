using Microsoft.EntityFrameworkCore;
using Projekt_Jipp_Grzegorz_Boloz_Z509.Models;

namespace Projekt_Jipp_Grzegorz_Boloz_Z509.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        { 
        
        }

        public DbSet<Category> Categories { get; set; }
    }
}
