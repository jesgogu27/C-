using Microsoft.EntityFrameworkCore;
using projectEF;
using Microsoft.AspNetCore.Mvc;
using projectEF.Models;
using Task = projectEF.Models.Task;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<TaskContext>(p => p.UseInMemoryDatabase("TaskDB"));
builder.Services.AddSqlServer<TaskContext>(builder.Configuration.GetConnectionString("cnTareas"));

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] TaskContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.MapGet("/Api/Task", async([FromServices] TaskContext dbContext) =>
{
    return Results.Ok(dbContext.Tasks.Include(p=> p.Categorie));
});

//.Where(p=> p.PrioritiTask == projectEF.Models.Priority.alta)

app .MapPost("/Api/Task", async([FromServices] TaskContext dbContext, [FromBody] projectEF.Models.Task task) =>
{
   task.TaskId = Guid.NewGuid();
   task.CreationDate = DateTime.Now;
   await dbContext.AddAsync(task);

   await dbContext.SaveChangesAsync();

   return Results.Ok();

});

app.MapPut("/Api/Task/{id}", async([FromServices] TaskContext dbContext,[FromBody] Task task,[FromRoute] Guid id) =>
{
   var tareaActual = dbContext.Tasks.Find(id);
   
   if(tareaActual != null)
   {
    tareaActual.CategoriId   = task.CategoriId;
    tareaActual.Tittle       = task.Tittle;
    tareaActual.PrioritiTask = task.PrioritiTask;
    tareaActual.Description  = task.Description;

    await dbContext.SaveChangesAsync();
    return Results.Ok("hecho");
   }
   return Results.NotFound();

});

app.MapDelete("/Api/Task/{id}", async ([FromServices] TaskContext dbContext, [FromRoute] Guid id) =>
{
    var registroActual =  dbContext.Tasks.Find(id);

    if(registroActual != null)
    {
        dbContext.Remove(registroActual);
        await dbContext.SaveChangesAsync();

        return Results.Ok("Registro Eliminado");
    }
    return Results.NotFound();
});


app.Run();
