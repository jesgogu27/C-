using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace projectEF.Models;

public class Categorie
{
    //[Key]
    public Guid CategorieId { get; set; }

    //[Required]
    //[MaxLength(150)]
    public string Name { get; set; }

    public string Description { get; set; }
    
    public int Peso {get; set;}
    
    [JsonIgnore]
    public virtual ICollection<Task> Task { get; set; }
}