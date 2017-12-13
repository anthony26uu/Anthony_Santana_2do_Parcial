using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Anthony_Santana_2do_Parcial.Ui.Registros
{
    public partial class RAsignatura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Utilidades.SCritpValidacion();
        }

        private void Limpiar()
        {
            RequiredFieldValidator1.Text = "";
            RequiredFieldValidator2.Text = "";
            Textnombre.Text = "";
            Textid.Text = "";
        }

        Asiganaturas Asiganaturasg = new Asiganaturas();
        public Asiganaturas LlenarCampos()
        {
            Asiganaturasg.AsiganaturaId = Utilidades.TOINT(Textid.Text);
            Asiganaturasg.Descripcion = Textnombre.Text;
            return Asiganaturasg;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {

            int id = 0;

            if (IsValid)
            {

                Asiganaturasg = LlenarCampos();


                if (id != Asiganaturasg.AsiganaturaId)
                {

                    if (BLLAsignaturas.Mofidicar(Asiganaturasg))
                    {
                        Utilidades.ShowToastr(this, "Modificado con exito", "CORRECTO", "success");

                    }
                    else
                    {
                        Utilidades.ShowToastr(this, "No se modifico", "ERROR", "error");

                    }


                }
                else
                {

                    if (BLLAsignaturas.Guardar(Asiganaturasg))
                    {

                        Utilidades.ShowToastr(this, "Agregada correctamente", "CORRECTO", "success");

                    }
                    else
                    {
                        Utilidades.ShowToastr(this, "Error al guardar", "ERROR", "error");

                    }


                }

            }
            Limpiar();
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {

            Entidades.Profesores Usada = BLL.BLLProfesor.Buscar(p => p.CursoImpartido == Textnombre.Text);
            if (Usada != null)
            {
                Utilidades.ShowToastr(this, "No puede eliminar este elemento esta siendo usado ", "ERROR", "error");
                Limpiar();
            }
            else
            {

                if (string.IsNullOrWhiteSpace(Textid.Text))
                {
                    Utilidades.ShowToastr(this, "Capo Vacio", "ERROR", "error");

                    Limpiar();


                }
                else
                {
                    int id = int.Parse(Textid.Text);

                    var cate = BLLAsignaturas.Buscar(p => p.AsiganaturaId == id);
                    if (cate != null)
                    {
                        BLLAsignaturas.Eliminar(cate);
                        Utilidades.ShowToastr(this, "Se ha Eliminado con exito", "CORRECTO", "success");

                        Limpiar();
                    }

                    else
                    {
                        Utilidades.ShowToastr(this, "No se pudo eliminar ", "ERROR", "error");

                        Limpiar();
                    }
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void Button1Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Textid.Text))
            {

                Utilidades.ShowToastr(this, "Campo Vacio", "ERROR", "error");

                Limpiar();
            }
            else

            {

                int id = int.Parse(Textid.Text);
                var asig = BLLAsignaturas.Buscar(p => p.AsiganaturaId == id);
                if (asig != null)
                {


                    Textnombre.Text = asig.Descripcion;
                    Utilidades.ShowToastr(this, "Sus Resultados", "CORRECTO", "success");




                }
                else
                {
                    Utilidades.ShowToastr(this, "No existe asignatura con este ID", "ERROR", "error");
                    Limpiar();

                }
            }

        }
    }
}