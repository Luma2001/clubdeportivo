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
            logo.Size = new Size(132, 108);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Simple Outline Pat", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            labelDNI.Location = new Point(184, 125);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(258, 30);
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
            groupBox1.Location = new Point(495, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 150);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // optTarj
            // 
            optTarj.AutoSize = true;
            optTarj.Location = new Point(96, 94);
            optTarj.Name = "optTarj";
            optTarj.Size = new Size(102, 32);
            optTarj.TabIndex = 1;
            optTarj.TabStop = true;
            optTarj.Text = "Tarjeta";
            optTarj.UseVisualStyleBackColor = true;
            optTarj.CheckedChanged += optTarj_CheckedChanged;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new Point(96, 56);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(114, 32);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            optEfvo.CheckedChanged += optEfvo_CheckedChanged;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(495, 125);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(266, 31);
            txtDNI.TabIndex = 7;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(184, 262);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(258, 68);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.ForeColor = SystemColors.ActiveCaptionText;
            btnComprobante.Location = new Point(184, 344);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(258, 68);
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
            btnVolver.Size = new Size(182, 50);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Simple Outline Pat", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            labelApellido.Location = new Point(184, 181);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(183, 30);
            labelApellido.TabIndex = 11;
            labelApellido.Text = "Ingrese Apellido";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(495, 181);
            textApellido.Name = "textApellido";
            textApellido.ShortcutsEnabled = false;
            textApellido.Size = new Size(266, 31);
            textApellido.TabIndex = 12;
            textApellido.TextChanged += textApellido_TextChanged;
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
            opNoSocio.Location = new Point(138, 33);
            opNoSocio.Name = "opNoSocio";
            opNoSocio.Size = new Size(122, 32);
            opNoSocio.TabIndex = 1;
            opNoSocio.TabStop = true;
            opNoSocio.Text = "No Socio";
            opNoSocio.UseVisualStyleBackColor = true;
            opNoSocio.CheckedChanged += opNoSocio_CheckedChanged;
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
            opSocio.CheckedChanged += opSocio_CheckedChanged;
            // 
            // Cobrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
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
    }
}