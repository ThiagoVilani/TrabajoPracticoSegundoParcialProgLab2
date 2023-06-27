namespace TrabajoPracticoPrimerParcial
{
    partial class FormReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            lblCut2 = new Label();
            lblPrice2 = new Label();
            lblTotal2 = new Label();
            lvTicket = new ListView();
            cProduct = new ColumnHeader();
            cPrice = new ColumnHeader();
            lblSubtotal = new Label();
            lblSurcharges = new Label();
            lblTotal = new Label();
            lblTicket = new Label();
            btnReady = new Button();
            SuspendLayout();
            // 
            // lblCut2
            // 
            lblCut2.AutoSize = true;
            lblCut2.Font = new Font("Sitka Text", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCut2.Location = new Point(185, 28);
            lblCut2.Name = "lblCut2";
            lblCut2.Size = new Size(0, 23);
            lblCut2.TabIndex = 3;
            // 
            // lblPrice2
            // 
            lblPrice2.AutoSize = true;
            lblPrice2.Font = new Font("Sitka Text", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPrice2.Location = new Point(185, 64);
            lblPrice2.Name = "lblPrice2";
            lblPrice2.Size = new Size(0, 23);
            lblPrice2.TabIndex = 4;
            // 
            // lblTotal2
            // 
            lblTotal2.AutoSize = true;
            lblTotal2.Font = new Font("Sitka Text", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTotal2.Location = new Point(185, 102);
            lblTotal2.Name = "lblTotal2";
            lblTotal2.Size = new Size(0, 23);
            lblTotal2.TabIndex = 5;
            // 
            // lvTicket
            // 
            lvTicket.BackColor = Color.FromArgb(192, 192, 255);
            lvTicket.Columns.AddRange(new ColumnHeader[] { cProduct, cPrice });
            lvTicket.Location = new Point(12, 42);
            lvTicket.Name = "lvTicket";
            lvTicket.Size = new Size(243, 222);
            lvTicket.TabIndex = 6;
            lvTicket.UseCompatibleStateImageBehavior = false;
            lvTicket.View = View.Details;
            // 
            // cProduct
            // 
            cProduct.Text = "Producto";
            // 
            // cPrice
            // 
            cPrice.Text = "Precio";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.FromArgb(192, 192, 255);
            lblSubtotal.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtotal.Location = new Point(12, 267);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(67, 18);
            lblSubtotal.TabIndex = 7;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblSurcharges
            // 
            lblSurcharges.AutoSize = true;
            lblSurcharges.BackColor = Color.FromArgb(192, 192, 255);
            lblSurcharges.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSurcharges.Location = new Point(12, 290);
            lblSurcharges.Name = "lblSurcharges";
            lblSurcharges.Size = new Size(75, 18);
            lblSurcharges.TabIndex = 8;
            lblSurcharges.Text = "Recargos: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(192, 192, 255);
            lblTotal.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(12, 313);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 18);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total:";
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.BackColor = Color.Transparent;
            lblTicket.Font = new Font("Sitka Small", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTicket.Location = new Point(12, 15);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(75, 24);
            lblTicket.TabIndex = 10;
            lblTicket.Text = "Factura";
            // 
            // btnReady
            // 
            btnReady.BackColor = Color.FromArgb(192, 192, 255);
            btnReady.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnReady.Location = new Point(172, 306);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(83, 25);
            btnReady.TabIndex = 11;
            btnReady.Text = "Listo!";
            btnReady.UseVisualStyleBackColor = false;
            btnReady.Click += btnReady_Click;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.grass_frame_2;
            ClientSize = new Size(267, 348);
            Controls.Add(btnReady);
            Controls.Add(lblTicket);
            Controls.Add(lblTotal);
            Controls.Add(lblSurcharges);
            Controls.Add(lblSubtotal);
            Controls.Add(lvTicket);
            Controls.Add(lblTotal2);
            Controls.Add(lblPrice2);
            Controls.Add(lblCut2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(283, 387);
            MinimumSize = new Size(283, 387);
            Name = "FormTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCut2;
        private Label lblPrice2;
        private Label lblTotal2;
        private ListView lvTicket;
        private ColumnHeader cProduct;
        private ColumnHeader cPrice;
        private Label lblSubtotal;
        private Label lblSurcharges;
        private Label lblTotal;
        private Label lblTicket;
        private Button btnReady;
    }
}