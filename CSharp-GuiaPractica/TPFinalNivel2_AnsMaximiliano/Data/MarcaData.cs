using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Data
{
    public  class MarcaData
    {
        public List<MarcaId> listar()
        {
            List<MarcaId> lista = new List<MarcaId>();
            AccesoData datos = new AccesoData();
            try
            {
                datos.ejecutarConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    MarcaId aux = new MarcaId();
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
