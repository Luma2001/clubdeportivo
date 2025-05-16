using System.Data;

namespace CludDeportivo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }


        private void passLabel_Click(object sender, EventArgs e)
        {

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); //recibe los datos desde el formulario
            Datos.Usuario dato = new Datos.Usuario(); //Variable que contiene todas las características de la clase
            tablaLogin = dato.Log_Usu(textUser.Text, textPass.Text);
            MessageBox.Show($"Usuario Activo: {tablaLogin.Rows.Count}");

            if (tablaLogin.Rows.Count >=0)
            {
                MessageBox.Show("Ingreso exitoso");
                Form sistema = new sistema();
                sistema.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando llega el foco
            if (textUser.Text == "Ingresar Usuario...")
            {
                textUser.Text = "";
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "Ingresar Contraseña...")
            {
                textPass.Text = "";
                textPass.UseSystemPasswordChar = true;
            }

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando se va el foco
            if (textUser.Text == "")
            {
                textUser.Text = "Ingresar Usuario...";
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando se va el foco
            if (textPass.Text == "")
            {
                textPass.Text = "Ingresar Contraseña...";
                textPass.UseSystemPasswordChar = false;
            }
        }
    }
}


