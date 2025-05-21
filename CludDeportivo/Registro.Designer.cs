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
            textBoxDireccion.Location = new Point(570, 335);
            textBoxDireccion.Margin = new Padding(5);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(314, 31);
            textBoxDireccion.TabIndex = 20;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(570, 201);
            textBoxDni.Margin = new Padding(5);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(314, 31);
            textBoxDni.TabIndex = 19;
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
            textBoxApellido.Location = new Point(118, 335);
            textBoxApellido.Margin = new Padding(5);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(314, 31);
            textBoxApellido.TabIndex = 16;
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
            textBoxNombre.Location = new Point(118, 201);
            textBoxNombre.Margin = new Padding(5);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(314, 31);
            textBoxNombre.TabIndex = 14;
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
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
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
            Text = "Registro";
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
    }
}