namespace TrabajoPracticoPrimerParcial
{
    partial class FormSellerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSellerMenu));
            btnRefrigerator = new Button();
            btnStock = new Button();
            lblMenu = new Label();
            btnProductsToTxt = new Button();
            SuspendLayout();
            // 
            // btnRefrigerator
            // 
            btnRefrigerator.BackColor = Color.AntiqueWhite;
            btnRefrigerator.Location = new Point(203, 315);
            btnRefrigerator.Name = "btnRefrigerator";
            btnRefrigerator.Size = new Size(228, 56);
            btnRefrigerator.TabIndex = 0;
            btnRefrigerator.Text = "Heladera";
            btnRefrigerator.UseVisualStyleBackColor = false;
            btnRefrigerator.Click += btnRefrigerator_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.AntiqueWhite;
            btnStock.Location = new Point(663, 315);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(228, 56);
            btnStock.TabIndex = 1;
            btnStock.Text = "Reponer Productos";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.Font = new Font("Sitka Small", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(487, 120);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(132, 54);
            lblMenu.TabIndex = 2;
            lblMenu.Text = "Menu";
            // 
            // btnProductsToTxt
            // 
            btnProductsToTxt.BackColor = Color.AntiqueWhite;
            btnProductsToTxt.Location = new Point(435, 437);
            btnProductsToTxt.Name = "btnProductsToTxt";
            btnProductsToTxt.Size = new Size(228, 56);
            btnProductsToTxt.TabIndex = 3;
            btnProductsToTxt.Text = "Descargar listado de Productos";
            btnProductsToTxt.UseVisualStyleBackColor = false;
            btnProductsToTxt.Click += btnProductsToTxt_Click;
            // 
            // FormSellerMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Sin_título_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 577);
            Controls.Add(btnProductsToTxt);
            Controls.Add(lblMenu);
            Controls.Add(btnStock);
            Controls.Add(btnRefrigerator);
            Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormSellerMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefrigerator;
        private Button btnStock;
        private Label lblMenu;
        private Button btnProductsToTxt;
    }
}