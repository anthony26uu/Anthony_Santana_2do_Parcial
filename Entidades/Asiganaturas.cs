using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Asiganaturas
    {
        [Key]
        public int AsiganaturaId { get; set; }
        public string Descripcion { get; set; }


        public Asiganaturas()
        {


        }

    }
}
