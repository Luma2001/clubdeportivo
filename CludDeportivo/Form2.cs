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
    public partial class sistema : Form
    {
        private string? usuario;
        public sistema(string? usuario)
        {
            InitializeComponent();
            this.usuario = usuario;


        }





        private void sistema_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " (administrador)";
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

            //Form login = new FormLogin();
            //login.Show();
            //this.Hide();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
