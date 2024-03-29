using System.ComponentModel.DataAnnotations;

namespace WebRazor.Models;

public class Pizza{

    public int Id{get; set;}

    [Required]
    public string? Name {get; set;}
    public PizzaSize Size {get; set;}
    public bool IsGlutenFree {get; set;}

    [Range(0.01, 999.99)]
    public decimal Price {get; set;}
    
}
public enum PizzaSize{Small, Medium, Large}