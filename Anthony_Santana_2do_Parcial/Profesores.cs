using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesores
    {
        [Key]
        public int IdProfesores { get; set; }
        public string Nombre { get; set; }
        public string CursoImpartido { get; set; }
        public double Sueldo { get; set; }


        public Profesores()
        {


        }

        public Profesores(int id, string nombre, string curso, double sueldo)
        {
            this.IdProfesores = id;
            this.Nombre = nombre;
            this.CursoImpartido = curso;
            this.Sueldo = sueldo;
        }
    }
}
