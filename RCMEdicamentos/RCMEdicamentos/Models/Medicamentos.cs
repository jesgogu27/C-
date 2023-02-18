using System.ComponentModel.DataAnnotations;

namespace RCMEdicamentos.Models
{
    public class Medicamentos
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = ("Por Favor Ingrese Nombre Medicamento"))]
        public string NombreMedicamento { get; set;}
        [Required(ErrorMessage = ("Por Favor Fecha Recibido"))]
        public DateTime FechaRecibido { get; set; }
        [Required(ErrorMessage = ("Por Favor Ingrese Valor"))]
        public double valor { get; set; }
        [Required(ErrorMessage = ("Por Favor Ingrese Cantidad"))]
        public int cantidad { get; set; }
    }
}
