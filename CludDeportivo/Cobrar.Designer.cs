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
            labelApellido = new Label();
            textApellido = new TextBox();
            groupBox2 = new GroupBox();
            opNoSocio = new RadioButton();
            opSocio = new RadioButton();
            cboActividades = new ComboBox();
            lblActividad = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(15, 7);
            logo.Margin = new Padding(2);
            logo.Name = "logo";
            logo.Size = new Size(92, 65);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            labelDNI.Location = new Point(129, 75);
            labelDNI.Margin = new Padding(2, 0, 2, 0);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(158, 15);
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
            groupBox1.Location = new Point(15, 197);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(138, 90);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // optTarj
            // 
            optTarj.AutoSize = true;
            optTarj.Location = new Point(12, 56);
            optTarj.Margin = new Padding(2);
            optTarj.Name = "optTarj";
            optTarj.Size = new Size(73, 23);
            optTarj.TabIndex = 1;
            optTarj.TabStop = true;
            optTarj.Text = "Tarjeta";
            optTarj.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new Point(12, 29);
            optEfvo.Margin = new Padding(2);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(80, 23);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(346, 75);
            txtDNI.Margin = new Padding(2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(187, 23);
            txtDNI.TabIndex = 7;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(405, 197);
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
            btnComprobante.Location = new Point(405, 246);
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
            btnVolver.Location = new Point(405, 7);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(127, 30);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            labelApellido.Location = new Point(129, 109);
            labelApellido.Margin = new Padding(2, 0, 2, 0);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(111, 15);
            labelApellido.TabIndex = 11;
            labelApellido.Text = "Ingrese Apellido";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(346, 109);
            textApellido.Margin = new Padding(2);
            textApellido.Name = "textApellido";
            textApellido.ShortcutsEnabled = false;
            textApellido.Size = new Size(187, 23);
            textApellido.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(opNoSocio);
            groupBox2.Controls.Add(opSocio);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(129, 7);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(186, 46);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccionar";
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
            cboActividades.Location = new Point(347, 147);
            cboActividades.Name = "cboActividades";
            cboActividades.Size = new Size(188, 23);
            cboActividades.TabIndex = 14;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblActividad.ForeColor = SystemColors.ActiveCaption;
            lblActividad.Location = new Point(133, 149);
            lblActividad.Margin = new Padding(2, 0, 2, 0);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(64, 15);
            lblActividad.TabIndex = 15;
            lblActividad.Text = "Actividad";
            // 
            // Cobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(560, 298);
            Controls.Add(lblActividad);
            Controls.Add(cboActividades);
            Controls.Add(groupBox2);
            Controls.Add(textApellido);
            Controls.Add(labelApellido);
            Controls.Add(btnVolver);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtDNI);
            Controls.Add(groupBox1);
            Controls.Add(labelDNI);
            Controls.Add(logo);
            Margin = new Padding(2);
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
        private Label labelApellido;
        private TextBox textApellido;
        private GroupBox groupBox2;
        private RadioButton opNoSocio;
        private RadioButton opSocio;
        private ComboBox cboActividades;
        private Label lblActividad;
    }
}