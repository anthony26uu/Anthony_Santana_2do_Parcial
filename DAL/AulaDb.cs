using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
  public  class AulaDb : DbContext
    {
        public AulaDb() : base("ConStr")
        {

        }


        public DbSet<Entidades.Profesores> profesoresDb { get; set; }
        public DbSet<Entidades.Estudiantes> estudiantesDb { get; set; }
        public DbSet<Entidades.Asiganaturas> asiganaturaDb { get; set; }
    }
}

