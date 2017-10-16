using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examen_01.Models
{
    public class Mecanico
    {
        [Key]
        public int idMecanico { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String nombre { get; set; }

        public ICollection<Registro> Registros { get; set; }
    }
}