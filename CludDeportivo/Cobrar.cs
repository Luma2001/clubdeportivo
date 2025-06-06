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
            if (!float.TryParse(lblMontoAPagarValue.Text, out float monto) || monto <= 0)
            {
                MessageBox.Show("No hay un monto válido para pagar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsPagoValido(out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();

            try
            {
                sqlCon.Open();

                if (opSocio.Checked)
                {
                    // Registrar pago de cuota para socios
                    string updateQuery = "UPDATE cuota SET pagado = true WHERE id_socio = (SELECT id FROM persona WHERE dni = @dni)";

                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, sqlCon);

                    updateCommand.Parameters.AddWithValue("@dni", txtDNI.Text);

                    int filasAfectadas = updateCommand.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Pago registrado correcamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDNI.Text = "";
                        lblCliente.Text = "Cliente: -";
                        lblMontoAPagarValue.Text = "0,00";
                    }
                    else
                    {
                        MessageBox.Show("No se encontró cuota pendiente para este socio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Registro de pago de actividad para no socios
                    int idActividadSeleccionada = ((dynamic)cboActividades.SelectedItem).ID;

                    string insertQuery = "INSERT INTO pago (idPersona, monto, fecha) VALUES ((SELECT id FROM persona WHERE dni = @dni), @monto, @fecha)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, sqlCon);

                    insertCommand.Parameters.AddWithValue("@dni", txtDNI.Text);
                    insertCommand.Parameters.AddWithValue("@monto", monto);
                    insertCommand.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                    /* insertCommand.Parameters.AddWithValue("@idActividad", idActividadSeleccionada); */

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Pago registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnComprobante.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ActualizarMontoAPagar();
            if (opSocio.Checked)
            {
                cboActividades.Enabled = false;
                cboActividades.SelectedIndex = -1;
                lblActividad.ForeColor = SystemColors.ActiveCaption;
            }
            else if (opNoSocio.Checked)
            {
                cboActividades.Enabled = true;
                lblActividad.ForeColor = SystemColors.ControlText;
            }
        }

        private void ActualizarMontoAPagar()
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();

            bool isSocio = opSocio.Checked;
            string nombreCliente = "";

            try
            {
                string query;
                if (isSocio)
                {
                    // Consulta para socios: traer monto de cuota pendiente
                    query = "SELECT c.monto, CONCAT(p.nombre, ' ', p.apellido) AS Nombre FROM persona p INNER JOIN cuota c ON p.id = c.id_socio WHERE p.dni = @dni AND c.pagado = 0";
                }
                else
                {
                    // Para no socios: validar que haya actividad seleccionada
                    if (cboActividades.SelectedItem == null)
                    {
                        lblMontoAPagarValue.Text = "0,00";
                        lblCliente.Text = "Cliente: -";
                        return;
                    }

                    int idActividadSeleccionada = ((dynamic)cboActividades.SelectedItem).ID;

                    // Consulta para traer costo de actividad
                    query = "SELECT a.costo, CONCAT(p.nombre, ' ', p.apellido) AS Nombre FROM persona p INNER JOIN actividad a WHERE p.dni = @dni AND p.socio = 0 AND a.id = @idActividad";
                }

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@dni", txtDNI.Text);

                if (!isSocio)
                {
                    int idActividadSeleccionada = ((dynamic)cboActividades.SelectedItem).ID;
                    command.Parameters.AddWithValue("@idActividad", idActividadSeleccionada);
                }

                sqlCon.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    float monto = Convert.ToSingle(reader.GetValue(isSocio ? "monto" : "costo"));
                    nombreCliente = reader["Nombre"].ToString();
                    lblMontoAPagarValue.Text = monto.ToString("F2");
                }
                else
                {
                    lblMontoAPagarValue.Text = "0,00";
                    nombreCliente = "-";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el monto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMontoAPagarValue.Text = "0,00";
                nombreCliente = "-";
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            lblCliente.Text = "Cliente: " + nombreCliente;

            // Habilitar btnPagar solo si hay datos válidos
            btnPagar.Enabled = !string.IsNullOrEmpty(nombreCliente) && !nombreCliente.Equals("-") &&
                                  (isSocio && lblMontoAPagarValue.Text != "0.00") ||
                                  (!isSocio && cboActividades.SelectedIndex >= 0);
        }

        private void cboActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opNoSocio.Checked)
            {
                ActualizarMontoAPagar();
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            ActualizarMontoAPagar();
        }

        private bool EsPagoValido(out string mensajeError)
        {
            if (opSocio.Checked)
            {
                if (cboActividades.SelectedIndex >= 0)
                {
                    mensajeError = "Un socio no puede pagar una actividad.";
                    return false;
                }
            }
            else
            {
                if (cboActividades.SelectedIndex < 0)
                {
                    mensajeError = "Seleccione una actividad para continuar.";
                    return false;
                }
            }

            mensajeError = "";
            return true;
        }
    }
}