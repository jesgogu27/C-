using Microsoft.EntityFrameworkCore;
using Medicamentos.Models;


namespace MedicamentosRC.Data
{
    public class MedicamentosDbContext : DbContext
    {

        public MedicamentosDbContext(DbContextOptions<MedicamentosDbContext> options) : base(options) 
        { }

        //Agregamos los Modelos 

        public DbSet<Medicamentos> Medicamentos { get; set; }   
    }
}
