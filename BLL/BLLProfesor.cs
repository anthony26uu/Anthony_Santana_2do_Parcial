using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class BLLProfesor
    {



        public static bool Guardar(Profesores nuevo)
        {
            bool retorno = false;

            using (var db = new Repositorio<Profesores>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }
        public static bool Mofidicar(Profesores existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Profesores>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }


        public static bool Eliminar(Profesores id)
        {
            bool resultado = false;
            using (var db = new Repositorio<Profesores>())
            {
                resultado = db.Eliminar(id);

            }
            return resultado;
        }

        public static List<Entidades.Profesores> GetList(Expression<Func<Entidades.Profesores, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Profesores>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

        public static Profesores Buscar(Expression<Func<Profesores, bool>> tipo)
        {
            Profesores Result = null;
            using (var repoitorio = new Repositorio<Profesores>())

            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }




        public static Entidades.Profesores BuscarB(int id)
        {

            Entidades.Profesores nuevo;
            using (var db = new AulaDb())
            {
                try
                {
                    nuevo = db.profesoresDb.Find(id);


                }
                catch (Exception)
                {

                    throw;
                }
                return nuevo;
            }
        }

        public static List<Entidades.Profesores> GetListodo()
        {

            using (var db = new DAL.Repositorio<Profesores>())
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

        public static Entidades.Profesores BuscarRelacion(int id)
        {
            Profesores estudiante = null;
            using (var conexion = new AulaDb())
            {
                try
                {
                    estudiante = conexion.profesoresDb.Find(id);
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
