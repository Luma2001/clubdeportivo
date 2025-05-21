using CludDeportivo.Entidades;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            /*if (textBoxNombre == "" || textBoxApellido == " " || textBoxDni = "" || textBoxDireccion == "" || checkBoxSocio == null || checkBoxAptoFisico == null)
            {
                MessageBox.Show("Debe completar datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            */
            string respuesta;
            E_Persona persona = new E_Persona();
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.DNI = textBoxDni.Text;
            persona.Direccion = textBoxDireccion.Text;
            persona.EsSocio = checkBoxSocio.Checked;
            persona.AptoFisico = checkBoxAptoFisico.Checked;


            Datos.Persona nuevoCliente = new Datos.Persona();
            respuesta = nuevoCliente.RegistrarPersona(persona);



            if (int.TryParse(respuesta, out int codigo))
            {
                if (codigo == -1) // -1 me indica usuario existente
                {
                    MessageBox.Show("REGISTRO DE CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Se almacenó con éxito con el Registro Nro {codigo}", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
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

