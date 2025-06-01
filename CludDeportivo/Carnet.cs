using CludDeportivo.Entidades;
using System.Drawing.Printing;

namespace CludDeportivo
{
    public partial class Carnet : Form
    {
        // Variable para almacenar temporalmente el bitmap
        private Bitmap TempImage { get; set; }

        private PrintDocument printDocument = new PrintDocument();

        // Constructor que recibe los datos de la persona
        public Carnet(E_Persona persona)
        {
            InitializeComponent();

            // Asignación de los datos a los labels
            lblApellidoValue.Text = persona.Apellido;
            lblNombreValue.Text = persona.Nombre;
            lblDNIValue.Text = persona.DNI;
            lblSocioDesdeValue.Text = persona.FechaRegistro?.Split(' ')[0];

            printDocument.PrintPage += printDocument1_PrintPage;
            printDocument.EndPrint += PrintDocument_EndPrint;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento para imprimir el carnet
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CapturePanelForPrinting(pnlCarnet);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void CapturePanelForPrinting(Control panel)
        {
            Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));
            TempImage = bitmap;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(TempImage, 0, 0);
        }

        private void PrintDocument_EndPrint(object sender, PrintEventArgs e)
        {
            MessageBox.Show("El carnet se ha impreso correctamente", "Carnet impreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}