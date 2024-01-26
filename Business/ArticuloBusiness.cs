using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class ArticuloBusiness
    {
        DataAccess dataAccess = new DataAccess();
        List<Articulo> lista = new List<Articulo>();
        string queryString = string.Empty;

        public List<Articulo> ListarArticulos()
        {
            queryString = "SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Id as IdMarca, M.Descripcion as Marca, C.Id as IdCategoria, C.Descripcion as Categoria, ImagenUrl, Precio FROM ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.ExecuteQuery();
                lista.Clear();
                
                while (dataAccess.Reader.Read())
                {
                    Articulo temp = new Articulo();
                    temp.Id = (int)dataAccess.Reader["Id"];
                    temp.Codigo = (string)dataAccess.Reader["Codigo"];
                    temp.Nombre = (string)dataAccess.Reader["Nombre"];
                    temp.Descripcion = (string)dataAccess.Reader["Descripcion"];
                    temp.Marca = new Marca();
                    temp.Marca.Id = (int)dataAccess.Reader["IdMarca"];
                    temp.Marca.Descripcion = (string)dataAccess.Reader["Marca"];
                    temp.Categoria = new Categoria();
                    temp.Categoria.Id = (int)dataAccess.Reader["IdCategoria"];
                    temp.Categoria.Descripcion = (string)dataAccess.Reader["Categoria"];
                    if (!(dataAccess.Reader["ImagenUrl"] is DBNull))
                        temp.ImagenUrl = (string)dataAccess.Reader["ImagenUrl"];
                    temp.Precio = (decimal)dataAccess.Reader["Precio"];

                    lista.Add(temp);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess.CloseConnection();
            }
        }

        public void Agregar(Articulo nuevo)
        {
            queryString = $"INSERT INTO ARTICULOS VALUES ('{nuevo.Codigo}', '{nuevo.Nombre}', '{nuevo.Descripcion}', {nuevo.Marca.Id}, {nuevo.Categoria.Id}, '{nuevo.ImagenUrl}', {nuevo.Precio})";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess.CloseConnection();
            }
        }

        public void Modificar(Articulo modificado)
        {
            queryString = $"UPDATE ARTICULOS SET Codigo = '{modificado.Codigo}', Nombre = '{modificado.Nombre}', Descripcion = '{modificado.Descripcion}', IdMarca = {modificado.Marca.Id}, IdCategoria = {modificado.Categoria.Id}, ImagenUrl = '{modificado.ImagenUrl}', Precio = {modificado.Precio} WHERE Id = {modificado.Id}";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess.CloseConnection();
            }
        }
    }
}
