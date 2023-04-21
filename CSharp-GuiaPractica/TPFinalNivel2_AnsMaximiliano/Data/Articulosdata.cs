using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Data
{
   public class Articulosdata
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoData datos = new AccesoData();

            try
            {
                datos.ejecutarConsulta("Select Codigo, Nombre , A.Descripcion , A.ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca, A.IdCategoria, A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C  Where M.Id = A.IdMarca AND C.Id = A.IdCategoria");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new MarcaId();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new CategoriasId();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

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
        public void agregar (Articulos nuevoArticulo)
        {
            AccesoData datos = new AccesoData();
            try
            {
                datos.ejecutarConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria) values ('" + nuevoArticulo.Codigo + "', '" + nuevoArticulo.Nombre + "', '" + nuevoArticulo.Descripcion + "', @ImagenUrl , " + nuevoArticulo.Precio + ", @IdMarca, @IdCategoria)");
               
                datos.setearParametros("@IdMarca", nuevoArticulo.Marca.Id);
                datos.setearParametros("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.setearParametros("@ImagenUrl", nuevoArticulo.ImagenUrl);
                datos.ejecutarInsert();
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
        public void modificar(Articulos modificarArticulo)
        {
            AccesoData datos = new AccesoData();
            try
            {
                datos.ejecutarConsulta("Update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio Where id = @id");
                datos.setearParametros("@codigo", modificarArticulo.Codigo);
                datos.setearParametros("@nombre", modificarArticulo.Nombre);
                datos.setearParametros("@descripcion", modificarArticulo.Descripcion);
                datos.setearParametros("@idMarca", modificarArticulo.Marca.Id);
                datos.setearParametros("@idCategoria", modificarArticulo.Categoria.Id);
                datos.setearParametros("@imagenUrl", modificarArticulo.ImagenUrl);
                datos.setearParametros("@precio", modificarArticulo.Precio);
                datos.setearParametros("id", modificarArticulo.Id);

                datos.ejecutarInsert();
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
                datos.ejecutarConsulta("Delete from ARTICULOS  Where id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarInsert();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Articulos> filtrar (string campo, string criterio, string filtro)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoData datos = new AccesoData();
            
            try
            {
                string consulta = "Select A.Codigo, A.Nombre, A.Descripcion , A.ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca, A.IdCategoria, A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C  Where M.Id = A.IdMarca AND C.Id = A.IdCategoria AND ";
                if(campo == "Código")
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "Codigo like'" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Codigo like '%" + filtro + "%'";
                            break;
                        default:
                            consulta += "Codigo like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "Nombre like'" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "%'";
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
                        case "Empieza con":
                            consulta += "A.Descripcion like '" + filtro + "%' ";
                                                      
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion like '%" + filtro + "%'";
                            break;
                        default:
                            consulta += "A.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                    




                }
                datos.ejecutarConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new MarcaId();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new CategoriasId();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }


    }

}
