using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class MarcaBusiness
    {
        DataAccess dataAccess = new DataAccess();
        List<Marca> listaMarcas = new List<Marca>();

        public List<Marca> Listar()
        {
            string queryString = "SELECT Id, Descripcion FROM MARCAS";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.ExecuteQuery();

                listaMarcas.Clear();
                while (dataAccess.Reader.Read())
                {
                    Marca temp = new Marca();
                    temp.Id = (int)dataAccess.Reader["Id"];
                    temp.Descripcion = (string)dataAccess.Reader["Descripcion"];

                    listaMarcas.Add(temp);
                }
                return listaMarcas;
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
