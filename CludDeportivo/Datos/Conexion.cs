using MySql.Data.MySqlClient;//referemcia al conector
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CludDeportivo.Datos
{
    internal class Conexion
    {
        //Atributos
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            this.baseDatos = "clubdeportivo";
            this.servidor = "localhost";
            this.puerto = "3307";
            this.usuario = "root";
            this.clave = "";
        }

        public MySqlConnection CrearConexion()
        {
            //instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();

            //Controlamos errores
            try
            {
                cadena.ConnectionString = $"datasource = {this.servidor}; \nport= {this.puerto}; \nusername = {this.usuario}; \npassword = {this.clave}; \nDatabase = {this.baseDatos}";
            }
            catch (Exception)
            {
                cadena = null;
                throw;
            }

            return cadena;

        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }


    }
}
