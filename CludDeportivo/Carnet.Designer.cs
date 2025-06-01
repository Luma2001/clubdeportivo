namespace CludDeportivo
{
    partial class Carnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet));
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlCarnet = new Panel();
            lblDNIValue = new Label();
            lblSocioDesdeValue = new Label();
            lblNombreValue = new Label();
            lblApellidoValue = new Label();
            lblSocioDesde = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            logo = new PictureBox();
            lblCarnetSocio = new Label();
            btnVolver = new Button();
            btnImprimir = new Button();
            pnlTitulo.SuspendLayout();
            pnlCarnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = SystemColors.ActiveCaption;
            pnlTitulo.BorderStyle = BorderStyle.FixedSingle;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Location = new Point(34, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(455, 33);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(126, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CLUB DEPORTIVO";
            // 
            // pnlCarnet
            // 
            pnlCarnet.BackColor = SystemColors.ActiveCaption;
            pnlCarnet.BorderStyle = BorderStyle.FixedSingle;
            pnlCarnet.Controls.Add(lblDNIValue);
            pnlCarnet.Controls.Add(lblSocioDesdeValue);
            pnlCarnet.Controls.Add(lblNombreValue);
            pnlCarnet.Controls.Add(lblApellidoValue);
            pnlCarnet.Controls.Add(lblSocioDesde);
            pnlCarnet.Controls.Add(lblDNI);
            pnlCarnet.Controls.Add(lblNombre);
            pnlCarnet.Controls.Add(lblApellido);
            pnlCarnet.Controls.Add(logo);
            pnlCarnet.Controls.Add(lblCarnetSocio);
            pnlCarnet.Location = new Point(34, 51);
            pnlCarnet.Name = "pnlCarnet";
            pnlCarnet.Size = new Size(455, 183);
            pnlCarnet.TabIndex = 2;
            // 
            // lblDNIValue
            // 
            lblDNIValue.AutoSize = true;
            lblDNIValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDNIValue.Location = new Point(18, 137);
            lblDNIValue.Name = "lblDNIValue";
            lblDNIValue.Size = new Size(35, 20);
            lblDNIValue.TabIndex = 11;
            lblDNIValue.Text = "DNI";
            // 
            // lblSocioDesdeValue
            // 
            lblSocioDesdeValue.AutoSize = true;
            lblSocioDesdeValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSocioDesdeValue.Location = new Point(171, 127);
            lblSocioDesdeValue.Name = "lblSocioDesdeValue";
            lblSocioDesdeValue.Size = new Size(88, 20);
            lblSocioDesdeValue.TabIndex = 10;
            lblSocioDesdeValue.Text = "SocioDesde";
            // 
            // lblNombreValue
            // 
            lblNombreValue.AutoSize = true;
            lblNombreValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreValue.Location = new Point(169, 85);
            lblNombreValue.Name = "lblNombreValue";
            lblNombreValue.Size = new Size(64, 20);
            lblNombreValue.TabIndex = 9;
            lblNombreValue.Text = "Nombre";
            // 
            // lblApellidoValue
            // 
            lblApellidoValue.AutoSize = true;
            lblApellidoValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoValue.Location = new Point(169, 39);
            lblApellidoValue.Name = "lblApellidoValue";
            lblApellidoValue.Size = new Size(66, 20);
            lblApellidoValue.TabIndex = 8;
            lblApellidoValue.Text = "Apellido";
            // 
            // lblSocioDesde
            // 
            lblSocioDesde.AutoSize = true;
            lblSocioDesde.Location = new Point(169, 147);
            lblSocioDesde.Name = "lblSocioDesde";
            lblSocioDesde.Size = new Size(70, 15);
            lblSocioDesde.TabIndex = 7;
            lblSocioDesde.Text = "Socio desde";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(18, 156);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 6;
            lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(169, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(169, 59);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(18, 19);
            logo.Margin = new Padding(2);
            logo.Name = "logo";
            logo.Size = new Size(129, 116);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // lblCarnetSocio
            // 
            lblCarnetSocio.AutoSize = true;
            lblCarnetSocio.Location = new Point(169, 0);
            lblCarnetSocio.Name = "lblCarnetSocio";
            lblCarnetSocio.Size = new Size(107, 15);
            lblCarnetSocio.TabIndex = 0;
            lblCarnetSocio.Text = "CARNET DE SOCIO";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Bisque;
            btnVolver.Location = new Point(34, 255);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(334, 248);
            btnImprimir.Margin = new Padding(2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(155, 36);
            btnImprimir.TabIndex = 10;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // Carnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 291);
            Controls.Add(btnImprimir);
            Controls.Add(btnVolver);
            Controls.Add(pnlCarnet);
            Controls.Add(pnlTitulo);
            Name = "Carnet";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carnet";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlCarnet.ResumeLayout(false);
            pnlCarnet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlCarnet;
        private Label lblCarnetSocio;
        private PictureBox logo;
        private Label lblSocioDesde;
        private Label lblDNI;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblNombreValue;
        private Label lblApellidoValue;
        private Label lblDNIValue;
        private Label lblSocioDesdeValue;
        private Button btnVolver;
        private Button btnImprimir;
    }
}