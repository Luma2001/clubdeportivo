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
            Datos.Usuario dato = new Datos.Usuario();
            DataTable tablaLogin = dato.Log_Usu(textUser.Text, textPass.Text);

            // Verificamos si el usuario existe
            if (tablaLogin.Rows.Count > 0)
            {
                // Extraemos el valor de "activo" para comprobar si el usuario está habilitado
                bool usuarioActivo = Convert.ToBoolean(tablaLogin.Rows[0]["activo"]);

                if (usuarioActivo)
                {
                    MessageBox.Show($"Ingreso exitoso. Bienvenido, {textUser.Text}!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form sistema = new sistema(textUser.Text);
                   
                    sistema.Show(); 
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario existe, pero está inactivo.","Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


