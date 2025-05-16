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
        public sistema()
        {
            InitializeComponent();
        }

        private void sistema_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Form login = new FormLogin();
            login.Show();
            this.Hide();
        }
    }
}
