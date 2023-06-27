namespace TrabajoPracticoPrimerParcial
{
    partial class FormAddStock
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
            lvProducts = new ListView();
            cProduct = new ColumnHeader();
            btnAdd = new Button();
            nudKilos = new NumericUpDown();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)nudKilos).BeginInit();
            SuspendLayout();
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { cProduct });
            lvProducts.Location = new Point(366, 34);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(438, 341);
            lvProducts.TabIndex = 0;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            // 
            // cProduct
            // 
            cProduct.Text = "Producto";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 192, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAdd.Location = new Point(587, 396);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar Stock";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // nudKilos
            // 
            nudKilos.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nudKilos.Location = new Point(503, 399);
            nudKilos.Name = "nudKilos";
            nudKilos.Size = new Size(67, 29);
            nudKilos.TabIndex = 2;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Black;
            lblError.Font = new Font("Sitka Small", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(366, 435);
            lblError.Name = "lblError";
            lblError.Size = new Size(444, 33);
            lblError.TabIndex = 3;
            lblError.Text = "Producto o cantidad no seleccionada";
            lblError.Visible = false;
            // 
            // FormAddStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Sin_título_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 577);
            Controls.Add(lblError);
            Controls.Add(nudKilos);
            Controls.Add(btnAdd);
            Controls.Add(lvProducts);
            MaximumSize = new Size(1165, 616);
            MinimumSize = new Size(1165, 616);
            Name = "FormAddStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)nudKilos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvProducts;
        private ColumnHeader cProduct;
        private Button btnAdd;
        private NumericUpDown nudKilos;
        private Label lblError;
    }
}