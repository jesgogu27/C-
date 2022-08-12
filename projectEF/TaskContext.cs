using Microsoft.EntityFrameworkCore;
using projectEF.Models;

namespace projectEF;

public class TaskContext: DbContext
{
    public DbSet<Categorie> Categories { get; set;}
    public DbSet<Models.Task> Tasks { get; set; }

    public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    
    
    
    {

        List<Categorie> categoriesInit = new List<Categorie>();
        categoriesInit.Add(new Categorie(){CategorieId = Guid.Parse("14c0ef6a-3e32-44c6-8f16-5d1eb935b49d"), Name = "Actividades pendientes", Peso = 20});              
        categoriesInit.Add(new Categorie(){CategorieId = Guid.Parse("14c0ef6a-3e32-44c6-8f16-5d1eb935b402"), Name = "Actividades Personales", Peso = 50});
        categoriesInit.Add(new Categorie(){CategorieId = Guid.Parse("14c0ef6a-3e32-44c6-8f16-5d1eb935b404"), Name = "Actividad Realizada", Peso = 10});              



        modelBuilder.Entity<Categorie>(categorie =>
        {
            categorie.ToTable("Categorie");
            categorie.HasKey(p=> p.CategorieId);

            categorie.Property(p => p.Name).IsRequired().HasMaxLength(150);

            categorie.Property(p => p.Description).IsRequired(false);

            categorie.Property(p => p.Peso);

            categorie.HasData(categoriesInit);
        }
        );


        List<Models.Task> tareasInit = new List<Models.Task>();
        tareasInit.Add(new Models.Task() {TaskId = Guid.Parse("14c0ef6a-3e32-44c6-8f16-5d1eb935b410"), CategoriId = Guid.Parse("14c0ef6a-3e32-44c6-8f16-5d1eb935b49d"), PrioritiTask = Priority.media, Tittle =  "Pagos pendientes", CreationDate = DateTime.Now });
        tareasInit.Add(new Models.Task() {TaskId = Guid.Parse("14c0ef6a-3e32-44c6-8f16-5d1eb935b412"), CategoriId = Guid.Parse("14c0ef6a-3e32-44c6-8f16-5d1eb935b402"), PrioritiTask = Priority.baja, Tittle =  "Terminar PElicula en Netflix", CreationDate = DateTime.Now });
        tareasInit.Add(new Models.Task() {TaskId = Guid.Parse("14c0ef6a-3e32-44c6-8f16-5d1eb935b414"), CategoriId = Guid.Parse("14c0ef6a-3e32-44c6-8f16-5d1eb935b404"), PrioritiTask = Priority.alta, Tittle = "Aprender a Programar", CreationDate = DateTime.Now});

        modelBuilder.Entity<Models.Task>(task =>
        {
            task.ToTable("Task");
            task.HasKey(p => p.TaskId);
    
            task.HasOne(p => p.Categorie).WithMany(p=> p.Task).HasForeignKey(p=>p.CategoriId);

            task.Property(p=>p.Tittle).IsRequired().HasMaxLength(200);
            task.Property(p=>p.Description).IsRequired(false);
            task.Property(p=>p.PrioritiTask);
            task.Property(p=>p.CreationDate);
            task.Ignore(p => p.Resumen);

            task.HasData(tareasInit);


            
        });
    }
}