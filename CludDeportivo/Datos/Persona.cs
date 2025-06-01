using CludDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace CludDeportivo.Datos
{
    internal class Persona
    {
        public string RegistrarPersona(E_Persona persona)
        {
            string mensaje;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoRegistro", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("nom", MySqlDbType.VarChar).Value = persona.Nombre;
                comando.Parameters.Add("ape", MySqlDbType.VarChar).Value = persona.Apellido;
                comando.Parameters.Add("doc", MySqlDbType.VarChar).Value = persona.DNI;
                comando.Parameters.Add("dire", MySqlDbType.VarChar).Value = persona.Direccion;
                comando.Parameters.Add("esSoc", MySqlDbType.Int16).Value = persona.EsSocio;
                comando.Parameters.Add("apFis", MySqlDbType.Int16).Value = persona.AptoFisico;
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();

                comando.ExecuteNonQuery();
                mensaje = Convert.ToString(ParCodigo.Value);

                return mensaje;
            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar persona: " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        // metodo para buscar una persona por su numero de dni
        public E_Persona ObtenerPersonaPorDni(string dni)
        {
            E_Persona persona = null;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM persona WHERE dni = @dni", sqlCon);
                comando.Parameters.AddWithValue("@dni", dni);

                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    persona = new E_Persona
                    {
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        DNI = reader["dni"].ToString(),
                        Direccion = reader["direccion"].ToString(),
                        EsSocio = Convert.ToBoolean(reader["socio"]),
                        AptoFisico = Convert.ToBoolean(reader["aptoFisico"]),
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener persona: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return persona;
        }
    }
}