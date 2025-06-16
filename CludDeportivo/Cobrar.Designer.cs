namespace CludDeportivo
{
    partial class Cobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobrar));
            logo = new PictureBox();
            labelDNI = new Label();
            grpForma_Pago = new GroupBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            txtDNI = new TextBox();
            btnPagar = new Button();
            btnComprobante = new Button();
            btnVolver = new Button();
            grpSocio_NoSocio = new GroupBox();
            opNoSocio = new RadioButton();
            opSocio = new RadioButton();
            cboActividades = new ComboBox();
            lblActividad = new Label();
            lblMontoAPagar = new Label();
            lblMontoAPagarValue = new Label();
            lblDolarIcon = new Label();
            lblCliente = new Label();
            grpCuotas = new GroupBox();
            rbtCuota6 = new RadioButton();
            rbtCuota3 = new RadioButton();
            rbtCuota1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            grpForma_Pago.SuspendLayout();
            grpSocio_NoSocio.SuspendLayout();
            grpCuotas.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(15, 7);
            logo.Margin = new Padding(2);
            logo.Name = "logo";
            logo.Size = new Size(113, 93);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            labelDNI.Location = new Point(157, 111);
            labelDNI.Margin = new Padding(2, 0, 2, 0);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(158, 15);
            labelDNI.TabIndex = 2;
            labelDNI.Text = "Ingrese Número de DNI";
            // 
            // grpForma_Pago
            // 
            grpForma_Pago.BackColor = SystemColors.GradientInactiveCaption;
            grpForma_Pago.Controls.Add(rbtTarjeta);
            grpForma_Pago.Controls.Add(rbtEfectivo);
            grpForma_Pago.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpForma_Pago.ForeColor = SystemColors.ControlText;
            grpForma_Pago.Location = new Point(15, 111);
            grpForma_Pago.Margin = new Padding(2);
            grpForma_Pago.Name = "grpForma_Pago";
            grpForma_Pago.Padding = new Padding(2);
            grpForma_Pago.Size = new Size(115, 72);
            grpForma_Pago.TabIndex = 6;
            grpForma_Pago.TabStop = false;
            grpForma_Pago.Text = "Forma de Pago";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(12, 43);
            rbtTarjeta.Margin = new Padding(2);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += grpForma_PagoChange;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(12, 20);
            rbtEfectivo.Margin = new Padding(2);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            rbtEfectivo.CheckedChanged += grpForma_PagoChange;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(346, 109);
            txtDNI.Margin = new Padding(2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(187, 23);
            txtDNI.TabIndex = 7;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // btnPagar
            // 
            btnPagar.Enabled = false;
            btnPagar.Location = new Point(405, 193);
            btnPagar.Margin = new Padding(2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(130, 41);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.ForeColor = SystemColors.ActiveCaptionText;
            btnComprobante.Location = new Point(405, 245);
            btnComprobante.Margin = new Padding(2);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(130, 41);
            btnComprobante.TabIndex = 9;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkCyan;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(408, 7);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(127, 30);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // grpSocio_NoSocio
            // 
            grpSocio_NoSocio.BackColor = SystemColors.GradientInactiveCaption;
            grpSocio_NoSocio.Controls.Add(opNoSocio);
            grpSocio_NoSocio.Controls.Add(opSocio);
            grpSocio_NoSocio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSocio_NoSocio.ForeColor = SystemColors.ControlText;
            grpSocio_NoSocio.Location = new Point(157, 7);
            grpSocio_NoSocio.Margin = new Padding(2);
            grpSocio_NoSocio.Name = "grpSocio_NoSocio";
            grpSocio_NoSocio.Padding = new Padding(2);
            grpSocio_NoSocio.Size = new Size(186, 46);
            grpSocio_NoSocio.TabIndex = 13;
            grpSocio_NoSocio.TabStop = false;
            grpSocio_NoSocio.Text = "Seleccionar";
            // 
            // opNoSocio
            // 
            opNoSocio.AutoSize = true;
            opNoSocio.Location = new Point(97, 20);
            opNoSocio.Margin = new Padding(2);
            opNoSocio.Name = "opNoSocio";
            opNoSocio.Size = new Size(88, 23);
            opNoSocio.TabIndex = 1;
            opNoSocio.TabStop = true;
            opNoSocio.Text = "No Socio";
            opNoSocio.UseVisualStyleBackColor = true;
            opNoSocio.CheckedChanged += CambiarEstadoActividades;
            // 
            // opSocio
            // 
            opSocio.AutoSize = true;
            opSocio.Location = new Point(4, 20);
            opSocio.Margin = new Padding(2);
            opSocio.Name = "opSocio";
            opSocio.Size = new Size(64, 23);
            opSocio.TabIndex = 0;
            opSocio.TabStop = true;
            opSocio.Text = "Socio";
            opSocio.UseVisualStyleBackColor = true;
            opSocio.CheckedChanged += CambiarEstadoActividades;
            // 
            // cboActividades
            // 
            cboActividades.Enabled = false;
            cboActividades.FormattingEnabled = true;
            cboActividades.Location = new Point(345, 152);
            cboActividades.Name = "cboActividades";
            cboActividades.Size = new Size(188, 23);
            cboActividades.TabIndex = 14;
            cboActividades.SelectedIndexChanged += cboActividades_SelectedIndexChanged;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblActividad.ForeColor = SystemColors.ActiveCaption;
            lblActividad.Location = new Point(250, 152);
            lblActividad.Margin = new Padding(2, 0, 2, 0);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(64, 15);
            lblActividad.TabIndex = 15;
            lblActividad.Text = "Actividad";
            // 
            // lblMontoAPagar
            // 
            lblMontoAPagar.AutoSize = true;
            lblMontoAPagar.Location = new Point(192, 272);
            lblMontoAPagar.Name = "lblMontoAPagar";
            lblMontoAPagar.Size = new Size(85, 15);
            lblMontoAPagar.TabIndex = 16;
            lblMontoAPagar.Text = "Monto a pagar";
            // 
            // lblMontoAPagarValue
            // 
            lblMontoAPagarValue.AutoSize = true;
            lblMontoAPagarValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoAPagarValue.ForeColor = Color.MediumOrchid;
            lblMontoAPagarValue.Location = new Point(206, 235);
            lblMontoAPagarValue.Name = "lblMontoAPagarValue";
            lblMontoAPagarValue.Size = new Size(0, 37);
            lblMontoAPagarValue.TabIndex = 17;
            // 
            // lblDolarIcon
            // 
            lblDolarIcon.AutoSize = true;
            lblDolarIcon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDolarIcon.ForeColor = Color.MediumOrchid;
            lblDolarIcon.Location = new Point(189, 245);
            lblDolarIcon.Name = "lblDolarIcon";
            lblDolarIcon.Size = new Size(23, 25);
            lblDolarIcon.TabIndex = 18;
            lblDolarIcon.Text = "$";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(192, 210);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 19;
            lblCliente.Text = "Cliente:";
            // 
            // grpCuotas
            // 
            grpCuotas.BackColor = SystemColors.GradientInactiveCaption;
            grpCuotas.Controls.Add(rbtCuota6);
            grpCuotas.Controls.Add(rbtCuota3);
            grpCuotas.Controls.Add(rbtCuota1);
            grpCuotas.ForeColor = SystemColors.ButtonShadow;
            grpCuotas.Location = new Point(15, 193);
            grpCuotas.Name = "grpCuotas";
            grpCuotas.Size = new Size(115, 93);
            grpCuotas.TabIndex = 20;
            grpCuotas.TabStop = false;
            grpCuotas.Text = "Cuotas";
            // 
            // rbtCuota6
            // 
            rbtCuota6.AutoSize = true;
            rbtCuota6.Enabled = false;
            rbtCuota6.Location = new Point(12, 64);
            rbtCuota6.Name = "rbtCuota6";
            rbtCuota6.Size = new Size(69, 19);
            rbtCuota6.TabIndex = 2;
            rbtCuota6.TabStop = true;
            rbtCuota6.Text = "6 cuotas";
            rbtCuota6.UseVisualStyleBackColor = true;
            // 
            // rbtCuota3
            // 
            rbtCuota3.AutoSize = true;
            rbtCuota3.Enabled = false;
            rbtCuota3.Location = new Point(12, 43);
            rbtCuota3.Name = "rbtCuota3";
            rbtCuota3.Size = new Size(69, 19);
            rbtCuota3.TabIndex = 1;
            rbtCuota3.TabStop = true;
            rbtCuota3.Text = "3 cuotas";
            rbtCuota3.UseVisualStyleBackColor = true;
            // 
            // rbtCuota1
            // 
            rbtCuota1.AutoSize = true;
            rbtCuota1.Enabled = false;
            rbtCuota1.Location = new Point(12, 22);
            rbtCuota1.Name = "rbtCuota1";
            rbtCuota1.Size = new Size(64, 19);
            rbtCuota1.TabIndex = 0;
            rbtCuota1.TabStop = true;
            rbtCuota1.Text = "1 cuota";
            rbtCuota1.UseVisualStyleBackColor = true;
            // 
            // Cobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(560, 298);
            Controls.Add(grpCuotas);
            Controls.Add(lblCliente);
            Controls.Add(lblDolarIcon);
            Controls.Add(lblMontoAPagarValue);
            Controls.Add(lblMontoAPagar);
            Controls.Add(lblActividad);
            Controls.Add(cboActividades);
            Controls.Add(grpSocio_NoSocio);
            Controls.Add(btnVolver);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtDNI);
            Controls.Add(grpForma_Pago);
            Controls.Add(labelDNI);
            Controls.Add(logo);
            Margin = new Padding(2);
            Name = "Cobrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sección Cobranza";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            grpForma_Pago.ResumeLayout(false);
            grpForma_Pago.PerformLayout();
            grpSocio_NoSocio.ResumeLayout(false);
            grpSocio_NoSocio.PerformLayout();
            grpCuotas.ResumeLayout(false);
            grpCuotas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label labelDNI;
        private GroupBox grpForma_Pago;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private TextBox txtDNI;
        private Button btnPagar;
        private Button btnComprobante;
        private Button btnVolver;
        private GroupBox grpSocio_NoSocio;
        private RadioButton opNoSocio;
        private RadioButton opSocio;
        private ComboBox cboActividades;
        private Label lblActividad;
        private Label lblMontoAPagar;
        private Label lblMontoAPagarValue;
        private Label lblDolarIcon;
        private Label lblCliente;
        private GroupBox grpCuotas;
        private RadioButton rbtCuota6;
        private RadioButton rbtCuota3;
        private RadioButton rbtCuota1;
    }
}