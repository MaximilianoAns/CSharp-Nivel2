using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Data
{
   public class CategoriasData
   {
        public List<CategoriasId> listar()
        {
            List<CategoriasId> lista = new List<CategoriasId>();
            AccesoData datos = new AccesoData();
            try
            {
                datos.ejecutarConsulta("Select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    CategoriasId aux = new CategoriasId();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
   }
}




        
