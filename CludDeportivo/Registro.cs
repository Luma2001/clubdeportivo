using CludDeportivo.Entidades;

namespace CludDeportivo
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxApellido.Text) || string.IsNullOrWhiteSpace(textBoxDni.Text) || string.IsNullOrWhiteSpace(textBoxDireccion.Text) || !checkBoxAptoFisico.Checked)

            {
                MessageBox.Show("Debe completar datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Persona persona = new E_Persona();
                persona.Nombre = textBoxNombre.Text;
                persona.Apellido = textBoxApellido.Text;
                persona.DNI = textBoxDni.Text;
                persona.Direccion = textBoxDireccion.Text;
                persona.EsSocio = checkBoxSocio.Checked;
                persona.AptoFisico = checkBoxAptoFisico.Checked;

                Datos.Persona nuevoCliente = new Datos.Persona();

                try
                {
                    respuesta = nuevoCliente.RegistrarPersona(persona);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar cliente: " + ex.Message, "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (int.TryParse(respuesta, out int codigo))
                {
                    if (codigo == -1) // -1 me indica usuario existente
                    {
                        MessageBox.Show("El cliente ya se encuentra registrado", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Cliente registrado exitosamente. Nro. de registro: {codigo}", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                        textBoxNombre.Text = "Nombre requerido...";
                        textBoxApellido.Text = "Apellido requerido...";
                        textBoxDni.Text = "DNI requerido...";
                        textBoxDireccion.Text = "Dirección requerido...";
                        checkBoxSocio.Checked = false;
                        checkBoxAptoFisico.Checked = false;
                    }
                }
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVolver2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}