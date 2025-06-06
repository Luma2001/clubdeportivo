using System.Drawing.Printing;

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
        public string? tipo_pago_f;
        //public string? pago_f;

        private void Comprobante_Load(object sender, EventArgs e)
        {
            labelNombre.Text = cliente_f;
            labelDireccion.Text = direccion_f;
            labelInicio.Text = Convert.ToString(fecha_f);
            labelMonto.Text = monto_f.ToString("N2");
            labelTipoPago.Text = forma_f;
            labelHoy.Text = DateTime.UtcNow.ToShortDateString();
            labelDatos.Text = tipo_pago_f;
        }

        //Impresión del comprobante de pago
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Ocultar el botón "IMPRIMIR"
            btnImprimir.Visible = false;

            // Ocultar otros elementos irrelevantes
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None; // Oculta el marco de la ventana

            try
            {
                // Capturar toda la vista del formulario como una imagen
                Bitmap formImage = CaptureFormAsImage(this);

                // Abrir el cuadro de diálogo de impresión
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += FacturaPago;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            finally
            {
                // Mostrar nuevamente el botón "IMPRIMIR" y el marco de la ventana
                btnImprimir.Visible = true;
                this.BackColor = SystemColors.Control;
                this.FormBorderStyle = FormBorderStyle.Sizable; // Restaurar el marco de la ventana
            }
        }

        private void FacturaPago(object sender, PrintPageEventArgs e)
        {
            // Capturar toda la vista del formulario como una imagen
            Bitmap formImage = CaptureFormAsImage(this);

            // Dibujar la imagen en la página de impresión
            e.Graphics.DrawImage(formImage, 0, 0);
        }

        private Bitmap CaptureFormAsImage(Control control)
        {
            // Asegurarse de que el control esté visible antes de capturar
            control.Visible = true;

            // Crear un bitmap del mismo tamaño que el control
            Bitmap bitmap = new Bitmap(control.Width, control.Height);

            // Dibujar el control en el bitmap
            control.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, control.Width, control.Height));

            return bitmap;
        }
    }
}