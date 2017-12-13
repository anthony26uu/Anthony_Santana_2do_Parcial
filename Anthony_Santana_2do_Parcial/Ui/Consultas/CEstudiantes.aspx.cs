using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Anthony_Santana_2do_Parcial.Ui.Consultas
{
    public partial class CEstudiantes : System.Web.UI.Page
    {
        public static List<Entidades.Estudiantes> Lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            Utilidades.SCritpValidacion();

            Lista = BLL.BLLEstudiantes.GetListodo();
            Entidades.Asiganaturas entidad = new Entidades.Asiganaturas();

            if (Lista != null)
            {
                EstudiantesGrid.DataSource = Lista;
                EstudiantesGrid.DataBind();

            }
            else
            {
                Utilidades.ShowToastr(this, "NO EXISTEN REGISTROS", "ERROR", "info");
            }
        }
    }
}