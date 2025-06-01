using MySql.Data.MySqlClient;
using CludDeportivo.Entidades;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}


