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
            labelTitle.Font = new Font("Simple Indust Outline", 36F, FontStyle.Bold, GraphicsUnit.Point, 178);
            labelTitle.Location = new Point(177, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(738, 131);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Club Deportivo";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            labelTitle.Click += labelTitle_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.DarkCyan;
            buttonRegistrar.Font = new Font("Simple Indust Outline", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonRegistrar.ForeColor = SystemColors.Control;
            buttonRegistrar.Location = new Point(274, 154);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(203, 149);
            buttonRegistrar.TabIndex = 1;
            buttonRegistrar.Text = "Registrar Persona";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Red;
            buttonSalir.Font = new Font("Simple Indust Outline", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonSalir.ForeColor = Color.Snow;
            buttonSalir.Location = new Point(807, 504);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(112, 39);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonCobrar
            // 
            buttonCobrar.BackColor = Color.DarkCyan;
            buttonCobrar.Font = new Font("Simple Indust Outline", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonCobrar.ForeColor = SystemColors.Control;
            buttonCobrar.Location = new Point(532, 157);
            buttonCobrar.Name = "buttonCobrar";
            buttonCobrar.Size = new Size(203, 149);
            buttonCobrar.TabIndex = 7;
            buttonCobrar.Text = "Cobrar";
            buttonCobrar.UseVisualStyleBackColor = false;
            // 
            // buttonCarnet
            // 
            buttonCarnet.BackColor = Color.DarkCyan;
            buttonCarnet.Font = new Font("Simple Indust Outline", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonCarnet.ForeColor = SystemColors.Control;
            buttonCarnet.Location = new Point(274, 356);
            buttonCarnet.Name = "buttonCarnet";
            buttonCarnet.Size = new Size(203, 149);
            buttonCarnet.TabIndex = 8;
            buttonCarnet.Text = "Emitir Carnet";
            buttonCarnet.UseVisualStyleBackColor = false;
            // 
            // buttonDeudor
            // 
            buttonDeudor.BackColor = Color.DarkCyan;
            buttonDeudor.Font = new Font("Simple Indust Outline", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonDeudor.ForeColor = SystemColors.Control;
            buttonDeudor.Location = new Point(532, 356);
            buttonDeudor.Name = "buttonDeudor";
            buttonDeudor.Size = new Size(203, 149);
            buttonDeudor.TabIndex = 9;
            buttonDeudor.Text = "Lista Deudores";
            buttonDeudor.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(35, 535);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 25);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "Usuario: ";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // sistema
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 570);
            Controls.Add(lblUsuario);
            Controls.Add(buttonDeudor);
            Controls.Add(buttonCarnet);
            Controls.Add(buttonCobrar);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonRegistrar);
            Controls.Add(labelTitle);
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