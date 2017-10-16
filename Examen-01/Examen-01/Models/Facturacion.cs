using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Examen_01.Models
{
    public class Facturacion
    {
        [Key]
        public int idFactura { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String NFactura { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FFactura { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int idRegistro { get; set; }
        [ForeignKey("idRegistro")]
        public virtual Registro registros { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public float totalCancelar { get; set; }
    }
}