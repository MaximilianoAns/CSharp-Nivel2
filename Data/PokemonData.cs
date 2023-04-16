using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Data
{
    public class PokemonData
    {
        // ESTRUCTURA Y METODOS PARA CONECTARSE A LA BASE DE DATOS

        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select P.Numero, P.Nombre, P.Descripcion, E.Descripcion Tipo, P.UrlImagen, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS D Where P.IdTipo = E.Id AND D.Id = P.IdDebilidad AND P.Activo = 1";
                comando.Connection = conexion;
                conexion.Open();
                
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //if (!lector.IsDBNull(lector.GetOrdinal("UrlImagen"))) ;
                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];

                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

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
        public List<Pokemon> filtrar (string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoData datos = new AccesoData();
            try
            {
                string consulta = "Select P.Numero, P.Nombre, P.Descripcion, E.Descripcion Tipo, P.UrlImagen, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS D Where P.IdTipo = E.Id AND D.Id = P.IdDebilidad AND P.Activo = 1 AND ";
                if (campo == "Numero")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Numero > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Numero < " + filtro;
                            break;
                        default:
                            consulta += "Numero = " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "P.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "P.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "P.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void agregar (Pokemon nuevo)
        {
            AccesoData datos = new AccesoData();
            try
            {
                datos.setearConsulta("Insert  into POKEMONS(Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen)  values(" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1, @IdTipo, @IdDebilidad, @urlImagen)");
                datos.ejecutarParametros("@UrlImagen", nuevo.UrlImagen);
                datos.ejecutarParametros("@IdTipo", nuevo.Tipo.Id);
                datos.ejecutarParametros("@IdDebilidad", nuevo.Debilidad.Id);
                datos.ejecutarAccion();
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
        public void modificar(Pokemon pokeMod)
        {
            AccesoData datos = new AccesoData();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @descripcion, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @IdDebilidad Where Id = @id");
                datos.ejecutarParametros("@numero", pokeMod.Numero);
                datos.ejecutarParametros("@nombre", pokeMod.Nombre);
                datos.ejecutarParametros("@descripcion", pokeMod.Descripcion);
                datos.ejecutarParametros("@img", pokeMod.UrlImagen);
                datos.ejecutarParametros("@idTipo", pokeMod.Tipo.Id);
                datos.ejecutarParametros("@idDebilidad", pokeMod.Debilidad.Id);
                datos.ejecutarParametros("@id", pokeMod.Id); 

                datos.ejecutarAccion();
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
        public void eliminar(int id)
        {
            try
            {
                AccesoData datos = new AccesoData();
                datos.setearConsulta("Delete from POKEMONS Where id = @id");
                datos.ejecutarParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void eliminarLogica(int id)
        {
            try
            {
                AccesoData datos = new AccesoData();
                datos.setearConsulta("update POKEMONS set Activo = 0 Where id = @id");
                datos.ejecutarParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
     // if (campo == "Numero")
     // {
     //     switch (criterio)
     //     {
     //         case "Mayor a":
     //             consulta += "Numero >" + filtro;
     //             break;
     //         case "Menor a":
     //             consulta += "Numero <" + filtro;
     //             break;
     //         default:
     //             consulta += "Numero =" + filtro;
     //             break;
     //     }
     // }
     // else
     // {
     //     switch (criterio)
     //     {
     //         case "Comienza con":
     //             consulta += "P.Descripcion like '" + filtro + "%'";
     //             break;
     //         case "Termina con":
     //             consulta += "P.Descripcion like'%" + filtro + "'";
     //             break;
     //         default:
     //             consulta += "P.Descripcion like '%" + filtro + "%'";
     //             break;
     //     }
     // }
     // datos.setearConsulta(consulta);
     // datos.ejecutarLectura();
     // while (datos.Lector.Read())
     // {
     //     Pokemon aux = new Pokemon();
     //     aux.Id = (int)datos.Lector["Id"];
     //     aux.Numero = (int)datos.Lector["Numero"];
     //     aux.Nombre = (string)datos.Lector["Nombre"];
     //     aux.Descripcion = (string)datos.Lector["Descripcion"];
     // 
     //     //if (!lector.IsDBNull(lector.GetOrdinal("UrlImagen"))) ;
     //     if (!(datos.Lector["UrlImagen"] is DBNull))
     //         aux.UrlImagen = (string)datos.Lector["UrlImagen"];
     // 
     //     aux.Tipo = new Elemento();
     //     aux.Tipo.Id = (int)datos.Lector["IdTipo"];
     //     aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
     // 
     //     aux.Debilidad = new Elemento();
     //     aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
     //     aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
     // 
     //     lista.Add(aux);
     // }
     // return lista;
     //             }
     //             catch (Exception ex)
     // {
     // 
     //     throw ex;
     // }  
     //         }