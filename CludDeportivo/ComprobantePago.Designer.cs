namespace CludDeportivo
{
    partial class Comprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobante));
            btnImprimir = new Button();
            panelDatos = new Panel();
            labelMonto = new Label();
            labelTipoPago = new Label();
            labelInicio = new Label();
            labelDireccion = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelNombre = new Label();
            panel4 = new Panel();
            labelHoy = new Label();
            labelFecha = new Label();
            labelDatos = new Label();
            panelInstituto = new Panel();
            logo = new PictureBox();
            labelInstituro = new Label();
            panel1 = new Panel();
            labelTitulo = new Label();
            panel3 = new Panel();
            panelDatos.SuspendLayout();
            panel4.SuspendLayout();
            panelInstituto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(549, 443);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(221, 60);
            btnImprimir.TabIndex = 9;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // panelDatos
            // 
            panelDatos.BackColor = Color.PowderBlue;
            panelDatos.Controls.Add(labelMonto);
            panelDatos.Controls.Add(labelTipoPago);
            panelDatos.Controls.Add(labelInicio);
            panelDatos.Controls.Add(labelDireccion);
            panelDatos.Controls.Add(label6);
            panelDatos.Controls.Add(label5);
            panelDatos.Controls.Add(label4);
            panelDatos.Controls.Add(label3);
            panelDatos.Controls.Add(labelNombre);
            panelDatos.Location = new Point(85, 200);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(685, 237);
            panelDatos.TabIndex = 8;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(519, 177);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(78, 25);
            labelMonto.TabIndex = 8;
            labelMonto.Text = "monto...";
            labelMonto.Click += labelMonto_Click;
            // 
            // labelTipoPago
            // 
            labelTipoPago.AutoSize = true;
            labelTipoPago.Location = new Point(179, 177);
            labelTipoPago.Name = "labelTipoPago";
            labelTipoPago.Size = new Size(56, 25);
            labelTipoPago.TabIndex = 7;
            labelTipoPago.Text = "tipo...";
            labelTipoPago.Click += labelTipoPago_Click;
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Location = new Point(208, 126);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(65, 25);
            labelInicio.TabIndex = 6;
            labelInicio.Text = "inicio...";
            labelInicio.Click += labelInicio_Click;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(140, 81);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(95, 25);
            labelDireccion.TabIndex = 5;
            labelDireccion.Text = "dirección...";
            labelDireccion.Click += labelDireccion_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 177);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 4;
            label6.Text = "Monto: $ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 177);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 3;
            label5.Text = "Forma de Pago: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 126);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 2;
            label4.Text = "Fecha de Ingreso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 81);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 1;
            label3.Text = "Dirección:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe Fluent Icons", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(31, 40);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(89, 22);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Jane Doe";
            labelNombre.Click += labelNombre_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PowderBlue;
            panel4.Controls.Add(labelHoy);
            panel4.Controls.Add(labelFecha);
            panel4.Controls.Add(labelDatos);
            panel4.Location = new Point(415, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(355, 118);
            panel4.TabIndex = 7;
            // 
            // labelHoy
            // 
            labelHoy.AutoSize = true;
            labelHoy.Location = new Point(87, 29);
            labelHoy.Name = "labelHoy";
            labelHoy.Size = new Size(66, 25);
            labelHoy.TabIndex = 9;
            labelHoy.Text = "fecha...";
            labelHoy.Click += labelHoy_Click;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(20, 29);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(61, 25);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Fecha:";
            // 
            // labelDatos
            // 
            labelDatos.AutoSize = true;
            labelDatos.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDatos.Location = new Point(20, 70);
            labelDatos.Name = "labelDatos";
            labelDatos.Size = new Size(149, 21);
            labelDatos.TabIndex = 0;
            labelDatos.Text = "Viamonte 500 Bs As";
            // 
            // panelInstituto
            // 
            panelInstituto.BackColor = Color.PowderBlue;
            panelInstituto.Controls.Add(logo);
            panelInstituto.Controls.Add(labelInstituro);
            panelInstituto.ForeColor = SystemColors.ActiveCaptionText;
            panelInstituto.Location = new Point(85, 76);
            panelInstituto.Name = "panelInstituto";
            panelInstituto.Size = new Size(324, 118);
            panelInstituto.TabIndex = 6;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(194, 9);
            logo.Name = "logo";
            logo.Size = new Size(115, 99);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 2;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // labelInstituro
            // 
            labelInstituro.AutoSize = true;
            labelInstituro.Location = new Point(31, 16);
            labelInstituro.Name = "labelInstituro";
            labelInstituro.Size = new Size(153, 25);
            labelInstituro.TabIndex = 0;
            labelInstituro.Text = "CLUB DEPORTIVO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(panel3);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(85, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 57);
            panel1.TabIndex = 5;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(125, 4);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(456, 48);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "COMPROBANTE DE PAGO";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(350, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 150);
            panel3.TabIndex = 2;
            // 
            // Comprobante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 517);
            Controls.Add(btnImprimir);
            Controls.Add(panelDatos);
            Controls.Add(panel4);
            Controls.Add(panelInstituto);
            Controls.Add(panel1);
            Name = "Comprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura Club Deportivo";
            Load += Comprobante_Load;
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelInstituto.ResumeLayout(false);
            panelInstituto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImprimir;
        private Panel panelDatos;
        private Label labelMonto;
        private Label labelTipoPago;
        private Label labelInicio;
        private Label labelDireccion;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelNombre;
        private Panel panel4;
        private Label labelHoy;
        private Label labelFecha;
        private Label labelDatos;
        private Panel panelInstituto;
        private Label labelInstituro;
        private Panel panel1;
        private Label labelTitulo;
        private Panel panel3;
        private PictureBox logo;
    }
}