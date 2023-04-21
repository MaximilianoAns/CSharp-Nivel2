using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrimeraPruebadeApp
{
    class CelularData
    {
        public List<Celular> listar()
        {
            List<Celular> lista = new List<Celular>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database =DISCOS_DB; integrated security= true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Marca, FechaLanzamiento, UnidadesFabricadas, UrlImagenCelular from DISCOS;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Celular aux = new Celular();
                    aux.Marca = (string)lector["Marca"];
                    aux.FechaLanzamiento = (int)lector["FechaLanzamiento"];
                    aux.UnidadesFabricadas = (int)lector["UnidadesFabricadas"];
                    aux.UrlImagenCelular = (string)lector["UrlImagenCelular"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }






            

           


        }
        
     
	        
    }



        
}
