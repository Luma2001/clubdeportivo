using CludDeportivo.Entidades;

namespace CludDeportivo
{
    public partial class Carnet : Form
    {
        // Constructor que recibe los datos de la persona
        public Carnet(E_Persona persona)
        {
            InitializeComponent();

            // Asignación de los datos a los labels
            lblApellidoValue.Text = persona.Apellido;
            lblNombreValue.Text = persona.Nombre;
            lblDNIValue.Text = persona.DNI;
            lblSocioDesdeValue.Text = persona.FechaRegistro?.Split(' ')[0];
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento para imprimir el carnet
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El carnet se ha impreso correctamente", "Carnet impreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}