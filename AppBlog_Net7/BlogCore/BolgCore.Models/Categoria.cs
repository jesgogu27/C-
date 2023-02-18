using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolgCore.Models
{
    public  class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "Ingrese un Nombre De Categoria")]
        [Display(Name = "Nombre Categoria")]
        public string Nombre { get; set; }
        [Display(Name = "Orden de Visualización")]
        public int? Orden { get;set; }

    }
}
