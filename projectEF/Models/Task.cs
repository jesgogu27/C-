using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;

namespace projectEF.Models;

public class Task
{
    //[Key]
    public Guid TaskId { get; set; }

    //[ForeignKey("CategoriId")]
    public Guid CategoriId { get; set; }

    //[Required]
    //[MaxLength(200)]
    public string Tittle { get; set; }

    public string Description { get; set; }

    public Priority PrioritiTask { get; set; }// prioridad

    public DateTime CreationDate { get; set; }

    public virtual Categorie Categorie { get; set; }

    //[NotMapped]
    public string Resumen { get; set; }
}
    public enum Priority
    {
        baja,
        media,
        alta,
    }