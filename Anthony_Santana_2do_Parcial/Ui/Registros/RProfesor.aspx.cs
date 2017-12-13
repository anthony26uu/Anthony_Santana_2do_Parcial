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
    public partial class RProfesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                LlenarDrop();
            }
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


        private void LlenarDrop()
        {
            List<Entidades.Asiganaturas> ListaDrop = BLL.BLLAsignaturas.GetListodo();

            TextBoxCurso.DataSource = ListaDrop;
            TextBoxCurso.DataValueField = "AsiganaturaId";
            TextBoxCurso.DataTextField = "Descripcion";
            TextBoxCurso.DataBind();


        }


        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        Profesores profesor = new Profesores();


        public Profesores LlenarCampos()
        {
            profesor.IdProfesores = Utilidades.TOINT(TextBoxID.Text);
            profesor.Nombre = TextBoxNombre.Text;
            profesor.Email = TexboEmail.Text;
            profesor.Cedula = TexboCedula.Text;
            profesor.Direccion = TextBoxDireccion.Text;
            profesor.FechaNacimiento = Convert.ToDateTime(TextFecha.Text);
            profesor.Sexo = DropSexo.Text;
            profesor.Telefono = TexboTelefono.Text;
            profesor.CursoImpartido = TextBoxCurso.Text;
            profesor.Sueldo = Convert.ToDecimal(TextBoxSueldo.Text);
            return profesor;
        }


        protected void ButtGuardar_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (IsValid)
            {

                profesor = LlenarCampos();


                if (id != profesor.IdProfesores)
                {

                    if (BLLProfesor.Mofidicar(profesor))
                    {
                        Utilidades.ShowToastr(this, "Se modifico Satisfactoriamente", "Correcto", "success");
                    }
                    else
                    {
                        Utilidades.ShowToastr(this, "No se pudo modificar", "Error", "Error");
                    }


                }
                else
                {

                    if (BLLProfesor.Guardar(profesor))
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
                var profesro = BLLProfesor.Buscar(p => p.IdProfesores == id);
                if (profesro != null)
                {

                    TextFecha.Text = profesro.FechaNacimiento.ToString("yyyy-MM-dd");
                    TextBoxNombre.Text = profesro.Nombre;
                    TextBoxDireccion.Text = profesro.Direccion;
                    DropSexo.Text = profesro.Sexo;
                    TexboEmail.Text = profesro.Email;
                    TexboCedula.Text = profesro.Cedula;
                    TexboTelefono.Text = profesro.Telefono;
                    TextBoxCurso.Text = profesro.CursoImpartido;
                    TextBoxSueldo.Text = profesro.Sueldo.ToString();
                    Utilidades.ShowToastr(this, "Resultados", "RESULTADOS", "success");

                }
                else
                {
                    Utilidades.ShowToastr(this, "No existe Profesor con ese ID", "ERROR", "error");

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
                var bll = new BLLProfesor();
                var profesor = BLLProfesor.Buscar(p => p.IdProfesores == id);
                if (BLLProfesor.Eliminar(profesor))
                {

                    Utilidades.ShowToastr(this, "Eliminado con exito", "CORRECTO", "success");

                    Limpiar();
                }
                else
                {

                    Utilidades.ShowToastr(this, "No se puedo eliminar ", "ERROR", "error");

                }
            }

        }
    }
}