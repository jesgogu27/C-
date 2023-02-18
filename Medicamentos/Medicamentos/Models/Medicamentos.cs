using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MedicamentosRC.Models
{
    public class Medicamentos
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = ("Nombre es Obligatorio"))]
        public string NombreMedicamento { get; set; }
        [Required(ErrorMessage = ("Fecha Recibido es Obligatorio"))]
        public DateTime FechaRecibido { get; set; }
        [Required(ErrorMessage = ("Favor Ingrese valor Unitario"))]
        public double Valor { get; set; }
        [Required(ErrorMessage = ("Favor Ingresar Cantidad"))]
        public int Cantidad { get; set; }
    }
}
