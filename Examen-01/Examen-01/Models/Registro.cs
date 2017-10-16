using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Examen_01.Models
{
    public class Registro
    {
        [Key]
        public int idRegistro { get; set; }

        [Required(ErrorMessage = "Fecha requerida")]
        public DateTime fIngreso { get; set; }

        //[Required(ErrorMessage = "Este campo es requerido")]
        public int idAuto { get; set; }
        [ForeignKey("idAuto")]
        public virtual Auto autos { get; set; }

        //[Required(ErrorMessage = "Este campo es requerido")]
        public int idLabor { get; set; }
        [ForeignKey("idLabor")]
        public virtual Labor labores { get; set; }

        //[Required(ErrorMessage = "Este campo es requerido")]
        public int idRepuesto { get; set; }
        [ForeignKey("idRepuesto")]
        public virtual Repuestos repuestos { get; set; }

        //[Required(ErrorMessage = "Este campo es requerido")]
        public int cantidad { get; set; }

        //[Required(ErrorMessage = "Este campo es requerido")]
        public int idMecanico { get; set; }
        [ForeignKey("idMecanico")]
        public virtual Mecanico mecanicos { get; set; }

        public String observaciones { get; set; }

        public ICollection<Facturacion> Facturas { get; set; }
    }
}