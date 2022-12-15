using CrudNet7MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet7MVC.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        //agregar modelos
        public DbSet<Conctacto> Contacto { get; set; } 

    }
}
