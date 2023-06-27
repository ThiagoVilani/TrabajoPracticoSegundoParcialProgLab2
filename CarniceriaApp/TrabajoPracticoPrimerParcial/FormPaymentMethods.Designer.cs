namespace TrabajoPracticoPrimerParcial
{
    partial class FormPaymentMethods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaymentMethods));
            lblPaymentMethod = new Label();
            gbPaymentMethods = new GroupBox();
            btnBack = new Button();
            btnReady = new Button();
            lblNoMoney = new Label();
            rbtnMP = new RadioButton();
            rbtnCash = new RadioButton();
            rbtnCredit = new RadioButton();
            rbtnDebit = new RadioButton();
            gbPaymentMethods.SuspendLayout();
            SuspendLayout();
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.BackColor = Color.Transparent;
            lblPaymentMethod.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPaymentMethod.ForeColor = Color.White;
            lblPaymentMethod.Location = new Point(388, 140);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(383, 43);
            lblPaymentMethod.TabIndex = 0;
            lblPaymentMethod.Text = "¿Con cual metodo paga?";
            lblPaymentMethod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbPaymentMethods
            // 
            gbPaymentMethods.AutoSize = true;
            gbPaymentMethods.BackgroundImage = Properties.Resources.Sin_título_1;
            gbPaymentMethods.BackgroundImageLayout = ImageLayout.Stretch;
            gbPaymentMethods.Controls.Add(btnBack);
            gbPaymentMethods.Controls.Add(btnReady);
            gbPaymentMethods.Controls.Add(lblNoMoney);
            gbPaymentMethods.Controls.Add(rbtnMP);
            gbPaymentMethods.Controls.Add(rbtnCash);
            gbPaymentMethods.Controls.Add(rbtnCredit);
            gbPaymentMethods.Controls.Add(rbtnDebit);
            gbPaymentMethods.Controls.Add(lblPaymentMethod);
            gbPaymentMethods.Dock = DockStyle.Fill;
            gbPaymentMethods.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            gbPaymentMethods.Location = new Point(0, 0);
            gbPaymentMethods.Name = "gbPaymentMethods";
            gbPaymentMethods.Size = new Size(1149, 577);
            gbPaymentMethods.TabIndex = 1;
            gbPaymentMethods.TabStop = false;
            gbPaymentMethods.Text = "Metodos de Pago";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.BlanchedAlmond;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Sitka Heading", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(512, 356);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 43);
            btnBack.TabIndex = 1;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            btnBack.Click += button1_Click;
            // 
            // btnReady
            // 
            btnReady.BackColor = Color.BlanchedAlmond;
            btnReady.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnReady.Location = new Point(529, 356);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(77, 43);
            btnReady.TabIndex = 5;
            btnReady.Text = "Listo!";
            btnReady.UseVisualStyleBackColor = false;
            btnReady.Click += btnReady_Click;
            // 
            // lblNoMoney
            // 
            lblNoMoney.AutoSize = true;
            lblNoMoney.BackColor = Color.Transparent;
            lblNoMoney.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNoMoney.ForeColor = Color.White;
            lblNoMoney.Location = new Point(448, 199);
            lblNoMoney.Name = "lblNoMoney";
            lblNoMoney.Size = new Size(264, 78);
            lblNoMoney.TabIndex = 0;
            lblNoMoney.Text = "¡Dinero insuficiente! \r\nCompra cancelada";
            lblNoMoney.TextAlign = ContentAlignment.MiddleCenter;
            lblNoMoney.Visible = false;
            // 
            // rbtnMP
            // 
            rbtnMP.AutoSize = true;
            rbtnMP.BackColor = Color.Transparent;
            rbtnMP.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            rbtnMP.ForeColor = Color.White;
            rbtnMP.Location = new Point(753, 356);
            rbtnMP.Name = "rbtnMP";
            rbtnMP.Size = new Size(193, 43);
            rbtnMP.TabIndex = 4;
            rbtnMP.TabStop = true;
            rbtnMP.Text = "MercadoPago";
            rbtnMP.TextAlign = ContentAlignment.MiddleCenter;
            rbtnMP.UseVisualStyleBackColor = false;
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.BackColor = Color.Transparent;
            rbtnCash.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            rbtnCash.ForeColor = Color.White;
            rbtnCash.Location = new Point(799, 199);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Size = new Size(129, 43);
            rbtnCash.TabIndex = 3;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Efectivo";
            rbtnCash.TextAlign = ContentAlignment.MiddleCenter;
            rbtnCash.UseVisualStyleBackColor = false;
            // 
            // rbtnCredit
            // 
            rbtnCredit.AutoSize = true;
            rbtnCredit.BackColor = Color.Transparent;
            rbtnCredit.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            rbtnCredit.ForeColor = Color.White;
            rbtnCredit.Location = new Point(205, 351);
            rbtnCredit.Name = "rbtnCredit";
            rbtnCredit.Size = new Size(121, 43);
            rbtnCredit.TabIndex = 2;
            rbtnCredit.TabStop = true;
            rbtnCredit.Text = "Credito";
            rbtnCredit.TextAlign = ContentAlignment.MiddleCenter;
            rbtnCredit.UseVisualStyleBackColor = false;
            // 
            // rbtnDebit
            // 
            rbtnDebit.AutoSize = true;
            rbtnDebit.BackColor = Color.Transparent;
            rbtnDebit.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            rbtnDebit.ForeColor = Color.White;
            rbtnDebit.Location = new Point(205, 199);
            rbtnDebit.Name = "rbtnDebit";
            rbtnDebit.Size = new Size(111, 43);
            rbtnDebit.TabIndex = 1;
            rbtnDebit.TabStop = true;
            rbtnDebit.Text = "Debito";
            rbtnDebit.TextAlign = ContentAlignment.MiddleCenter;
            rbtnDebit.UseVisualStyleBackColor = false;
            // 
            // FormPaymentMethods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 577);
            Controls.Add(gbPaymentMethods);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(504, 350);
            Name = "FormPaymentMethods";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPaymentMethods";
            Resize += FormPaymentMethods_Resize;
            gbPaymentMethods.ResumeLayout(false);
            gbPaymentMethods.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPaymentMethod;
        private GroupBox gbPaymentMethods;
        private RadioButton rbtnMP;
        private RadioButton rbtnCash;
        private RadioButton rbtnCredit;
        private RadioButton rbtnDebit;
        private Button btnReady;
        private Button btnBack;
        private Label lblNoMoney;
    }
}