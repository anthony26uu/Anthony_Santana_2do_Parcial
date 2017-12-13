using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Anthony_Santana_2do_Parcial.Ui.Consultas
{
    public partial class CAsignaturas : System.Web.UI.Page
    {
        public static List<Entidades.Asiganaturas> Lista { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            Utilidades.SCritpValidacion();

            Lista = BLL.BLLAsignaturas.GetListodo();
            Entidades.Asiganaturas entidad = new Entidades.Asiganaturas();

            if(Lista!=null)
            {
                AsiganturasGrid.DataSource = Lista;
                AsiganturasGrid.DataBind();

            }
            else
            {
                Utilidades.ShowToastr(this, "NO EXISTEN REGISTROS", "ERROR", "info");
            }
           
        }
    }
}