namespace CludDeportivo
{
    partial class EmitirCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmitirCarnet));
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            txtDNI = new TextBox();
            lblDNI = new Label();
            btnVerificar = new Button();
            lblTitle = new Label();
            lblDatosPersona = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblSocio = new Label();
            btnEmitir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 20);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Bisque;
            btnVolver.Location = new Point(46, 242);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(232, 109);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "Ingrese el Nro. de DNI";
            txtDNI.Size = new Size(157, 23);
            txtDNI.TabIndex = 9;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(189, 112);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 10;
            lblDNI.Text = "DNI";
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.LightBlue;
            btnVerificar.Location = new Point(409, 109);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 11;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(189, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 39);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "Emitir Carnet";
            // 
            // lblDatosPersona
            // 
            lblDatosPersona.AutoSize = true;
            lblDatosPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPersona.Location = new Point(189, 167);
            lblDatosPersona.Name = "lblDatosPersona";
            lblDatosPersona.Size = new Size(103, 15);
            lblDatosPersona.TabIndex = 24;
            lblDatosPersona.Text = "Datos de persona";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(189, 192);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(189, 217);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 26;
            lblApellido.Text = "Apellido:";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(189, 242);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(39, 15);
            lblSocio.TabIndex = 27;
            lblSocio.Text = "Socio:";
            // 
            // btnEmitir
            // 
            btnEmitir.Enabled = false;
            btnEmitir.Location = new Point(409, 167);
            btnEmitir.Name = "btnEmitir";
            btnEmitir.Size = new Size(75, 90);
            btnEmitir.TabIndex = 28;
            btnEmitir.Text = "Emitir";
            btnEmitir.UseVisualStyleBackColor = true;
            btnEmitir.Click += btnEmitir_Click;
            // 
            // EmitirCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 294);
            Controls.Add(btnEmitir);
            Controls.Add(lblSocio);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosPersona);
            Controls.Add(lblTitle);
            Controls.Add(btnVerificar);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox1);
            Name = "EmitirCarnet";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EmitirCarnet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnVolver;
        private TextBox txtDNI;
        private Label lblDNI;
        private Button btnVerificar;
        private Label lblTitle;
        private Label lblDatosPersona;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblSocio;
        private Button btnEmitir;
    }
}