using MedicamentosRC.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicamentosRC.Data
{
    public class MedicamentosDbContext : DbContext
    {
        public MedicamentosDbContext(DbContextOptions<MedicamentosDbContext> options) : base(options)
        { }

        
        public DbSet<Medicamentos> Medicamentos { get; set; }
    }
}
