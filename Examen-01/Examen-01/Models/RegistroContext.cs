using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Examen_01.Models
{
    public class RegistroContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RegistroContext() : base("name=RegistroContext")
        {
        }

        public System.Data.Entity.DbSet<Examen_01.Models.Registro> Registroes { get; set; }

        public System.Data.Entity.DbSet<Examen_01.Models.Auto> Autoes { get; set; }

        public System.Data.Entity.DbSet<Examen_01.Models.Labor> Labors { get; set; }

        public System.Data.Entity.DbSet<Examen_01.Models.Mecanico> Mecanicoes { get; set; }

        public System.Data.Entity.DbSet<Examen_01.Models.Repuestos> Repuestos { get; set; }
    }
}
