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
    public partial class REstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Utilidades.SCritpValidacion();



        }

        private void Limpiar()
        {
            TextBoxNombre.Text = "";
            TextBoxCurso.Text = "";
            TextBoxDireccion.Text = "";
            TexboTelefono.Text = "";
            TextBoxID.Text = "";
            TexboCedula.Text = "";
            TexboEmail.Text = "";
            TextFecha.Text = "";
            DropSexo.Text = "";

        }

      

        Estudiantes estudianteg = new Estudiantes();


        public Estudiantes LlenarCampos()
        {
            estudianteg.IdEstudiante = Utilidades.TOINT(TextBoxID.Text);
            estudianteg.Nombre = TextBoxNombre.Text;
            estudianteg.Email = TexboEmail.Text;
            estudianteg.Cedula = TexboCedula.Text;
            estudianteg.Direccion = TextBoxDireccion.Text;
            estudianteg.FechaNacimiento = Convert.ToDateTime(TextFecha.Text);
            estudianteg.Sexo = DropSexo.Text;
            estudianteg.Telefono = TexboTelefono.Text;
            estudianteg.Curso = TextBoxCurso.Text;
            return estudianteg;
        }
                  protected void ButtGuardar_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (IsValid)
            {

                estudianteg = LlenarCampos();


                if (id != estudianteg.IdEstudiante)
                {

                    if (BLLEstudiantes.Mofidicar(estudianteg))
                    {
                        Utilidades.ShowToastr(this, "Se modifico elcliente Satisfactoriamente", "Correcto", "success");
                    }
                    else
                    {
                        Utilidades.ShowToastr(this, "No se pudo modificar", "Error", "Error");
                    }


                }
                else
                {

                    if (BLLEstudiantes.Guardar(estudianteg))
                    {
                        Utilidades.ShowToastr(this, " Agregado", "Correcto", "success");
                    }
                    else
                    {
                        Utilidades.ShowToastr(this, "No se agrego", "Error", "error");

                    }


                }

            }
            Limpiar();

        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void ButtGuardar_Click1(object sender, EventArgs e)
        {
            int id = 0;

            if (IsValid)
            {

                estudianteg = LlenarCampos();


                if (id != estudianteg.IdEstudiante)
                {

                    if (BLLEstudiantes.Mofidicar(estudianteg))
                    {
                        Utilidades.ShowToastr(this, "Se modifico elcliente Satisfactoriamente", "Correcto", "success");
                    }
                    else
                    {
                        Utilidades.ShowToastr(this, "No se pudo modificar", "Error", "Error");
                    }


                }
                else
                {

                    if (BLLEstudiantes.Guardar(estudianteg))
                    {
                        Utilidades.ShowToastr(this, " Agregado", "Correcto", "success");
                    }
                    else
                    {
                        Utilidades.ShowToastr(this, "No se agrego", "Error", "error");

                    }


                }

            }
            Limpiar();


        }

        protected void BotonBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxID.Text))
            {


                Utilidades.ShowToastr(this, "Llene Campo   id", "CONSEJO", "info");

                Limpiar();
            }
            else

            {

                int id = int.Parse(TextBoxID.Text);
                var estudiante = BLLEstudiantes.Buscar(p => p.IdEstudiante == id);
                if (estudiante != null)
                {

                    TextFecha.Text = estudiante.FechaNacimiento.ToString("yyyy-MM-dd");
                    TextBoxNombre.Text = estudiante.Nombre;
                    TextBoxDireccion.Text = estudiante.Direccion;
                    DropSexo.Text = estudiante.Sexo;
                    TexboEmail.Text = estudiante.Email;
                    TexboCedula.Text = estudiante.Cedula;
                    TexboTelefono.Text = estudiante.Telefono;
                    TextBoxCurso.Text = estudiante.Curso;
                    Utilidades.ShowToastr(this, "Resultados", "RESULTADOS", "success");

                }
                else
                {
                    Utilidades.ShowToastr(this, "No existe Estudiante con ese ID", "ERROR", "error");

                    Limpiar();

                }
            }

        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(TextBoxID.Text))
            {

                Utilidades.ShowToastr(this, "Llene campo Id ", "Consejo", "info");


                Limpiar();


            }
            else
            {
                int id = int.Parse(TextBoxID.Text);
                var bll = new BLLEstudiantes();
                var estudiante = BLLEstudiantes.Buscar(p => p.IdEstudiante == id);
                if (BLLEstudiantes.Eliminar(estudiante))
                {

                    Utilidades.ShowToastr(this, "Estudiante Eliminado con exito", "CORRECTO", "success");

                    Limpiar();
                }
                else
                {

                    Utilidades.ShowToastr(this, "No se puedo eliminar el estudiante", "ERROR", "error");

                }
            }


        }

        protected void ButtonNuevo_Click1(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

