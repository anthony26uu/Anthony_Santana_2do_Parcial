﻿using System;
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
        public decimal Sueldo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string CursoImpartido { get; set; }
        public string Sexo { get; set; }



        public Profesores()
        {


        }

       
    }
}
