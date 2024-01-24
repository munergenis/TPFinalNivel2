using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class CategoriaBusiness
    {
        DataAccess dataAccess = new DataAccess();
        List<Categoria> listaCategorias = new List<Categoria>();

        public List<Categoria> Listar()
        {
            string queryString = "SELECT Id, Descripcion FROM CATEGORIAS";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.ExecuteQuery();

                listaCategorias.Clear();
                while (dataAccess.Reader.Read())
                {
                    Categoria temp = new Categoria();
                    temp.Id = (int)dataAccess.Reader["Id"];
                    temp.Descripcion = (string)dataAccess.Reader["Descripcion"];
                    
                    listaCategorias.Add(temp);
                }
                return listaCategorias;
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
