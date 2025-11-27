using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ProyectoADO
{
    public class RepositorioMaterias
    {
        private List<Materia> listaMaterias;
        private string conexion = "Initial Catalog=Universidad;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;";
        public RepositorioMaterias()
        {
            listaMaterias = new List<Materia>();
        }
        public string Agregar(Materia materia)
        {
            string query = "INSERT INTO Materia(Nombre, cantidadHoras) VALUES" + "(@Nombre, @Horas)";
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@Nombre", materia.Nombre);
                    comando.Parameters.AddWithValue("@Horas", materia.CantidadHoras);

                    comando.ExecuteNonQuery();
                    conn.Close();
                }

                return "Materia agregada";
            }
            catch (Exception ex) 
            {
                throw new Exception("Error: " + ex);
            }
        }
        public List<Materia> Listar()
        {
            string query = "select * from Materia";
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Materia unaMateria = new Materia();

                        unaMateria.Id = int.Parse(reader["Id"].ToString());
                        unaMateria.Nombre = reader["Nombre"].ToString();
                        unaMateria.CantidadHoras = int.Parse(reader["cantidadHoras"].ToString());

                        listaMaterias.Add(unaMateria);
                    }
                    conn.Close();
                    return listaMaterias;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocurrio algo relacionado con la BD" + ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: "+ ex);
            }
        }
    }
}
