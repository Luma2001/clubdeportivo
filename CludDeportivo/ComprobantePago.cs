using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CludDeportivo
{
    public partial class Comprobante : Form
    {

        public Comprobante()
        {
            InitializeComponent();
            this.TopMost = true; // Mantiene la ventana en primer plano
        }

        public int numero_f;
        public string? cliente_f;
        public string? direccion_f;
        public DateTime fecha_f;
        public float monto_f;
        public string? forma_f;
        //public string? pago_f;

        private void Comprobante_Load(object sender, EventArgs e)
        {
            labelNombre.Text = cliente_f;
            labelDireccion.Text = direccion_f;
            labelInicio.Text = Convert.ToString(fecha_f);
            labelMonto.Text = monto_f.ToString("N2");
            labelTipoPago.Text = forma_f;
            labelHoy.Text = DateTime.UtcNow.ToShortDateString();

        }



        //Impresión del comprobante de pago
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;//elemento que no se va a imprimir entonces lo oculta

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(FacturaPago);
            pd.Print();

            btnImprimir.Visible = true;

            MessageBox.Show("Impresión exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
        private void FacturaPago(object sender, PrintPageEventArgs e)
        {
            //Opción Uno (para imprimir un comprobante de pago específico)
            Font font = new Font("Arial", 12);
            e.Graphics.DrawString("COMPROBANTE DE PAGO", font, Brushes.Black, 100, 50);
            e.Graphics.DrawString($"{cliente_f}", font, Brushes.Black, 100, 100);
            e.Graphics.DrawString($"Dirección: {direccion_f}", font, Brushes.Black, 100, 130);
            e.Graphics.DrawString($"Fecha de Inscripción: {fecha_f.ToShortDateString()}", font, Brushes.Black, 100, 160);
            e.Graphics.DrawString($"Forma de Pago: {forma_f}", font, Brushes.Black, 100, 190);
            e.Graphics.DrawString($"Monto: ${monto_f:C}", font, Brushes.Black, 100, 220);



            //Opción Dos (para imprimir el formulario completo)
            /*
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);*/

        }






        //VARIABLES

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void labelHoy_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelDireccion_Click(object sender, EventArgs e)
        {

        }

        private void labelInicio_Click(object sender, EventArgs e)
        {

        }

        private void labelTipoPago_Click(object sender, EventArgs e)
        {

        }

        private void labelMonto_Click(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

    }
}
