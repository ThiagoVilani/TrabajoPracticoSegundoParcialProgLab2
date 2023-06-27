namespace TrabajoPracticoPrimerParcial
{
    partial class FormLoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginUser));
            lblInputMoney = new Label();
            txtbInputMoney = new TextBox();
            btnInputMoney = new Button();
            lblIncorrectInput = new Label();
            SuspendLayout();
            // 
            // lblInputMoney
            // 
            lblInputMoney.BackColor = Color.Transparent;
            lblInputMoney.Font = new Font("Sitka Subheading", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblInputMoney.Location = new Point(286, 64);
            lblInputMoney.Name = "lblInputMoney";
            lblInputMoney.Size = new Size(643, 40);
            lblInputMoney.TabIndex = 0;
            lblInputMoney.Text = "¿Con cuanto dinero cuenta para comprar?";
            // 
            // txtbInputMoney
            // 
            txtbInputMoney.BackColor = Color.FromArgb(192, 192, 255);
            txtbInputMoney.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtbInputMoney.ForeColor = SystemColors.WindowText;
            txtbInputMoney.Location = new Point(431, 244);
            txtbInputMoney.Name = "txtbInputMoney";
            txtbInputMoney.PlaceholderText = "Ingrese el monto en pesos";
            txtbInputMoney.Size = new Size(272, 33);
            txtbInputMoney.TabIndex = 1;
            // 
            // btnInputMoney
            // 
            btnInputMoney.BackColor = Color.FromArgb(192, 192, 255);
            btnInputMoney.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnInputMoney.ForeColor = Color.Black;
            btnInputMoney.Location = new Point(499, 310);
            btnInputMoney.Name = "btnInputMoney";
            btnInputMoney.Size = new Size(139, 41);
            btnInputMoney.TabIndex = 2;
            btnInputMoney.Text = "Listo!";
            btnInputMoney.UseVisualStyleBackColor = false;
            btnInputMoney.Click += btnInputMoney_Click;
            // 
            // lblIncorrectInput
            // 
            lblIncorrectInput.AutoSize = true;
            lblIncorrectInput.BackColor = Color.White;
            lblIncorrectInput.Font = new Font("Sitka Subheading", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblIncorrectInput.ForeColor = Color.FromArgb(192, 0, 0);
            lblIncorrectInput.Location = new Point(446, 280);
            lblIncorrectInput.Name = "lblIncorrectInput";
            lblIncorrectInput.Size = new Size(237, 21);
            lblIncorrectInput.TabIndex = 3;
            lblIncorrectInput.Text = "Dato incorrecto, vuelva a intentarlo";
            lblIncorrectInput.Visible = false;
            // 
            // FormLoginUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.leon_ephraim_AxoNnnH1Y98_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 649);
            Controls.Add(lblIncorrectInput);
            Controls.Add(btnInputMoney);
            Controls.Add(txtbInputMoney);
            Controls.Add(lblInputMoney);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(445, 191);
            Name = "FormLoginUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLoginUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInputMoney;
        private TextBox txtbInputMoney;
        private Button btnInputMoney;
        private Label lblIncorrectInput;
    }
}