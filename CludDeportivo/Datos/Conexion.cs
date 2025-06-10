using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;//referemcia al conector

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
        private static readonly string rutaConfig = "config.ini";

        private Conexion()
        {
            if (File.Exists(rutaConfig))
            {
                // Leer desde el archivo
                var lines = File.ReadAllLines(rutaConfig);
                foreach (var line in lines)
                {
                    if (line.Contains("="))
                    {
                        var parts = line.Split('=');
                        switch (parts[0].Trim())
                        {
                            case "servidor": this.servidor = parts[1].Trim(); break;
                            case "puerto": this.puerto = parts[1].Trim(); break;
                            case "usuario": this.usuario = parts[1].Trim(); break;
                            case "clave": this.clave = parts[1].Trim(); break;
                            case "basedatos": this.baseDatos = parts[1].Trim(); break;
                        }
                    }
                }

                return; // Salir porque ya se tienen los datos
            }

            // Si no hay archivo, pedir los datos
            bool correcto = false;
            int mensaje;

            // variables para recibir datos desde el teclado
            string T_baseDatos = "";
            string T_servidor = "";
            string T_puerto = "";
            string T_usuario = "";
            string T_clave = "";

            while (!correcto)
            {
                // Cuadros de dialogo para ingreso de datos
                T_servidor = Interaction.InputBox("Ingrese el servidor (por defecto: localhost)", "Conexión DB", "localhost");
                T_puerto = Interaction.InputBox("Ingrese el puerto (por defecto: 3306)", "Conexión DB", "3306");
                T_baseDatos = Interaction.InputBox("Ingrese la base de datos (por defecto: clubdeportivo)", "Conexión DB", "clubdeportivo");
                T_usuario = Interaction.InputBox("Ingrese el usuario (por defecto: root)", "Conexión DB", "root");
                T_clave = Interaction.InputBox("Ingrese la clave (por defecto: <vacío>)", "Conexión DB", "");

                // Aplicar valores por defecto si están vacíos
                if (string.IsNullOrWhiteSpace(T_servidor)) T_servidor = "localhost";
                if (string.IsNullOrWhiteSpace(T_puerto)) T_puerto = "3306";
                if (string.IsNullOrWhiteSpace(T_baseDatos)) T_baseDatos= "clubdeportivo";
                if (string.IsNullOrWhiteSpace(T_usuario)) T_usuario = "root";
                if (string.IsNullOrWhiteSpace(T_clave)) T_clave = "";

                mensaje = (int)MessageBox.Show(
                   $"Datos ingresados:\nSERVIDOR= {T_servidor}\nPUERTO= {T_puerto}\nBASE DE DATOS= {T_baseDatos}\nUSUARIO= {T_usuario}\nCLAVE = {T_clave}\n\n¿Los datos son correctos?",
                   "Aviso del sistema",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

                if (mensaje != 6) // valor 6 corresponde a SI
                {
                    MessageBox.Show("Ingrese nuevamente los datos");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            // Actualizar variables de conexión por datos obtenidos por teclado
            this.servidor = T_servidor;
            this.puerto = T_puerto;
            this.baseDatos = T_baseDatos;
            this.usuario = T_usuario;
            this.clave = T_clave;

            using (StreamWriter writer = new StreamWriter(rutaConfig))
            {
                writer.WriteLine($"servidor={T_servidor}");
                writer.WriteLine($"puerto={T_puerto}");
                writer.WriteLine($"basedatos={T_baseDatos}");
                writer.WriteLine($"usuario={T_usuario}");
                writer.WriteLine($"clave={T_clave}");
            }
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
            catch (Exception ex)
            {
                cadena = null;
                throw new Exception("Error al crear la conexión: " + ex.Message);
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