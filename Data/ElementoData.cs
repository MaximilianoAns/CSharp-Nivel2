using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Data
{
    public class ElementoData
    {
        //ACA VAMOS A CREAR LAS FUNCIONES , CADENA DE CONEXIO, LECTOR Y CONSULTA SQL
        public List<Elemento> listar ()
        {
            List<Elemento> lista = new List<Elemento>();
            AccesoData datos = new AccesoData();
            try
            {
                datos.setearConsulta("Select Id, Descripcion from ELEMENTOS");
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }


          



            
        }



    }
}
