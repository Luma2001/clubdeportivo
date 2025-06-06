using CludDeportivo.Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace CludDeportivo
{
    public partial class Cobrar : Form
    {
        //instancia del comprobante
        public Comprobante comprobante = new Comprobante();

        public Cobrar()
        {
            InitializeComponent();
            CargarActividades();

            opSocio.Checked = true; // Inicializar como socio
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            comprobante.Show(); // Mostrar el formulario después de asignar valores
            comprobante.BringToFront(); // Asegura que esté en primer plano
            this.Hide();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                if (opSocio.Checked == true)
                {
                    query = "SELECT p.id, CONCAT(p.nombre, ' ', p.apellido) AS CLIENTE, p.direccion, c.fecha_vencimiento, c.monto " +
                       "FROM persona p " +
                       "INNER JOIN cuota c ON p.id = c.id_socio " +
                       "WHERE p.apellido = @apellido AND p.dni = @dni AND c.pagado=0";
                }
                else
                {
                    query = "SELECT p.id, CONCAT(p.nombre, ' ', p.apellido) AS CLIENTE, p.direccion, p.fecha_registro, a.costo " +
                        "FROM persona p INNER JOIN actividad a " +
                        "WHERE p.apellido = @apellido AND p.dni = @dni AND p.socio = 0 AND a.id = 1;";
                }

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);

                // Se agregan los parámetros para evitar errores y mejorar seguridad
                comando.Parameters.AddWithValue("@apellido", textApellido.Text);
                comando.Parameters.AddWithValue("@dni", txtDNI.Text);

                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    comprobante.numero_f = reader.GetInt32(0);
                    comprobante.cliente_f = reader.GetString(1);
                    comprobante.direccion_f = reader.GetString(2);
                    comprobante.fecha_f = reader.GetDateTime(3);
                    comprobante.monto_f = reader.GetFloat(4);

                    if (optEfvo.Checked == true)
                    {
                        comprobante.forma_f = "Efectivo";
                        comprobante.monto_f = (float)(comprobante.monto_f * 0.90);
                    }
                    else
                    {
                        comprobante.forma_f = "Tarjeta";
                    }

                    //_________________________________________________________________________________________

                    // Cerramos el lector antes de hacer otro comando
                    reader.Close();

                    string updateQuery;

                    // Consulta para actualizar la cuota
                    if (opSocio.Checked == true)
                    {
                        updateQuery = "UPDATE cuota SET pagado = true WHERE id_socio = (SELECT id FROM persona WHERE apellido = @apellido AND dni = @dni)";

                        // Crear el comando con la nueva consulta
                        MySqlCommand updateComando = new MySqlCommand(updateQuery, sqlCon);

                        // Agregar parámetros para evitar errores y ataques SQL
                        updateComando.Parameters.AddWithValue("@apellido", textApellido.Text);
                        updateComando.Parameters.AddWithValue("@dni", txtDNI.Text);

                        // Ejecutar la consulta
                        int filasAfectadas = updateComando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pago registrado correctamente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el pago", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { MessageBox.Show("Pago registrado correctamente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    //__________________________________________________________________________________________

                    btnComprobante.Enabled = true;
                }
                else
                {
                    // Consulta para insertar el pago
                    string insertQuery = "INSERT INTO pago (idPersona, monto, fecha) VALUES ((SELECT id FROM persona WHERE apellido = @apellido AND dni = @dni), @monto, @fecha)";

                    // Crear el comando
                    MySqlCommand insertComando = new MySqlCommand(insertQuery, sqlCon);

                    // Agregar parámetros
                    insertComando.Parameters.AddWithValue("@apellido", textApellido.Text);
                    insertComando.Parameters.AddWithValue("@dni", txtDNI.Text);
                    insertComando.Parameters.AddWithValue("@monto", comprobante.monto_f); // Usa el monto calculado
                    insertComando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd")); // Fecha actual en formato correcto

                    // Ejecutar la consulta
                    int filasInsertadas = insertComando.ExecuteNonQuery();

                    if (filasInsertadas > 0)
                    {
                        MessageBox.Show("Pago registrado correctamente en la tabla pago", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el pago en la tabla pago", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void CargarActividades()
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                // Abrir conexión
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                // Consulta SQL
                string query = "SELECT id, nombre, costo FROM actividad";

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                MySqlDataReader reader = command.ExecuteReader();

                // Limpiar combobox antes de cargar las actividades
                cboActividades.Items.Clear();

                // Leer resultados y agregar al combobox
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nombre = reader.GetString("nombre");
                    float costo = reader.GetFloat("costo");

                    cboActividades.Items.Add(new { ID = id, Nombre = nombre, Costo = costo });
                }

                cboActividades.DisplayMember = "Nombre"; // Motrar nombre
                cboActividades.ValueMember = "ID"; // Usar ID como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar actividades" + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void CambiarEstadoActividades(object sender, EventArgs e)
        {
            if (opSocio.Checked)
            {
                cboActividades.Enabled = false;
                lblActividad.ForeColor = SystemColors.ActiveCaption;
            }
            else if (opNoSocio.Checked)
            {
                cboActividades.Enabled = true;
                lblActividad.ForeColor = SystemColors.ControlText;
            }
        }
    }
}