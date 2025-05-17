namespace CludDeportivo
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            logo = new PictureBox();
            userLabel = new Label();
            passLabel = new Label();
            buttonLogin = new Button();
            textUser = new TextBox();
            textPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(45, 39);
            logo.Margin = new Padding(2, 2, 2, 2);
            logo.Name = "logo";
            logo.Size = new Size(225, 188);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            userLabel.ForeColor = Color.DarkCyan;
            userLabel.Location = new Point(294, 37);
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(76, 20);
            userLabel.TabIndex = 3;
            userLabel.Text = "Usuario:";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            passLabel.ForeColor = Color.DarkCyan;
            passLabel.Location = new Point(294, 122);
            passLabel.Margin = new Padding(2, 0, 2, 0);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(107, 20);
            passLabel.TabIndex = 4;
            passLabel.Text = "Contraseña:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkSlateGray;
            buttonLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 178);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(315, 193);
            buttonLogin.Margin = new Padding(2, 2, 2, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 34);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Iniciar Sesión";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textUser
            // 
            textUser.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            textUser.Location = new Point(315, 74);
            textUser.Margin = new Padding(2, 2, 2, 2);
            textUser.Name = "textUser";
            textUser.Size = new Size(201, 21);
            textUser.TabIndex = 8;
            textUser.Text = "Ingresar Usuario...";
            textUser.TextAlign = HorizontalAlignment.Center;
            textUser.Enter += textUser_Enter;
            textUser.Leave += textUser_Leave;
            // 
            // textPass
            // 
            textPass.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            textPass.Location = new Point(315, 155);
            textPass.Margin = new Padding(2, 2, 2, 2);
            textPass.Name = "textPass";
            textPass.Size = new Size(201, 21);
            textPass.TabIndex = 9;
            textPass.Tag = "";
            textPass.Text = "Ingresar Contraseña...";
            textPass.TextAlign = HorizontalAlignment.Center;
            textPass.Enter += textPass_Enter;
            textPass.Leave += textPass_Leave;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(560, 270);
            Controls.Add(textPass);
            Controls.Add(textUser);
            Controls.Add(buttonLogin);
            Controls.Add(passLabel);
            Controls.Add(userLabel);
            Controls.Add(logo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormLogin";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label userLabel;
        private Label passLabel;
        private Button buttonLogin;
        private TextBox textUser;
        private TextBox textPass;
    }
}
