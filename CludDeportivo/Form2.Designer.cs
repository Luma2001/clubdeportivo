namespace CludDeportivo
{
    partial class sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sistema));
            labelTitle = new Label();
            buttonRegistrar = new Button();
            buttonSalir = new Button();
            pictureBox1 = new PictureBox();
            buttonCobrar = new Button();
            buttonCarnet = new Button();
            buttonDeudor = new Button();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 178);
            labelTitle.Location = new Point(142, 7);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(437, 69);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Club Deportivo";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            labelTitle.Click += labelTitle_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.DarkCyan;
            buttonRegistrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonRegistrar.ForeColor = SystemColors.Control;
            buttonRegistrar.Location = new Point(219, 123);
            buttonRegistrar.Margin = new Padding(2, 2, 2, 2);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(162, 119);
            buttonRegistrar.TabIndex = 1;
            buttonRegistrar.Text = "Registrar Persona";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Red;
            buttonSalir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonSalir.ForeColor = Color.Snow;
            buttonSalir.Location = new Point(646, 403);
            buttonSalir.Margin = new Padding(2, 2, 2, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(90, 31);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 10);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonCobrar
            // 
            buttonCobrar.BackColor = Color.DarkCyan;
            buttonCobrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonCobrar.ForeColor = SystemColors.Control;
            buttonCobrar.Location = new Point(426, 126);
            buttonCobrar.Margin = new Padding(2, 2, 2, 2);
            buttonCobrar.Name = "buttonCobrar";
            buttonCobrar.Size = new Size(162, 119);
            buttonCobrar.TabIndex = 7;
            buttonCobrar.Text = "Cobrar";
            buttonCobrar.UseVisualStyleBackColor = false;
            // 
            // buttonCarnet
            // 
            buttonCarnet.BackColor = Color.DarkCyan;
            buttonCarnet.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonCarnet.ForeColor = SystemColors.Control;
            buttonCarnet.Location = new Point(219, 285);
            buttonCarnet.Margin = new Padding(2, 2, 2, 2);
            buttonCarnet.Name = "buttonCarnet";
            buttonCarnet.Size = new Size(162, 119);
            buttonCarnet.TabIndex = 8;
            buttonCarnet.Text = "Emitir Carnet";
            buttonCarnet.UseVisualStyleBackColor = false;
            // 
            // buttonDeudor
            // 
            buttonDeudor.BackColor = Color.DarkCyan;
            buttonDeudor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonDeudor.ForeColor = SystemColors.Control;
            buttonDeudor.Location = new Point(426, 285);
            buttonDeudor.Margin = new Padding(2, 2, 2, 2);
            buttonDeudor.Name = "buttonDeudor";
            buttonDeudor.Size = new Size(162, 119);
            buttonDeudor.TabIndex = 9;
            buttonDeudor.Text = "Lista Deudores";
            buttonDeudor.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(28, 428);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 20);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "Usuario: ";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // sistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 456);
            Controls.Add(lblUsuario);
            Controls.Add(buttonDeudor);
            Controls.Add(buttonCarnet);
            Controls.Add(buttonCobrar);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonRegistrar);
            Controls.Add(labelTitle);
            Margin = new Padding(2, 2, 2, 2);
            Name = "sistema";
            Text = "Sistema Club Deportivo";
            Load += sistema_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonRegistrar;
        private Button buttonSalir;
        private PictureBox pictureBox1;
        private Button buttonCobrar;
        private Button buttonCarnet;
        private Button buttonDeudor;
        private Label lblUsuario;
    }
}