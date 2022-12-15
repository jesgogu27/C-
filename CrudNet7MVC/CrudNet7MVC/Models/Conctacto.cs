using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models
{
    public class Conctacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage =("Nombre es Obligatorio"))]
        public string Name { get; set; }
        [Required(ErrorMessage =("Cargo es Obligatorio"))]
        public string Cargo { get; set; }
        [Required (ErrorMessage =("Celular es Obligatorio"))]
        public string Phone { get; set; }
        [Required (ErrorMessage = ("Email es Obligatorio"))]
        public string Email { get; set; }
        public DateTime FechaCreacion{ get; set; }

    }
}
