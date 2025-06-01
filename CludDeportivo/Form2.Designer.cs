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
            labelTitle.Location = new Point(177, 8);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(526, 82);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Club Deportivo";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.DarkCyan;
            buttonRegistrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonRegistrar.ForeColor = SystemColors.Control;
            buttonRegistrar.Location = new Point(274, 153);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(203, 148);
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
            buttonSalir.Location = new Point(807, 503);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(113, 38);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonCobrar
            // 
            buttonCobrar.BackColor = Color.DarkCyan;
            buttonCobrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonCobrar.ForeColor = SystemColors.Control;
            buttonCobrar.Location = new Point(533, 157);
            buttonCobrar.Name = "buttonCobrar";
            buttonCobrar.Size = new Size(203, 148);
            buttonCobrar.TabIndex = 7;
            buttonCobrar.Text = "Cobrar";
            buttonCobrar.UseVisualStyleBackColor = false;
            buttonCobrar.Click += buttonCobrar_Click;
            // 
            // buttonCarnet
            // 
            buttonCarnet.BackColor = Color.DarkCyan;
            buttonCarnet.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonCarnet.ForeColor = SystemColors.Control;
            buttonCarnet.Location = new Point(274, 357);
            buttonCarnet.Name = "buttonCarnet";
            buttonCarnet.Size = new Size(203, 148);
            buttonCarnet.TabIndex = 8;
            buttonCarnet.Text = "Emitir Carnet";
            buttonCarnet.UseVisualStyleBackColor = false;
            // 
            // buttonDeudor
            // 
            buttonDeudor.BackColor = Color.DarkCyan;
            buttonDeudor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonDeudor.ForeColor = SystemColors.Control;
            buttonDeudor.Location = new Point(533, 357);
            buttonDeudor.Name = "buttonDeudor";
            buttonDeudor.Size = new Size(203, 148);
            buttonDeudor.TabIndex = 9;
            buttonDeudor.Text = "Lista Deudores";
            buttonDeudor.UseVisualStyleBackColor = false;
            buttonDeudor.Click += buttonDeudor_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(34, 535);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 25);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "Usuario: ";
            // 
            // sistema
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 570);
            Controls.Add(lblUsuario);
            Controls.Add(buttonDeudor);
            Controls.Add(buttonCarnet);
            Controls.Add(buttonCobrar);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonRegistrar);
            Controls.Add(labelTitle);
            Name = "sistema";
            StartPosition = FormStartPosition.CenterScreen;
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