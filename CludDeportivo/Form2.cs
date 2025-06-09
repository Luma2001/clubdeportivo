namespace CludDeportivo
{
    public partial class Sistema : Form
    {
        private string? usuario;

        public Sistema(string? usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            // Suscribirse al evento FormClosed
            this.FormClosed += sistema_FormClosed;
        }

        // método necesario para finalizar el proceso al cerrar esta ventana
        private void sistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sistema_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " (administrador)";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Registro Registro = new Registro();
            Registro.ShowDialog();
        }

        private void buttonDeudor_Click(object sender, EventArgs e)
        {
            ListaDeudores Listado = new ListaDeudores();
            Listado.ShowDialog();
        }

        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            Cobrar Cobrar = new Cobrar();
            Cobrar.ShowDialog();
        }

        private void buttonCarnet_Click(object sender, EventArgs e)
        {
            EmitirCarnet emitirCarnet = new EmitirCarnet();
            emitirCarnet.ShowDialog();
        }
    }
}