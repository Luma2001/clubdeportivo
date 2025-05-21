namespace CludDeportivo
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            pictureBox1 = new PictureBox();
            labelRegistroClientes = new Label();
            buttonRegistrar = new Button();
            textBoxDireccion = new TextBox();
            textBoxDni = new TextBox();
            labelDireccion = new Label();
            labelDni = new Label();
            textBoxApellido = new TextBox();
            labelApellido = new Label();
            textBoxNombre = new TextBox();
            labelNombre = new Label();
            checkBoxAptoFisico = new CheckBox();
            checkBoxSocio = new CheckBox();
            buttonVolver = new Button();
            buttonVolver2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 14);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // labelRegistroClientes
            // 
            labelRegistroClientes.AutoSize = true;
            labelRegistroClientes.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegistroClientes.Location = new Point(250, 31);
            labelRegistroClientes.Margin = new Padding(5, 0, 5, 0);
            labelRegistroClientes.Name = "labelRegistroClientes";
            labelRegistroClientes.Size = new Size(510, 58);
            labelRegistroClientes.TabIndex = 22;
            labelRegistroClientes.Text = "Registro de Clientes";
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.DarkCyan;
            buttonRegistrar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrar.ForeColor = Color.White;
            buttonRegistrar.Location = new Point(735, 484);
            buttonRegistrar.Margin = new Padding(5);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(220, 58);
            buttonRegistrar.TabIndex = 21;
            buttonRegistrar.Text = "REGISTRAR";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.ForeColor = SystemColors.ControlText;
            textBoxDireccion.Location = new Point(570, 335);
            textBoxDireccion.Margin = new Padding(5);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(314, 31);
            textBoxDireccion.TabIndex = 20;
            textBoxDireccion.Text = "Dirección requerido...";
            textBoxDireccion.Enter += textBoxDireccion_Enter;
            textBoxDireccion.Leave += textBoxDireccion_Leave;
            // 
            // textBoxDni
            // 
            textBoxDni.ForeColor = SystemColors.ControlText;
            textBoxDni.Location = new Point(570, 201);
            textBoxDni.Margin = new Padding(5);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(314, 31);
            textBoxDni.TabIndex = 19;
            textBoxDni.Text = "DNI requerido...";
            textBoxDni.Enter += textBoxDni_Enter;
            textBoxDni.Leave += textBoxDni_Leave;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDireccion.Location = new Point(570, 291);
            labelDireccion.Margin = new Padding(5, 0, 5, 0);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(138, 24);
            labelDireccion.TabIndex = 18;
            labelDireccion.Text = "Dirección:";
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDni.Location = new Point(570, 160);
            labelDni.Margin = new Padding(5, 0, 5, 0);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(62, 24);
            labelDni.TabIndex = 17;
            labelDni.Text = "DNI:";
            // 
            // textBoxApellido
            // 
            textBoxApellido.ForeColor = SystemColors.ControlText;
            textBoxApellido.Location = new Point(118, 335);
            textBoxApellido.Margin = new Padding(5);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(314, 31);
            textBoxApellido.TabIndex = 16;
            textBoxApellido.Text = "Apellido requerido...";
            textBoxApellido.Enter += textBoxApellido_Enter;
            textBoxApellido.Leave += textBoxApellido_Leave;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApellido.Location = new Point(118, 291);
            labelApellido.Margin = new Padding(5, 0, 5, 0);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(127, 24);
            labelApellido.TabIndex = 15;
            labelApellido.Text = "Apellido:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.ForeColor = SystemColors.ControlText;
            textBoxNombre.Location = new Point(118, 201);
            textBoxNombre.Margin = new Padding(5);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(314, 31);
            textBoxNombre.TabIndex = 14;
            textBoxNombre.Text = "Nombre requerido...";
            textBoxNombre.Enter += textBoxNombre_Enter;
            textBoxNombre.Leave += textBoxNombre_Leave;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(118, 160);
            labelNombre.Margin = new Padding(5, 0, 5, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(101, 24);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre:";
            // 
            // checkBoxAptoFisico
            // 
            checkBoxAptoFisico.AutoSize = true;
            checkBoxAptoFisico.Font = new Font("SimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAptoFisico.Location = new Point(570, 429);
            checkBoxAptoFisico.Margin = new Padding(5);
            checkBoxAptoFisico.Name = "checkBoxAptoFisico";
            checkBoxAptoFisico.Size = new Size(168, 25);
            checkBoxAptoFisico.TabIndex = 3;
            checkBoxAptoFisico.Text = "Apto Físico";
            checkBoxAptoFisico.UseVisualStyleBackColor = true;
            // 
            // checkBoxSocio
            // 
            checkBoxSocio.AutoSize = true;
            checkBoxSocio.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSocio.Location = new Point(118, 429);
            checkBoxSocio.Margin = new Padding(5);
            checkBoxSocio.Name = "checkBoxSocio";
            checkBoxSocio.Size = new Size(96, 25);
            checkBoxSocio.TabIndex = 2;
            checkBoxSocio.Text = "Socio";
            checkBoxSocio.UseVisualStyleBackColor = true;
            checkBoxSocio.CheckedChanged += checkBoxSocio_CheckedChanged;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Khaki;
            buttonVolver.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVolver.ForeColor = Color.Black;
            buttonVolver.Location = new Point(139, 632);
            buttonVolver.Margin = new Padding(5);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(288, 72);
            buttonVolver.TabIndex = 24;
            buttonVolver.Text = "VOLVER";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonVolver2
            // 
            buttonVolver2.BackColor = Color.YellowGreen;
            buttonVolver2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVolver2.ForeColor = Color.Black;
            buttonVolver2.Location = new Point(118, 484);
            buttonVolver2.Margin = new Padding(5);
            buttonVolver2.Name = "buttonVolver2";
            buttonVolver2.Size = new Size(220, 58);
            buttonVolver2.TabIndex = 25;
            buttonVolver2.Text = "VOLVER";
            buttonVolver2.UseVisualStyleBackColor = false;
            buttonVolver2.Click += buttonVolver2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(431, 208);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 24);
            label1.TabIndex = 26;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(431, 342);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 24);
            label2.TabIndex = 27;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(884, 208);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 24);
            label3.TabIndex = 28;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(884, 342);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(23, 24);
            label4.TabIndex = 29;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(735, 430);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(23, 24);
            label5.TabIndex = 30;
            label5.Text = "*";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonVolver2);
            Controls.Add(pictureBox1);
            Controls.Add(labelRegistroClientes);
            Controls.Add(buttonRegistrar);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxDni);
            Controls.Add(labelDireccion);
            Controls.Add(labelDni);
            Controls.Add(textBoxApellido);
            Controls.Add(labelApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Controls.Add(checkBoxAptoFisico);
            Controls.Add(checkBoxSocio);
            Controls.Add(buttonVolver);
            Margin = new Padding(4);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button buttonVolver;
        private CheckBox checkBoxSocio;
        private CheckBox checkBoxAptoFisico;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelApellido;
        private TextBox textBoxApellido;
        private Label labelDni;
        private Label labelDireccion;
        private TextBox textBoxDni;
        private TextBox textBoxDireccion;
        private Button buttonRegistrar;
        private Label labelRegistroClientes;
        private PictureBox pictureBox1;
        private Button buttonVolver2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}