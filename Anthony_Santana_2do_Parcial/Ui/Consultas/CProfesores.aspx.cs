using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Anthony_Santana_2do_Parcial.Ui.Consultas
{
    public partial class CProfesores : System.Web.UI.Page
    {

        public static List<Entidades.Profesores> Lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            Utilidades.SCritpValidacion();

            Lista = BLL.BLLProfesor.GetListodo();
            Entidades.Profesores entidad = new Entidades.Profesores();

            if (Lista != null)
            {
                ProfesoresGrid.DataSource = Lista;
                ProfesoresGrid.DataBind();

            }
            else
            {
                Utilidades.ShowToastr(this, "NO EXISTEN REGISTROS", "ERROR", "info");
            }

        }
    }
}