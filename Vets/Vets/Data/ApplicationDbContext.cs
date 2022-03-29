using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vets.Models;

namespace Vets.Data
{







    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Animais> Animais { get; set; }

        public DbSet<Veterinarios> Veterinarios { get; set; }

        public DbSet<Donos> Donos { get; set; }


        public DbSet<Consultas> Consultas { get; set; }





    }
}