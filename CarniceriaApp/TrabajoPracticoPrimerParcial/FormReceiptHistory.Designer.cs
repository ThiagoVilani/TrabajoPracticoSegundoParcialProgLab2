namespace TrabajoPracticoPrimerParcial
{
    partial class FormReceiptHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceiptHistory));
            lvReceiptHistory = new ListView();
            cReceiptNumber = new ColumnHeader();
            cSeller = new ColumnHeader();
            cClient = new ColumnHeader();
            cTotal = new ColumnHeader();
            SuspendLayout();
            // 
            // lvReceiptHistory
            // 
            lvReceiptHistory.Columns.AddRange(new ColumnHeader[] { cReceiptNumber, cSeller, cClient, cTotal });
            lvReceiptHistory.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lvReceiptHistory.FullRowSelect = true;
            lvReceiptHistory.GridLines = true;
            lvReceiptHistory.Location = new Point(12, 12);
            lvReceiptHistory.Name = "lvReceiptHistory";
            lvReceiptHistory.Size = new Size(1125, 445);
            lvReceiptHistory.TabIndex = 0;
            lvReceiptHistory.UseCompatibleStateImageBehavior = false;
            lvReceiptHistory.View = View.Details;
            lvReceiptHistory.DoubleClick += lvReceiptHistory_DoubleClick;
            // 
            // cReceiptNumber
            // 
            cReceiptNumber.Text = "Numero de factura";
            // 
            // cSeller
            // 
            cSeller.Text = "Vendedor";
            // 
            // cClient
            // 
            cClient.Text = "Cliente";
            // 
            // cTotal
            // 
            cTotal.Text = "Total";
            // 
            // FormReceiptHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Sin_título_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 577);
            Controls.Add(lvReceiptHistory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1165, 616);
            MinimumSize = new Size(1165, 616);
            Name = "FormReceiptHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReceiptHistory";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvReceiptHistory;
        private ColumnHeader cReceiptNumber;
        private ColumnHeader cSeller;
        private ColumnHeader cClient;
        private ColumnHeader cTotal;
    }
}