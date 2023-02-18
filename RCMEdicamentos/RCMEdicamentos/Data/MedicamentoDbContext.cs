using Microsoft.EntityFrameworkCore;
using RCMEdicamentos.Models;

namespace RCMEdicamentos.Data
{
    public class MedicamentoDbContext : DbContext 
    {
        public MedicamentoDbContext(DbContextOptions<MedicamentoDbContext> options) : base(options) { }
    
        //Agregar  Modelos

        public  DbSet<Medicamentos> Medicamentos { get; set; }
    }
}
