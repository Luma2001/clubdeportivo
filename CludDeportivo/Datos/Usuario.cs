using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CludDeportivo.Datos
{
    internal class Usuario
    {
        //Método que retorna una tabla con la información
        public DataTable Log_Usu(string L_User, string P_User)//Este étodo consulta una base de datos y devuelve una tabla con la información del usuario si las credenciales son correctas
        {
            MySqlDataReader resultado; //variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("login", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                // Mostrar usuario y contraseña en consola para verificar que llegan correctamente
                MessageBox.Show("Usuario ingresado: " + L_User);
                MessageBox.Show("Contraseña ingresada: " + P_User);

                //Definimos los parámetros que tiene el procedure
                comando.Parameters.Add("usu", MySqlDbType.VarChar).Value = L_User;
                comando.Parameters.Add("pass", MySqlDbType.VarChar).Value = P_User;
                //Abrimos la conexión
                MessageBox.Show("Estado de conexión antes de abrir: " + sqlCon.State);
                sqlCon.Open();

                MessageBox.Show("Estado de la conexion después de abrir: " + sqlCon.State);

                resultado = comando.ExecuteReader(); //Almacenamos el resultado en la variable resultado
                tabla.Load(resultado); //se carga la tabla con la variable resultado
                MessageBox.Show("Cantidad de filas obtenidas: " + tabla.Rows.Count); // Verificar si se encontraron datos
                return tabla; //Ascociamos el método con el procedure que esta almacenado en MySQL

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new DataTable();
            }
            finally
            {
                if (sqlCon.State != System.Data.ConnectionState.Closed)

                {
                    sqlCon.Close();
                    MessageBox.Show("Conexión cerrada.");

                } //if(sqlCon.State == ConnectionState.Open{sqlCon.Close();}  otra forma de escribirlo
            }
        }
    }
}
