namespace TrabajoPracticoPrimerParcial
{
    partial class FormPurchaseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchaseScreen));
            txtbFilter = new TextBox();
            lblFilter = new Label();
            lvCart = new ListView();
            cCutName = new ColumnHeader();
            cPrice = new ColumnHeader();
            dgvProductsGrid = new DataGridView();
            columnaCorte = new DataGridViewTextBoxColumn();
            columnaStock = new DataGridViewTextBoxColumn();
            columnaPrecio = new DataGridViewTextBoxColumn();
            columnaDetalles = new DataGridViewTextBoxColumn();
            btnAddToCart = new Button();
            lblSelectQuantity = new Label();
            nudKilos = new NumericUpDown();
            lblSelectedProduct = new Label();
            gbAddProductToCart = new GroupBox();
            lblTotal = new Label();
            btnDeleteProduct = new Button();
            label1 = new Label();
            btnFilter = new Button();
            btnCleanFilters = new Button();
            btnPayNow = new Button();
            lblRemainingMoney = new Label();
            lblErrorSelection = new Label();
            lblErrorCart = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilos).BeginInit();
            gbAddProductToCart.SuspendLayout();
            SuspendLayout();
            // 
            // txtbFilter
            // 
            txtbFilter.Location = new Point(14, 21);
            txtbFilter.Margin = new Padding(3, 2, 3, 2);
            txtbFilter.Name = "txtbFilter";
            txtbFilter.PlaceholderText = "Ingrese el nombre";
            txtbFilter.Size = new Size(220, 23);
            txtbFilter.TabIndex = 1;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.BackColor = Color.FromArgb(192, 192, 255);
            lblFilter.Font = new Font("Sitka Subheading", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblFilter.Location = new Point(14, 1);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(93, 18);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Buscar por Corte";
            // 
            // lvCart
            // 
            lvCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lvCart.Columns.AddRange(new ColumnHeader[] { cCutName, cPrice });
            lvCart.Location = new Point(946, 48);
            lvCart.Margin = new Padding(3, 2, 3, 2);
            lvCart.Name = "lvCart";
            lvCart.Size = new Size(199, 476);
            lvCart.TabIndex = 17;
            lvCart.UseCompatibleStateImageBehavior = false;
            lvCart.View = View.Details;
            // 
            // cCutName
            // 
            cCutName.Text = "Corte";
            // 
            // cPrice
            // 
            cPrice.Text = "Precio";
            // 
            // dgvProductsGrid
            // 
            dgvProductsGrid.AllowDrop = true;
            dgvProductsGrid.AllowUserToOrderColumns = true;
            dgvProductsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductsGrid.BackgroundColor = Color.White;
            dgvProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsGrid.Columns.AddRange(new DataGridViewColumn[] { columnaCorte, columnaStock, columnaPrecio, columnaDetalles });
            dgvProductsGrid.Location = new Point(12, 48);
            dgvProductsGrid.Margin = new Padding(3, 2, 3, 2);
            dgvProductsGrid.Name = "dgvProductsGrid";
            dgvProductsGrid.ReadOnly = true;
            dgvProductsGrid.RowHeadersWidth = 51;
            dgvProductsGrid.RowTemplate.Height = 29;
            dgvProductsGrid.Size = new Size(927, 476);
            dgvProductsGrid.TabIndex = 18;
            dgvProductsGrid.CellClick += dgvProductsGrid_CellClick;
            // 
            // columnaCorte
            // 
            columnaCorte.HeaderText = "Corte";
            columnaCorte.MinimumWidth = 6;
            columnaCorte.Name = "columnaCorte";
            columnaCorte.ReadOnly = true;
            // 
            // columnaStock
            // 
            columnaStock.HeaderText = "Stock en Kilos";
            columnaStock.MinimumWidth = 6;
            columnaStock.Name = "columnaStock";
            columnaStock.ReadOnly = true;
            // 
            // columnaPrecio
            // 
            columnaPrecio.HeaderText = "Precio x Kilo";
            columnaPrecio.MinimumWidth = 6;
            columnaPrecio.Name = "columnaPrecio";
            columnaPrecio.ReadOnly = true;
            // 
            // columnaDetalles
            // 
            columnaDetalles.HeaderText = "Detalles";
            columnaDetalles.MinimumWidth = 6;
            columnaDetalles.Name = "columnaDetalles";
            columnaDetalles.ReadOnly = true;
            // 
            // btnAddToCart
            // 
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddToCart.Location = new Point(5, 74);
            btnAddToCart.Margin = new Padding(3, 2, 3, 2);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(262, 32);
            btnAddToCart.TabIndex = 23;
            btnAddToCart.Text = "Añadir al Carrito";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click_1;
            // 
            // lblSelectQuantity
            // 
            lblSelectQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSelectQuantity.AutoSize = true;
            lblSelectQuantity.Font = new Font("Sitka Heading", 12.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSelectQuantity.Location = new Point(5, 46);
            lblSelectQuantity.Name = "lblSelectQuantity";
            lblSelectQuantity.Size = new Size(121, 24);
            lblSelectQuantity.TabIndex = 22;
            lblSelectQuantity.Text = "Cuantos kilos?";
            lblSelectQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudKilos
            // 
            nudKilos.BackColor = Color.FromArgb(192, 192, 255);
            nudKilos.Font = new Font("Sitka Subheading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            nudKilos.ForeColor = Color.Black;
            nudKilos.Location = new Point(133, 44);
            nudKilos.Margin = new Padding(3, 2, 3, 2);
            nudKilos.Name = "nudKilos";
            nudKilos.Size = new Size(47, 28);
            nudKilos.TabIndex = 21;
            // 
            // lblSelectedProduct
            // 
            lblSelectedProduct.AutoSize = true;
            lblSelectedProduct.Font = new Font("Sitka Heading", 12.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSelectedProduct.Location = new Point(8, 18);
            lblSelectedProduct.Name = "lblSelectedProduct";
            lblSelectedProduct.Size = new Size(105, 24);
            lblSelectedProduct.TabIndex = 20;
            lblSelectedProduct.Text = "Sin seleccion";
            // 
            // gbAddProductToCart
            // 
            gbAddProductToCart.BackColor = Color.FromArgb(192, 192, 255);
            gbAddProductToCart.BackgroundImageLayout = ImageLayout.Stretch;
            gbAddProductToCart.Controls.Add(lblSelectedProduct);
            gbAddProductToCart.Controls.Add(btnAddToCart);
            gbAddProductToCart.Controls.Add(nudKilos);
            gbAddProductToCart.Controls.Add(lblSelectQuantity);
            gbAddProductToCart.Font = new Font("Sitka Subheading", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbAddProductToCart.Location = new Point(14, 528);
            gbAddProductToCart.Margin = new Padding(3, 2, 3, 2);
            gbAddProductToCart.Name = "gbAddProductToCart";
            gbAddProductToCart.Padding = new Padding(3, 2, 3, 2);
            gbAddProductToCart.Size = new Size(273, 115);
            gbAddProductToCart.TabIndex = 24;
            gbAddProductToCart.TabStop = false;
            gbAddProductToCart.Text = "Agregar producto al carrito";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(192, 192, 255);
            lblTotal.Font = new Font("Sitka Subheading", 12.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTotal.Location = new Point(946, 525);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 24);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "Total: ";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.FromArgb(192, 192, 255);
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDeleteProduct.Location = new Point(946, 605);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(199, 38);
            btnDeleteProduct.TabIndex = 26;
            btnDeleteProduct.Text = "Eliminar Producto";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Sitka Subheading", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(948, 584);
            label1.Name = "label1";
            label1.Size = new Size(194, 18);
            label1.TabIndex = 27;
            label1.Text = "Seleccione un producto y presione";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Firebrick;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Sitka Small", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(240, 16);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(66, 27);
            btnFilter.TabIndex = 28;
            btnFilter.Text = "Filtrar";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += button1_Click;
            // 
            // btnCleanFilters
            // 
            btnCleanFilters.BackColor = Color.FromArgb(192, 192, 255);
            btnCleanFilters.Cursor = Cursors.Hand;
            btnCleanFilters.FlatStyle = FlatStyle.Flat;
            btnCleanFilters.Font = new Font("Sitka Small", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnCleanFilters.ForeColor = Color.Black;
            btnCleanFilters.Location = new Point(312, 16);
            btnCleanFilters.Name = "btnCleanFilters";
            btnCleanFilters.Size = new Size(97, 27);
            btnCleanFilters.TabIndex = 29;
            btnCleanFilters.Text = "Limpiar Filtros";
            btnCleanFilters.UseVisualStyleBackColor = false;
            btnCleanFilters.Click += button2_Click;
            // 
            // btnPayNow
            // 
            btnPayNow.BackColor = Color.FromArgb(192, 192, 255);
            btnPayNow.Cursor = Cursors.Hand;
            btnPayNow.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPayNow.ForeColor = Color.Black;
            btnPayNow.Location = new Point(401, 596);
            btnPayNow.Name = "btnPayNow";
            btnPayNow.Size = new Size(415, 47);
            btnPayNow.TabIndex = 30;
            btnPayNow.Text = "Finalizar Compra";
            btnPayNow.UseVisualStyleBackColor = false;
            btnPayNow.Click += btnPayNow_Click;
            // 
            // lblRemainingMoney
            // 
            lblRemainingMoney.AutoSize = true;
            lblRemainingMoney.BackColor = Color.FromArgb(192, 192, 255);
            lblRemainingMoney.Font = new Font("Sitka Small", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRemainingMoney.Location = new Point(946, 23);
            lblRemainingMoney.Name = "lblRemainingMoney";
            lblRemainingMoney.Size = new Size(144, 23);
            lblRemainingMoney.TabIndex = 31;
            lblRemainingMoney.Text = "Dinero restante: ";
            // 
            // lblErrorSelection
            // 
            lblErrorSelection.AutoSize = true;
            lblErrorSelection.BackColor = Color.Black;
            lblErrorSelection.Font = new Font("SimSun", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrorSelection.ForeColor = Color.Red;
            lblErrorSelection.Location = new Point(312, 528);
            lblErrorSelection.Name = "lblErrorSelection";
            lblErrorSelection.Size = new Size(442, 21);
            lblErrorSelection.TabIndex = 32;
            lblErrorSelection.Text = "Debe seleccionar producto y cantidad";
            lblErrorSelection.Visible = false;
            // 
            // lblErrorCart
            // 
            lblErrorCart.AutoSize = true;
            lblErrorCart.BackColor = Color.Black;
            lblErrorCart.Font = new Font("SimSun", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrorCart.ForeColor = Color.Red;
            lblErrorCart.Location = new Point(871, 563);
            lblErrorCart.Name = "lblErrorCart";
            lblErrorCart.Size = new Size(274, 21);
            lblErrorCart.TabIndex = 33;
            lblErrorCart.Text = "Seleccione un producto";
            lblErrorCart.Visible = false;
            // 
            // FormPurchaseScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.grass_frame_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 649);
            Controls.Add(lblErrorCart);
            Controls.Add(lblErrorSelection);
            Controls.Add(lblRemainingMoney);
            Controls.Add(btnPayNow);
            Controls.Add(btnCleanFilters);
            Controls.Add(btnFilter);
            Controls.Add(label1);
            Controls.Add(btnDeleteProduct);
            Controls.Add(lblTotal);
            Controls.Add(gbAddProductToCart);
            Controls.Add(dgvProductsGrid);
            Controls.Add(lvCart);
            Controls.Add(lblFilter);
            Controls.Add(txtbFilter);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(776, 355);
            Name = "FormPurchaseScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPurchaseScreen";
            ((System.ComponentModel.ISupportInitialize)dgvProductsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilos).EndInit();
            gbAddProductToCart.ResumeLayout(false);
            gbAddProductToCart.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtbFilter;
        private Label lblFilter;
        private ListView lvCart;
        private ColumnHeader cCutName;
        private ColumnHeader cPrice;
        private DataGridView dgvProductsGrid;
        private DataGridViewTextBoxColumn columnaCorte;
        private DataGridViewTextBoxColumn columnaStock;
        private DataGridViewTextBoxColumn columnaPrecio;
        private DataGridViewTextBoxColumn columnaDetalles;
        private Button btnAddToCart;
        private Label lblSelectQuantity;
        private NumericUpDown nudKilos;
        private Label lblSelectedProduct;
        private GroupBox gbAddProductToCart;
        private Label lblTotal;
        private Button btnDeleteProduct;
        private Label label1;
        private Button btnFilter;
        private Button btnCleanFilters;
        private Button btnPayNow;
        private Label lblRemainingMoney;
        private Label lblErrorSelection;
        private Label lblErrorCart;
    }
}