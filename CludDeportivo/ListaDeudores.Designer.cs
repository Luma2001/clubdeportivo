namespace CludDeportivo
{
    partial class ListaDeudores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeudores));
            label1 = new Label();
            planillaDeudores = new DataGridView();
            SOCIO = new DataGridViewTextBoxColumn();
            ENCIMIENTO = new DataGridViewTextBoxColumn();
            logo = new PictureBox();
            panel1 = new Panel();
            btnVolver = new Button();
            btnCobrar = new Button();
            ((System.ComponentModel.ISupportInitialize)planillaDeudores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simple Indust Outline", 14F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(509, 51);
            label1.TabIndex = 1;
            label1.Text = "LISTADO DE DEUDORES";
            label1.Click += label1_Click;
            // 
            // planillaDeudores
            // 
            planillaDeudores.BackgroundColor = SystemColors.ButtonFace;
            planillaDeudores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planillaDeudores.Columns.AddRange(new DataGridViewColumn[] { SOCIO, ENCIMIENTO });
            planillaDeudores.Location = new Point(229, 143);
            planillaDeudores.Name = "planillaDeudores";
            planillaDeudores.RowHeadersWidth = 62;
            planillaDeudores.Size = new Size(545, 286);
            planillaDeudores.TabIndex = 2;
            planillaDeudores.CellContentClick += planillaDeudores_CellContentClick;
            // 
            // SOCIO
            // 
            SOCIO.HeaderText = "SOCIO";
            SOCIO.MinimumWidth = 8;
            SOCIO.Name = "SOCIO";
            SOCIO.Width = 150;
            // 
            // ENCIMIENTO
            // 
            ENCIMIENTO.HeaderText = "VENCIMIENTO";
            ENCIMIENTO.MinimumWidth = 8;
            ENCIMIENTO.Name = "ENCIMIENTO";
            ENCIMIENTO.Width = 150;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(22, 21);
            logo.Name = "logo";
            logo.Size = new Size(115, 99);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(133, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 99);
            panel1.TabIndex = 6;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkCyan;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(22, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(182, 50);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.DarkCyan;
            btnCobrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCobrar.ForeColor = SystemColors.ButtonHighlight;
            btnCobrar.Location = new Point(22, 287);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(182, 50);
            btnCobrar.TabIndex = 12;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // ListaDeudores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCobrar);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            Controls.Add(logo);
            Controls.Add(planillaDeudores);
            Name = "ListaDeudores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Deudores";
            Load += ListaDeudores_Load;
            ((System.ComponentModel.ISupportInitialize)planillaDeudores).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView planillaDeudores;
        private PictureBox logo;
        private Panel panel1;
        private DataGridViewTextBoxColumn SOCIO;
        private DataGridViewTextBoxColumn ENCIMIENTO;
        private Button btnVolver;
        private Button btnCobrar;
    }
}