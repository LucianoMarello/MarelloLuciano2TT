using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialAlumno
{
    public class RepositorioAlumnos
    {
        private string connectionString;

        public RepositorioAlumnos(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Alumno> ListarAlumnos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();

            string consulta = "SELECT Id, Nombre, Edad FROM Alumno";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(consulta, connection);
                
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Alumno a = new Alumno();
                    a.Id = reader.GetInt32(0);
                    a.Nombre = reader.GetString(1);
                    a.Edad = reader.GetInt32(2);

                    listaAlumnos.Add(a);
                }

                reader.Close();
            }
            return listaAlumnos;
        }

        public void CrearAlumno(string nombre, int edad)
        {
            try
            {
                string consulta = "INSERT INTO Alumno (Nombre, Edad) VALUES (@Nombre, @Edad)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(consulta, connection);

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Edad", edad);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el alumno: " + ex.Message);
            }
        }

        public void ModificarAlumno(int id, string nombre, int edad)
        {
            string consulta = "UPDATE Alumno SET Nombre = @Nombre, Edad = @Edad WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(consulta, connection);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Edad", edad);
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        
        public void EliminarAlumno(int id)
        {
            string consulta = "DELETE FROM Alumno Where Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(consulta, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
