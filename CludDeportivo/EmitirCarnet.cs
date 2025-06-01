using CludDeportivo.Datos;
using CludDeportivo.Entidades;

namespace CludDeportivo
{
    public partial class EmitirCarnet : Form
    {
        public EmitirCarnet()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            VerificarDNI();
        }

        // Listener de tecla ENTER
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                VerificarDNI();
            }
        }

        private void VerificarDNI()
        {
            string dni = txtDNI.Text;

            // Verificar formato de DNI
            if (dni.Length != 8 || !int.TryParse(dni, out _))
            {
                MessageBox.Show("Número de DNI inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ResetForm();
                return;
            }

            // Obtener datos y crear objeto persona
            Persona personaDAO = new Persona();
            E_Persona persona = personaDAO.ObtenerPersonaPorDni(dni);

            // Si no hay persona
            if (persona == null)
            {
                MessageBox.Show("No se encontró ninguna persona con ese número de DNI.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ResetForm();
                return;
            }

            // Si la persona no es socio
            if (!persona.EsSocio)
            {
                MessageBox.Show("El carnet es exclusivo para socios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                return;
            }

            // Cargar datos de socio encontrado
            lblNombre.Text += $" {persona.Nombre}";
            lblApellido.Text += $" {persona.Apellido}";
            lblSocio.Text += $" {(persona.EsSocio ? "Si" : "No")}";

            // Habilitar botón para emitir carnet
            btnEmitir.Enabled = true;
        }

        // Método para limpiar el formulario y deshabilitar el botón EMITIR CARNET
        private void ResetForm()
        {
            lblNombre.Text = "Nombre:";
            lblApellido.Text = "Apellido: ";
            lblSocio.Text = "Socio: ";

            txtDNI.Text = "";
            btnEmitir.Enabled = false;
        }
    }
}