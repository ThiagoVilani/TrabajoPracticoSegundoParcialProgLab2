namespace TrabajoPracticoPrimerParcial
{
    partial class FormMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainScreen));
            labelCarniceria = new Label();
            btnVendedor = new Button();
            btnCliente = new Button();
            labelElegirRol = new Label();
            ACS = new Button();
            lblIncorrect = new Label();
            txtbPassword = new TextBox();
            txtbMail = new TextBox();
            labelContrasenaLogin = new Label();
            labelNombreLogin = new Label();
            pbMostrarPass = new PictureBox();
            pbOcultarPass = new PictureBox();
            ACC = new Button();
            ((System.ComponentModel.ISupportInitialize)pbMostrarPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultarPass).BeginInit();
            SuspendLayout();
            // 
            // labelCarniceria
            // 
            labelCarniceria.AutoSize = true;
            labelCarniceria.BackColor = Color.Transparent;
            labelCarniceria.FlatStyle = FlatStyle.Flat;
            labelCarniceria.Font = new Font("Sylfaen", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCarniceria.ForeColor = Color.White;
            labelCarniceria.Location = new Point(404, 28);
            labelCarniceria.Name = "labelCarniceria";
            labelCarniceria.Size = new Size(319, 84);
            labelCarniceria.TabIndex = 0;
            labelCarniceria.Text = "Carniceria";
            // 
            // btnVendedor
            // 
            btnVendedor.BackColor = Color.FromArgb(192, 192, 255);
            btnVendedor.Font = new Font("Sitka Subheading", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnVendedor.ForeColor = Color.Black;
            btnVendedor.Location = new Point(341, 400);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(172, 41);
            btnVendedor.TabIndex = 2;
            btnVendedor.Text = "Vendedor";
            btnVendedor.UseVisualStyleBackColor = false;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(192, 192, 255);
            btnCliente.Font = new Font("Sitka Subheading", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.Location = new Point(593, 400);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(169, 41);
            btnCliente.TabIndex = 3;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // labelElegirRol
            // 
            labelElegirRol.AutoSize = true;
            labelElegirRol.BackColor = Color.Transparent;
            labelElegirRol.Font = new Font("Sitka Subheading", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelElegirRol.ForeColor = Color.White;
            labelElegirRol.Location = new Point(488, 356);
            labelElegirRol.Name = "labelElegirRol";
            labelElegirRol.Size = new Size(165, 35);
            labelElegirRol.TabIndex = 4;
            labelElegirRol.Text = "Iniciar como...";
            // 
            // ACS
            // 
            ACS.BackColor = Color.Black;
            ACS.Cursor = Cursors.Hand;
            ACS.FlatStyle = FlatStyle.Flat;
            ACS.Font = new Font("Sitka Subheading", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ACS.ForeColor = Color.Black;
            ACS.Location = new Point(290, 417);
            ACS.Name = "ACS";
            ACS.Size = new Size(45, 15);
            ACS.TabIndex = 17;
            ACS.Text = "AC";
            ACS.UseVisualStyleBackColor = false;
            ACS.Click += ACS_Click;
            // 
            // lblIncorrect
            // 
            lblIncorrect.AutoSize = true;
            lblIncorrect.BackColor = Color.Transparent;
            lblIncorrect.Font = new Font("Sitka Subheading", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncorrect.ForeColor = Color.Red;
            lblIncorrect.Location = new Point(457, 272);
            lblIncorrect.Name = "lblIncorrect";
            lblIncorrect.Size = new Size(305, 29);
            lblIncorrect.TabIndex = 16;
            lblIncorrect.Text = "Usuario o Contraseña incorrectos";
            lblIncorrect.Visible = false;
            // 
            // txtbPassword
            // 
            txtbPassword.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtbPassword.Location = new Point(488, 240);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.PasswordChar = '*';
            txtbPassword.Size = new Size(225, 29);
            txtbPassword.TabIndex = 12;
            // 
            // txtbMail
            // 
            txtbMail.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtbMail.Location = new Point(488, 167);
            txtbMail.Name = "txtbMail";
            txtbMail.Size = new Size(274, 29);
            txtbMail.TabIndex = 11;
            // 
            // labelContrasenaLogin
            // 
            labelContrasenaLogin.AutoSize = true;
            labelContrasenaLogin.BackColor = Color.Transparent;
            labelContrasenaLogin.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelContrasenaLogin.ForeColor = Color.Transparent;
            labelContrasenaLogin.Location = new Point(341, 234);
            labelContrasenaLogin.Name = "labelContrasenaLogin";
            labelContrasenaLogin.Size = new Size(141, 35);
            labelContrasenaLogin.TabIndex = 10;
            labelContrasenaLogin.Text = "Contraseña";
            // 
            // labelNombreLogin
            // 
            labelNombreLogin.AutoSize = true;
            labelNombreLogin.BackColor = Color.Transparent;
            labelNombreLogin.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombreLogin.ForeColor = Color.Transparent;
            labelNombreLogin.Location = new Point(341, 161);
            labelNombreLogin.Name = "labelNombreLogin";
            labelNombreLogin.Size = new Size(80, 35);
            labelNombreLogin.TabIndex = 9;
            labelNombreLogin.Text = "Email";
            // 
            // pbMostrarPass
            // 
            pbMostrarPass.BackgroundImageLayout = ImageLayout.Zoom;
            pbMostrarPass.Image = Properties.Resources.show;
            pbMostrarPass.Location = new Point(719, 231);
            pbMostrarPass.Name = "pbMostrarPass";
            pbMostrarPass.Size = new Size(43, 38);
            pbMostrarPass.SizeMode = PictureBoxSizeMode.Zoom;
            pbMostrarPass.TabIndex = 14;
            pbMostrarPass.TabStop = false;
            pbMostrarPass.Click += pbMostrarPass_Click;
            // 
            // pbOcultarPass
            // 
            pbOcultarPass.BackgroundImageLayout = ImageLayout.Zoom;
            pbOcultarPass.Image = Properties.Resources.hide;
            pbOcultarPass.Location = new Point(719, 231);
            pbOcultarPass.Name = "pbOcultarPass";
            pbOcultarPass.Size = new Size(43, 38);
            pbOcultarPass.SizeMode = PictureBoxSizeMode.Zoom;
            pbOcultarPass.TabIndex = 15;
            pbOcultarPass.TabStop = false;
            pbOcultarPass.Click += pbOcultarPass_Click;
            // 
            // ACC
            // 
            ACC.BackColor = Color.Black;
            ACC.Cursor = Cursors.Hand;
            ACC.FlatStyle = FlatStyle.Flat;
            ACC.Font = new Font("Sitka Subheading", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ACC.ForeColor = Color.Black;
            ACC.Location = new Point(768, 417);
            ACC.Name = "ACC";
            ACC.Size = new Size(45, 15);
            ACC.TabIndex = 18;
            ACC.Text = "AC";
            ACC.UseVisualStyleBackColor = false;
            ACC.Click += ACC_Click;
            // 
            // FormMainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Sin_título_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 577);
            Controls.Add(ACC);
            Controls.Add(ACS);
            Controls.Add(lblIncorrect);
            Controls.Add(txtbPassword);
            Controls.Add(txtbMail);
            Controls.Add(labelContrasenaLogin);
            Controls.Add(labelNombreLogin);
            Controls.Add(pbMostrarPass);
            Controls.Add(pbOcultarPass);
            Controls.Add(labelElegirRol);
            Controls.Add(btnCliente);
            Controls.Add(btnVendedor);
            Controls.Add(labelCarniceria);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)pbMostrarPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultarPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCarniceria;
        private Button btnVendedor;
        private Button btnCliente;
        private Label labelElegirRol;
        private Button ACS;
        private Label lblIncorrect;
        private TextBox txtbPassword;
        private TextBox txtbMail;
        private Label labelContrasenaLogin;
        private Label labelNombreLogin;
        private PictureBox pbMostrarPass;
        private PictureBox pbOcultarPass;
        private Button ACC;
    }
}