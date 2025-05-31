using CludDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CludDeportivo
{
    public partial class ListaDeudores : Form
    {
        public ListaDeudores()
        {
            InitializeComponent();
        }

        private void ListaDeudores_Load(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        public void CargaGrilla()//recupera datos desde la BDD y los carga en el DataGrid View
        {
            //CREACIÓN DE LA CONEXIÓN A LA BASE DE DATOS
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                //OBTENCIÓN DE LA CONEXIÓN Y CONSULTA SQL
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "Select concat(p.nombre,' ', p.apellido) as SOCIO, c.fecha_vencimiento as VENCIMIENTO from persona p inner join cuota c on p.id = c.id_socio where c.fecha_vencimiento <= curdate() and pagado=false order by p.apellido;";
                //+
                //" where c.fecha_vencimiento <= curdate() and c.pagado=false order by p.apellido;";
                //PREPARACIÓN Y EJECUCIÓN DEL COMANDO SQL
                MySqlCommand comando = new MySqlCommand(query, sqlCon);// se crea un MySqlCommand con la consulta y la conexion
                comando.CommandType = CommandType.Text;//defino tipo de comando como texto
                sqlCon.Open();//se abre la conexión

                //EJECUCIÓN DE LA CONSULTA Y LECTURA DE DATOS
                MySqlDataReader reader;
                reader = comando.ExecuteReader();//se ejecuta consulta y los datos recuperados quedan en reader

                //CARGA DE DATOS EN EL DATAGRIDVIEW
                if (reader.HasRows)//se verifica si tiene registro
                {

                    while (reader.Read())
                    {
                        int reglon = planillaDeudores.Rows.Add();
                        planillaDeudores.Rows[reglon].Cells[0].Value = reader.GetString(0);//se asigna valores a cada celda
                        planillaDeudores.Rows[reglon].Cells[1].Value = reader.GetDateTime(1).ToString("yyyy-MM-dd");


                    }
                }
                else
                {
                    MessageBox.Show("NO HAY SOCIOS CON CUOTAS VENCIDAS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
                ;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void planillaDeudores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Form Cobrar = new Cobrar();
            Cobrar.ShowDialog();
        }
    }
}
