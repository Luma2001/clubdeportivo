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
            groupBox1 = new GroupBox();
            optTarj = new RadioButton();
            optEfvo = new RadioButton();
            txtDNI = new TextBox();
            btnPagar = new Button();
            btnComprobante = new Button();
            btnVolver = new Button();
            groupBox2 = new GroupBox();
            opNoSocio = new RadioButton();
            opSocio = new RadioButton();
            cboActividades = new ComboBox();
            lblActividad = new Label();
            lblMontoAPagar = new Label();
            lblMontoAPagarValue = new Label();
            lblDolarIcon = new Label();
            lblCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(21, 12);
            logo.Name = "logo";
            logo.Size = new Size(131, 108);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            labelDNI.Location = new Point(224, 128);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(218, 22);
            labelDNI.TabIndex = 2;
            labelDNI.Text = "Ingrese Número de DNI";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(optTarj);
            groupBox1.Controls.Add(optEfvo);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(21, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 150);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // optTarj
            // 
            optTarj.AutoSize = true;
            optTarj.Location = new Point(17, 93);
            optTarj.Name = "optTarj";
            optTarj.Size = new Size(102, 32);
            optTarj.TabIndex = 1;
            optTarj.TabStop = true;
            optTarj.Text = "Tarjeta";
            optTarj.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new Point(17, 48);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(114, 32);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(494, 125);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(265, 31);
            txtDNI.TabIndex = 7;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // btnPagar
            // 
            btnPagar.Enabled = false;
            btnPagar.Location = new Point(579, 328);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(186, 68);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.ForeColor = SystemColors.ActiveCaptionText;
            btnComprobante.Location = new Point(579, 410);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(186, 68);
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
            btnVolver.Location = new Point(579, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(181, 50);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(opNoSocio);
            groupBox2.Controls.Add(opSocio);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(184, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 77);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccionar";
            // 
            // opNoSocio
            // 
            opNoSocio.AutoSize = true;
            opNoSocio.Location = new Point(139, 33);
            opNoSocio.Name = "opNoSocio";
            opNoSocio.Size = new Size(122, 32);
            opNoSocio.TabIndex = 1;
            opNoSocio.TabStop = true;
            opNoSocio.Text = "No Socio";
            opNoSocio.UseVisualStyleBackColor = true;
            opNoSocio.CheckedChanged += CambiarEstadoActividades;
            // 
            // opSocio
            // 
            opSocio.AutoSize = true;
            opSocio.Location = new Point(6, 33);
            opSocio.Name = "opSocio";
            opSocio.Size = new Size(88, 32);
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
            cboActividades.Location = new Point(493, 197);
            cboActividades.Margin = new Padding(4, 5, 4, 5);
            cboActividades.Name = "cboActividades";
            cboActividades.Size = new Size(267, 33);
            cboActividades.TabIndex = 14;
            cboActividades.SelectedIndexChanged += cboActividades_SelectedIndexChanged;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblActividad.ForeColor = SystemColors.ActiveCaption;
            lblActividad.Location = new Point(357, 197);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(92, 22);
            lblActividad.TabIndex = 15;
            lblActividad.Text = "Actividad";
            // 
            // lblMontoAPagar
            // 
            lblMontoAPagar.AutoSize = true;
            lblMontoAPagar.Location = new Point(274, 453);
            lblMontoAPagar.Margin = new Padding(4, 0, 4, 0);
            lblMontoAPagar.Name = "lblMontoAPagar";
            lblMontoAPagar.Size = new Size(131, 25);
            lblMontoAPagar.TabIndex = 16;
            lblMontoAPagar.Text = "Monto a pagar";
            // 
            // lblMontoAPagarValue
            // 
            lblMontoAPagarValue.AutoSize = true;
            lblMontoAPagarValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoAPagarValue.ForeColor = Color.MediumOrchid;
            lblMontoAPagarValue.Location = new Point(294, 392);
            lblMontoAPagarValue.Margin = new Padding(4, 0, 4, 0);
            lblMontoAPagarValue.Name = "lblMontoAPagarValue";
            lblMontoAPagarValue.Size = new Size(0, 55);
            lblMontoAPagarValue.TabIndex = 17;
            // 
            // lblDolarIcon
            // 
            lblDolarIcon.AutoSize = true;
            lblDolarIcon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDolarIcon.ForeColor = Color.MediumOrchid;
            lblDolarIcon.Location = new Point(270, 408);
            lblDolarIcon.Margin = new Padding(4, 0, 4, 0);
            lblDolarIcon.Name = "lblDolarIcon";
            lblDolarIcon.Size = new Size(34, 40);
            lblDolarIcon.TabIndex = 18;
            lblDolarIcon.Text = "$";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(274, 350);
            lblCliente.Margin = new Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(69, 25);
            lblCliente.TabIndex = 19;
            lblCliente.Text = "Cliente:";
            // 
            // Cobrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 497);
            Controls.Add(lblCliente);
            Controls.Add(lblDolarIcon);
            Controls.Add(lblMontoAPagarValue);
            Controls.Add(lblMontoAPagar);
            Controls.Add(lblActividad);
            Controls.Add(cboActividades);
            Controls.Add(groupBox2);
            Controls.Add(btnVolver);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtDNI);
            Controls.Add(groupBox1);
            Controls.Add(labelDNI);
            Controls.Add(logo);
            Name = "Cobrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sección Cobranza";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label labelDNI;
        private GroupBox groupBox1;
        private RadioButton optTarj;
        private RadioButton optEfvo;
        private TextBox txtDNI;
        private Button btnPagar;
        private Button btnComprobante;
        private Button btnVolver;
        private GroupBox groupBox2;
        private RadioButton opNoSocio;
        private RadioButton opSocio;
        private ComboBox cboActividades;
        private Label lblActividad;
        private Label lblMontoAPagar;
        private Label lblMontoAPagarValue;
        private Label lblDolarIcon;
        private Label lblCliente;
    }
}