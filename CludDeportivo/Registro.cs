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

        private void checkBoxSocio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBoxNombre_Enter(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando llega el foco
            if (textBoxNombre.Text == "Nombre requerido...")
            {
                textBoxNombre.Text = "";
            }
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando se va el foco
            if (textBoxNombre.Text == "")
            {
                textBoxNombre.Text = "Nombre requerido...";
            }
        }

        private void textBoxApellido_Enter(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando llega el foco
            if (textBoxApellido.Text == "Apellido requerido...")
            {
                textBoxApellido.Text = "";
            }
        }

        private void textBoxApellido_Leave(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando se va el foco
            if (textBoxApellido.Text == "")
            {
                textBoxApellido.Text = "Apellido requerido...";
            }
        }

        private void textBoxDni_Enter(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando llega el foco
            if (textBoxDni.Text == "DNI requerido...")
            {
                textBoxDni.Text = "";
            }
        }

        private void textBoxDni_Leave(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando se va el foco
            if (textBoxDni.Text == "")
            {
                textBoxDni.Text = "DNI requerido...";
            }
        }

        private void textBoxDireccion_Enter(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando llega el foco
            if (textBoxDireccion.Text == "Dirección requerido...")
            {
                textBoxDireccion.Text = "";
            }
        }

        private void textBoxDireccion_Leave(object sender, EventArgs e)
        {
            //Este evento se ejecuta cuando se va el foco
            if (textBoxDireccion.Text == "")
            {
                textBoxDireccion.Text = "Dirección requerido...";
            }
        }
    }
}