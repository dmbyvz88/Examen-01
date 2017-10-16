using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examen_01.Models
{
    public class Auto
    {
        [Key]
        public int idAuto { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String marca { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String modelo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public String placa { get; set; }

        public ICollection<Registro> Registros { get; set; }
    }
}