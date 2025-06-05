using System.Data;

namespace CludDeportivo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
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
                    MessageBox.Show("El usuario existe, pero está inactivo.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginUser();
            }
        }
    }
}