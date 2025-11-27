using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploParcialSocios
{
    public class RepositorioSocios
    {
        private string connectionString;

        public RepositorioSocios(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Socio> ListarSocios()
        {
            List<Socio> listaSocios = new List<Socio>();

            string consulta = "SELECT * FROM Socios";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(consulta, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Socio s = new Socio();
                    s.Id = reader.GetInt32(0);
                    s.Nombre = reader.GetString(1);
                    s.Apellido = reader.GetString(2);
                    s.Dni = reader.GetString(3);
                    s.Fecha_nacimiento = reader.GetDateTime(4);
                    s.Numero_socio = reader.GetInt32(5);
                    s.Cuota_al_dia = reader.GetBoolean(6);

                    listaSocios.Add(s);
                }
                reader.Close();
            }
            return listaSocios;
        }

        public void AgregarSocio(string nombre, string apellido, string dni, DateTime fecha, int numSocio, bool cuota)
        {
            string consulta = "INSERT INTO Socios (nombre, apellido, dni, fecha_nacimiento, numero_socio, cuota_al_dia)" +
                "VALUES (@Nombre, @Apellido, @Dni, @FechaNacimiento, @NumeroSocio, @Cuota)";
            //SELECT CAST(SCOPE_IDENTITY() as int)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(consulta, connection);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fecha);
                cmd.Parameters.AddWithValue("@NumeroSocio", numSocio);
                cmd.Parameters.AddWithValue("@Cuota", cuota);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarSocio(int id, string nombre, string apellido, string dni, DateTime fecha, int numSocio, bool cuota)
        {
            string consulta = "UPDATE Socios SET " +
                "nombre = @Nombre, apellido = @Apellido, dni = @Dni," +
                "fecha_nacimiento = @Fecha, numero_socio = @Num," +
                "cuota_al_dia = @Cuota WHERE id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(consulta, connection);

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Num", numSocio);
                cmd.Parameters.AddWithValue("@Cuota", cuota);
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarSocio(int id)
        {
            string consulta = "DELETE FROM Socios WHERE id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(consulta, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int CuotaAlDia()
        {
            List<Socio> lista = ListarSocios();
            int contador = 0;
            foreach(Socio s in lista)
            {
                if (s.Cuota_al_dia) contador++;
            }
            return contador;
        }
    }
}
