using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class BLLEstudiantes
    {



        public static bool Guardar(Estudiantes nuevo)
        {
            bool retorno = false;

            using (var db = new Repositorio<Estudiantes>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }
        public static bool Mofidicar(Estudiantes existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Estudiantes>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }


        public static bool Eliminar(Estudiantes id)
        {
            bool resultado = false;
            using (var db = new Repositorio<Estudiantes>())
            {
                resultado = db.Eliminar(id);

            }
            return resultado;
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Estudiantes>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

        public static Estudiantes Buscar(Expression<Func<Estudiantes, bool>> tipo)
        {
            Estudiantes Result = null;
            using (var repoitorio = new Repositorio<Estudiantes>())

            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }




        public static Estudiantes BuscarB(int id)
        {

            Estudiantes nuevo;
            using (var db = new AulaDb())
            {
                try
                {
                    nuevo = db.estudiantesDb.Find(id);


                }
                catch (Exception)
                {

                    throw;
                }
                return nuevo;
            }
        }

        public static List<Estudiantes> GetListodo()
        {

            using (var db = new Repositorio<Estudiantes>())
            {
                try
                {
                    return db.ListaTodo();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public static Entidades.Estudiantes BuscarRelacion(int id)
        {
            Entidades.Estudiantes estudiante = null;
            using (var conexion = new AulaDb())
            {
                try
                {
                    estudiante = conexion.estudiantesDb.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return estudiante;
        }

    }
}
