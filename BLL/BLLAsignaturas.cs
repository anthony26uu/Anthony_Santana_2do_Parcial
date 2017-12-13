using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class BLLAsignaturas
    {




        public static bool Guardar(Asiganaturas nuevo)
        {
            bool retorno = false;

            using (var db = new Repositorio<Asiganaturas>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }
        public static bool Mofidicar(Asiganaturas existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Asiganaturas>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }


        public static bool Eliminar(Asiganaturas id)
        {
            bool resultado = false;
            using (var db = new Repositorio<Asiganaturas>())
            {
                resultado = db.Eliminar(id);

            }
            return resultado;
        }

        public static List<Asiganaturas> GetList(Expression<Func<Asiganaturas, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Asiganaturas>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

        public static Asiganaturas Buscar(Expression<Func<Asiganaturas, bool>> tipo)
        {
            Asiganaturas Result = null;
            using (var repoitorio = new Repositorio<Asiganaturas>())

            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }




        public static Asiganaturas BuscarB(int id)
        {

            Asiganaturas nuevo;
            using (var db = new AulaDb())
            {
                try
                {
                    nuevo = db.asiganaturaDb.Find(id);


                }
                catch (Exception)
                {

                    throw;
                }
                return nuevo;
            }
        }

        public static List<Asiganaturas> GetListodo()
        {

            using (var db = new Repositorio<Asiganaturas>())
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

        public static Asiganaturas BuscarRelacion(int id)
        {
            Asiganaturas estudiante = null;
            using (var conexion = new AulaDb())
            {
                try
                {
                    estudiante = conexion.asiganaturaDb.Find(id);
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
