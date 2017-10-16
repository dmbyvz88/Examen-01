using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examen_01.Models
{
    public class Repuestos
    {
        [Key]
        public int idRepuesto { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String nombre { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public float precio { get; set; }

        public ICollection<Registro> Registros { get; set; }
    }
}