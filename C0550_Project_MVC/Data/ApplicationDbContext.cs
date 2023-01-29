using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CO550_Project_Razor.Models;
using C0550_Project_MVC.Models;

namespace C0550_Project_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CO550_Project_MVC.Models.Film> Film { get; set; } 
        public DbSet<CO550_Project_Razor.Models.Ticket> Ticket { get; set; }
        public DbSet<CO550_Project_Razor.Models.Person> Person { get; set; }
        public DbSet<CO550_Project_Razor.Models.Payment> Payment { get; set; }
        public DbSet<CO550_Project_Razor.Models.FilmShow> FilmShow { get; set; }
    }
}