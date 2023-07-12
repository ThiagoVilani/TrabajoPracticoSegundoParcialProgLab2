namespace TrabajoPracticoPrimerParcial
{
    partial class FormHeladera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeladera));
            dgvProductsGrid = new DataGridView();
            columnaCorte = new DataGridViewTextBoxColumn();
            columnaStock = new DataGridViewTextBoxColumn();
            columnaPrecio = new DataGridViewTextBoxColumn();
            columnaDetalles = new DataGridViewTextBoxColumn();
            lblSelectedProduct = new Label();
            nudKilos = new NumericUpDown();
            lblSelectQuantity = new Label();
            btnSell = new Button();
            listClients = new ListView();
            cName = new ColumnHeader();
            cOrder = new ColumnHeader();
            lblChangeStock = new Label();
            lblChangePrice = new Label();
            lbNameNewCut = new Label();
            txtbChangeStock = new TextBox();
            txtbNameNewCut = new TextBox();
            btnChangeStock = new Button();
            btnAddCut = new Button();
            lvCart = new ListView();
            cCutName = new ColumnHeader();
            cPrice = new ColumnHeader();
            lblClientsList = new Label();
            lblCart = new Label();
            btnAddToCart = new Button();
            txtbChangePrice = new TextBox();
            btnChangePrice = new Button();
            gbAddNewCut = new GroupBox();
            txtbNewCutDetails = new TextBox();
            lblNewCutDetails = new Label();
            txtbNewCutStock = new TextBox();
            lblNewCutStock = new Label();
            txtbNewCutPrice = new TextBox();
            lblNewCutPrice = new Label();
            gbModifyProduct = new GroupBox();
            lblTotal = new Label();
            label1 = new Label();
            btnDeleteProduct = new Button();
            lblErrorDeleteProduct = new Label();
            btnBack = new Button();
            btnReceiptsList = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            lblErrorSelectedProduct = new Label();
            lblErrorQuantityEmpty = new Label();
            lblErrorEmptyCart = new Label();
            lblErrorNumber = new Label();
            lblErrorBack = new Label();
            btnDelProductFromFridge = new Button();
            lblClock = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilos).BeginInit();
            gbAddNewCut.SuspendLayout();
            gbModifyProduct.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            dgvProductsGrid.Location = new Point(5, 76);
            dgvProductsGrid.Name = "dgvProductsGrid";
            dgvProductsGrid.ReadOnly = true;
            dgvProductsGrid.RowHeadersWidth = 51;
            dgvProductsGrid.RowTemplate.Height = 29;
            dgvProductsGrid.Size = new Size(894, 479);
            dgvProductsGrid.TabIndex = 0;
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
            // lblSelectedProduct
            // 
            lblSelectedProduct.AutoSize = true;
            lblSelectedProduct.BackColor = Color.Transparent;
            lblSelectedProduct.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point);
            lblSelectedProduct.ForeColor = Color.White;
            lblSelectedProduct.Location = new Point(9, 557);
            lblSelectedProduct.Name = "lblSelectedProduct";
            lblSelectedProduct.Size = new Size(155, 39);
            lblSelectedProduct.TabIndex = 1;
            lblSelectedProduct.Text = "Sin seleccion";
            // 
            // nudKilos
            // 
            nudKilos.BackColor = Color.FromArgb(192, 192, 255);
            nudKilos.Location = new Point(590, 569);
            nudKilos.Name = "nudKilos";
            nudKilos.Size = new Size(54, 27);
            nudKilos.TabIndex = 2;
            // 
            // lblSelectQuantity
            // 
            lblSelectQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSelectQuantity.AutoSize = true;
            lblSelectQuantity.BackColor = Color.Transparent;
            lblSelectQuantity.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point);
            lblSelectQuantity.ForeColor = Color.White;
            lblSelectQuantity.Location = new Point(415, 564);
            lblSelectQuantity.Name = "lblSelectQuantity";
            lblSelectQuantity.Size = new Size(176, 39);
            lblSelectQuantity.TabIndex = 3;
            lblSelectQuantity.Text = "Cuantos kilos?";
            lblSelectQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSell
            // 
            btnSell.Anchor = AnchorStyles.Bottom;
            btnSell.BackColor = Color.FromArgb(0, 192, 0);
            btnSell.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point);
            btnSell.ForeColor = Color.Black;
            btnSell.Location = new Point(1079, 551);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(595, 65);
            btnSell.TabIndex = 4;
            btnSell.Text = "Finalizar Compra";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // listClients
            // 
            listClients.Anchor = AnchorStyles.None;
            listClients.BackColor = Color.LightCoral;
            listClients.Columns.AddRange(new ColumnHeader[] { cName, cOrder });
            listClients.FullRowSelect = true;
            listClients.Location = new Point(1390, 76);
            listClients.MultiSelect = false;
            listClients.Name = "listClients";
            listClients.Size = new Size(386, 460);
            listClients.TabIndex = 5;
            listClients.UseCompatibleStateImageBehavior = false;
            listClients.View = View.Details;
            // 
            // cName
            // 
            cName.Text = "Nombre";
            // 
            // cOrder
            // 
            cOrder.Text = "Pedido";
            // 
            // lblChangeStock
            // 
            lblChangeStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblChangeStock.AutoSize = true;
            lblChangeStock.BackColor = Color.Transparent;
            lblChangeStock.Font = new Font("Sitka Heading", 13F, FontStyle.Italic, GraphicsUnit.Point);
            lblChangeStock.ForeColor = Color.White;
            lblChangeStock.Location = new Point(16, 25);
            lblChangeStock.Name = "lblChangeStock";
            lblChangeStock.Size = new Size(141, 32);
            lblChangeStock.TabIndex = 7;
            lblChangeStock.Text = "Agregar Stock";
            // 
            // lblChangePrice
            // 
            lblChangePrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblChangePrice.AutoSize = true;
            lblChangePrice.BackColor = Color.Transparent;
            lblChangePrice.Font = new Font("Sitka Heading", 13F, FontStyle.Italic, GraphicsUnit.Point);
            lblChangePrice.ForeColor = Color.White;
            lblChangePrice.Location = new Point(16, 81);
            lblChangePrice.Name = "lblChangePrice";
            lblChangePrice.Size = new Size(152, 32);
            lblChangePrice.TabIndex = 8;
            lblChangePrice.Text = "Cambiar Precio";
            // 
            // lbNameNewCut
            // 
            lbNameNewCut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbNameNewCut.AutoSize = true;
            lbNameNewCut.Font = new Font("Sitka Heading", 13F, FontStyle.Italic, GraphicsUnit.Point);
            lbNameNewCut.ForeColor = Color.White;
            lbNameNewCut.Location = new Point(6, 28);
            lbNameNewCut.Name = "lbNameNewCut";
            lbNameNewCut.Size = new Size(86, 32);
            lbNameNewCut.TabIndex = 9;
            lbNameNewCut.Text = "Nombre";
            // 
            // txtbChangeStock
            // 
            txtbChangeStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbChangeStock.BackColor = Color.White;
            txtbChangeStock.Location = new Point(168, 31);
            txtbChangeStock.Name = "txtbChangeStock";
            txtbChangeStock.Size = new Size(180, 27);
            txtbChangeStock.TabIndex = 10;
            // 
            // txtbNameNewCut
            // 
            txtbNameNewCut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbNameNewCut.Location = new Point(98, 33);
            txtbNameNewCut.Name = "txtbNameNewCut";
            txtbNameNewCut.PlaceholderText = "Ingrese el corte";
            txtbNameNewCut.Size = new Size(180, 27);
            txtbNameNewCut.TabIndex = 12;
            // 
            // btnChangeStock
            // 
            btnChangeStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnChangeStock.BackColor = Color.LightCoral;
            btnChangeStock.ForeColor = Color.Black;
            btnChangeStock.Location = new Point(355, 31);
            btnChangeStock.Name = "btnChangeStock";
            btnChangeStock.Size = new Size(139, 31);
            btnChangeStock.TabIndex = 13;
            btnChangeStock.Text = "Agregar";
            btnChangeStock.UseVisualStyleBackColor = false;
            btnChangeStock.Click += btnChangeStock_Click;
            // 
            // btnAddCut
            // 
            btnAddCut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddCut.BackColor = Color.LightCoral;
            btnAddCut.Enabled = false;
            btnAddCut.ForeColor = Color.Black;
            btnAddCut.Location = new Point(601, 59);
            btnAddCut.Name = "btnAddCut";
            btnAddCut.Size = new Size(114, 33);
            btnAddCut.TabIndex = 15;
            btnAddCut.Text = "Agregar";
            btnAddCut.UseVisualStyleBackColor = false;
            btnAddCut.Click += btnAddCut_Click;
            // 
            // lvCart
            // 
            lvCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lvCart.BackColor = Color.LightCoral;
            lvCart.Columns.AddRange(new ColumnHeader[] { cCutName, cPrice });
            lvCart.Location = new Point(960, 76);
            lvCart.Name = "lvCart";
            lvCart.Size = new Size(386, 349);
            lvCart.TabIndex = 16;
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
            // lblClientsList
            // 
            lblClientsList.AutoSize = true;
            lblClientsList.BackColor = Color.Transparent;
            lblClientsList.Font = new Font("Sitka Heading", 16F, FontStyle.Italic, GraphicsUnit.Point);
            lblClientsList.ForeColor = Color.White;
            lblClientsList.Location = new Point(1390, 15);
            lblClientsList.Name = "lblClientsList";
            lblClientsList.Size = new Size(195, 39);
            lblClientsList.TabIndex = 17;
            lblClientsList.Text = "Lista de Clientes";
            // 
            // lblCart
            // 
            lblCart.Anchor = AnchorStyles.None;
            lblCart.AutoSize = true;
            lblCart.BackColor = Color.Transparent;
            lblCart.Font = new Font("Sitka Heading", 16F, FontStyle.Italic, GraphicsUnit.Point);
            lblCart.ForeColor = Color.White;
            lblCart.Location = new Point(960, 23);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(96, 39);
            lblCart.TabIndex = 18;
            lblCart.Text = "Carrito";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.LightCoral;
            btnAddToCart.BackgroundImageLayout = ImageLayout.None;
            btnAddToCart.Cursor = Cursors.Hand;
            btnAddToCart.FlatAppearance.MouseDownBackColor = Color.Red;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Sitka Heading", 13F, FontStyle.Italic, GraphicsUnit.Point);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.Location = new Point(678, 561);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(221, 55);
            btnAddToCart.TabIndex = 19;
            btnAddToCart.Text = "Añadir al Carrito";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // txtbChangePrice
            // 
            txtbChangePrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbChangePrice.BackColor = Color.White;
            txtbChangePrice.Location = new Point(166, 85);
            txtbChangePrice.Name = "txtbChangePrice";
            txtbChangePrice.Size = new Size(180, 27);
            txtbChangePrice.TabIndex = 11;
            // 
            // btnChangePrice
            // 
            btnChangePrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnChangePrice.BackColor = Color.LightCoral;
            btnChangePrice.ForeColor = Color.Black;
            btnChangePrice.Location = new Point(355, 83);
            btnChangePrice.Name = "btnChangePrice";
            btnChangePrice.Size = new Size(139, 33);
            btnChangePrice.TabIndex = 14;
            btnChangePrice.Text = "Cambiar";
            btnChangePrice.UseVisualStyleBackColor = false;
            btnChangePrice.Click += btnChangePrice_Click;
            // 
            // gbAddNewCut
            // 
            gbAddNewCut.BackColor = Color.Transparent;
            gbAddNewCut.Controls.Add(txtbNewCutDetails);
            gbAddNewCut.Controls.Add(lblNewCutDetails);
            gbAddNewCut.Controls.Add(txtbNewCutStock);
            gbAddNewCut.Controls.Add(lblNewCutStock);
            gbAddNewCut.Controls.Add(txtbNewCutPrice);
            gbAddNewCut.Controls.Add(lblNewCutPrice);
            gbAddNewCut.Controls.Add(lbNameNewCut);
            gbAddNewCut.Controls.Add(txtbNameNewCut);
            gbAddNewCut.Controls.Add(btnAddCut);
            gbAddNewCut.ForeColor = Color.White;
            gbAddNewCut.Location = new Point(810, 29);
            gbAddNewCut.Name = "gbAddNewCut";
            gbAddNewCut.Size = new Size(721, 144);
            gbAddNewCut.TabIndex = 20;
            gbAddNewCut.TabStop = false;
            gbAddNewCut.Text = "Agregar un nuevo corte";
            // 
            // txtbNewCutDetails
            // 
            txtbNewCutDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbNewCutDetails.Location = new Point(399, 83);
            txtbNewCutDetails.Name = "txtbNewCutDetails";
            txtbNewCutDetails.PlaceholderText = "Ingrese los detalles";
            txtbNewCutDetails.Size = new Size(180, 27);
            txtbNewCutDetails.TabIndex = 21;
            // 
            // lblNewCutDetails
            // 
            lblNewCutDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNewCutDetails.AutoSize = true;
            lblNewCutDetails.Font = new Font("Sitka Heading", 13F, FontStyle.Italic, GraphicsUnit.Point);
            lblNewCutDetails.ForeColor = Color.White;
            lblNewCutDetails.Location = new Point(309, 77);
            lblNewCutDetails.Name = "lblNewCutDetails";
            lblNewCutDetails.Size = new Size(85, 32);
            lblNewCutDetails.TabIndex = 20;
            lblNewCutDetails.Text = "Detalles";
            // 
            // txtbNewCutStock
            // 
            txtbNewCutStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbNewCutStock.Location = new Point(98, 84);
            txtbNewCutStock.Name = "txtbNewCutStock";
            txtbNewCutStock.PlaceholderText = "Ingrese el stock";
            txtbNewCutStock.Size = new Size(180, 27);
            txtbNewCutStock.TabIndex = 19;
            // 
            // lblNewCutStock
            // 
            lblNewCutStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNewCutStock.AutoSize = true;
            lblNewCutStock.Font = new Font("Sitka Heading", 13F, FontStyle.Italic, GraphicsUnit.Point);
            lblNewCutStock.ForeColor = Color.White;
            lblNewCutStock.Location = new Point(6, 77);
            lblNewCutStock.Name = "lblNewCutStock";
            lblNewCutStock.Size = new Size(63, 32);
            lblNewCutStock.TabIndex = 18;
            lblNewCutStock.Text = "Stock";
            // 
            // txtbNewCutPrice
            // 
            txtbNewCutPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbNewCutPrice.Location = new Point(399, 35);
            txtbNewCutPrice.Name = "txtbNewCutPrice";
            txtbNewCutPrice.PlaceholderText = "Ingrese el precio";
            txtbNewCutPrice.Size = new Size(180, 27);
            txtbNewCutPrice.TabIndex = 17;
            // 
            // lblNewCutPrice
            // 
            lblNewCutPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNewCutPrice.AutoSize = true;
            lblNewCutPrice.Font = new Font("Sitka Heading", 13F, FontStyle.Italic, GraphicsUnit.Point);
            lblNewCutPrice.ForeColor = Color.White;
            lblNewCutPrice.Location = new Point(309, 28);
            lblNewCutPrice.Name = "lblNewCutPrice";
            lblNewCutPrice.Size = new Size(70, 32);
            lblNewCutPrice.TabIndex = 16;
            lblNewCutPrice.Text = "Precio";
            // 
            // gbModifyProduct
            // 
            gbModifyProduct.BackColor = Color.Transparent;
            gbModifyProduct.Controls.Add(btnChangeStock);
            gbModifyProduct.Controls.Add(btnChangePrice);
            gbModifyProduct.Controls.Add(txtbChangePrice);
            gbModifyProduct.Controls.Add(txtbChangeStock);
            gbModifyProduct.Controls.Add(lblChangeStock);
            gbModifyProduct.Controls.Add(lblChangePrice);
            gbModifyProduct.ForeColor = Color.White;
            gbModifyProduct.Location = new Point(85, 29);
            gbModifyProduct.Margin = new Padding(3, 4, 3, 4);
            gbModifyProduct.Name = "gbModifyProduct";
            gbModifyProduct.Padding = new Padding(3, 4, 3, 4);
            gbModifyProduct.Size = new Size(513, 144);
            gbModifyProduct.TabIndex = 22;
            gbModifyProduct.TabStop = false;
            gbModifyProduct.Text = "Modificar Producto";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(997, -47);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(63, 24);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Total:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Subheading", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1039, 463);
            label1.Name = "label1";
            label1.Size = new Size(246, 21);
            label1.TabIndex = 29;
            label1.Text = "Seleccione un producto y presione";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.None;
            btnDeleteProduct.BackColor = Color.LightCoral;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDeleteProduct.Location = new Point(1055, 491);
            btnDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(193, 47);
            btnDeleteProduct.TabIndex = 28;
            btnDeleteProduct.Text = "Eliminar Producto";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // lblErrorDeleteProduct
            // 
            lblErrorDeleteProduct.Anchor = AnchorStyles.None;
            lblErrorDeleteProduct.AutoSize = true;
            lblErrorDeleteProduct.BackColor = Color.Transparent;
            lblErrorDeleteProduct.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorDeleteProduct.ForeColor = Color.Red;
            lblErrorDeleteProduct.Location = new Point(994, 429);
            lblErrorDeleteProduct.Name = "lblErrorDeleteProduct";
            lblErrorDeleteProduct.Size = new Size(322, 24);
            lblErrorDeleteProduct.TabIndex = 30;
            lblErrorDeleteProduct.Text = "Producto NO seleccionado";
            lblErrorDeleteProduct.Visible = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.BackgroundImage = Properties.Resources._858_8583460_back_button_orange;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Location = new Point(9, 980);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 65);
            btnBack.TabIndex = 31;
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // btnReceiptsList
            // 
            btnReceiptsList.BackColor = Color.FromArgb(192, 192, 255);
            btnReceiptsList.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnReceiptsList.Location = new Point(1528, 980);
            btnReceiptsList.Margin = new Padding(3, 4, 3, 4);
            btnReceiptsList.Name = "btnReceiptsList";
            btnReceiptsList.Size = new Size(242, 65);
            btnReceiptsList.TabIndex = 32;
            btnReceiptsList.Text = "Historial de Recibos";
            btnReceiptsList.UseVisualStyleBackColor = false;
            btnReceiptsList.Click += btnReceiptsList_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(gbModifyProduct);
            groupBox1.Controls.Add(gbAddNewCut);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(119, 724);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1574, 204);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modificar stock";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 16F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 31);
            label2.Name = "label2";
            label2.Size = new Size(116, 39);
            label2.TabIndex = 35;
            label2.Text = "Heladera";
            // 
            // lblErrorSelectedProduct
            // 
            lblErrorSelectedProduct.AutoSize = true;
            lblErrorSelectedProduct.BackColor = Color.Transparent;
            lblErrorSelectedProduct.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorSelectedProduct.ForeColor = Color.Red;
            lblErrorSelectedProduct.Location = new Point(486, 619);
            lblErrorSelectedProduct.Name = "lblErrorSelectedProduct";
            lblErrorSelectedProduct.Size = new Size(426, 24);
            lblErrorSelectedProduct.TabIndex = 36;
            lblErrorSelectedProduct.Text = "Ningun producto fue seleccionado";
            lblErrorSelectedProduct.Visible = false;
            // 
            // lblErrorQuantityEmpty
            // 
            lblErrorQuantityEmpty.AutoSize = true;
            lblErrorQuantityEmpty.BackColor = Color.Transparent;
            lblErrorQuantityEmpty.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorQuantityEmpty.ForeColor = Color.Red;
            lblErrorQuantityEmpty.Location = new Point(473, 619);
            lblErrorQuantityEmpty.Name = "lblErrorQuantityEmpty";
            lblErrorQuantityEmpty.Size = new Size(439, 24);
            lblErrorQuantityEmpty.TabIndex = 37;
            lblErrorQuantityEmpty.Text = "Indique una cantidad mayor a cero";
            lblErrorQuantityEmpty.Visible = false;
            // 
            // lblErrorEmptyCart
            // 
            lblErrorEmptyCart.Anchor = AnchorStyles.None;
            lblErrorEmptyCart.AutoSize = true;
            lblErrorEmptyCart.BackColor = Color.Transparent;
            lblErrorEmptyCart.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorEmptyCart.ForeColor = Color.Red;
            lblErrorEmptyCart.Location = new Point(1197, 619);
            lblErrorEmptyCart.Name = "lblErrorEmptyCart";
            lblErrorEmptyCart.Size = new Size(283, 24);
            lblErrorEmptyCart.TabIndex = 38;
            lblErrorEmptyCart.Text = "El carrito esta vacio";
            lblErrorEmptyCart.Visible = false;
            // 
            // lblErrorNumber
            // 
            lblErrorNumber.AutoSize = true;
            lblErrorNumber.BackColor = Color.Transparent;
            lblErrorNumber.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorNumber.ForeColor = Color.Red;
            lblErrorNumber.Location = new Point(232, 932);
            lblErrorNumber.Name = "lblErrorNumber";
            lblErrorNumber.Size = new Size(738, 24);
            lblErrorNumber.TabIndex = 39;
            lblErrorNumber.Text = "Debe seleccionar un corte e ingresar un numero mayor a 0";
            lblErrorNumber.Visible = false;
            // 
            // lblErrorBack
            // 
            lblErrorBack.AutoSize = true;
            lblErrorBack.BackColor = Color.Transparent;
            lblErrorBack.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorBack.ForeColor = Color.Red;
            lblErrorBack.Location = new Point(146, 1001);
            lblErrorBack.Name = "lblErrorBack";
            lblErrorBack.Size = new Size(465, 24);
            lblErrorBack.TabIndex = 40;
            lblErrorBack.Text = "El carrito todavia tiene productos!";
            lblErrorBack.Visible = false;
            // 
            // btnDelProductFromFridge
            // 
            btnDelProductFromFridge.BackColor = Color.LightCoral;
            btnDelProductFromFridge.BackgroundImageLayout = ImageLayout.None;
            btnDelProductFromFridge.Cursor = Cursors.Hand;
            btnDelProductFromFridge.FlatAppearance.MouseDownBackColor = Color.Red;
            btnDelProductFromFridge.FlatStyle = FlatStyle.Flat;
            btnDelProductFromFridge.Font = new Font("Sitka Heading", 13F, FontStyle.Italic, GraphicsUnit.Point);
            btnDelProductFromFridge.ForeColor = Color.Black;
            btnDelProductFromFridge.Location = new Point(678, 663);
            btnDelProductFromFridge.Name = "btnDelProductFromFridge";
            btnDelProductFromFridge.Size = new Size(221, 55);
            btnDelProductFromFridge.TabIndex = 41;
            btnDelProductFromFridge.Text = "Eliminar Producto";
            btnDelProductFromFridge.UseVisualStyleBackColor = false;
            btnDelProductFromFridge.Click += btnDelProductFromFridge_Click;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.BackColor = Color.Transparent;
            lblClock.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblClock.ForeColor = Color.White;
            lblClock.Location = new Point(398, 15);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(94, 38);
            lblClock.TabIndex = 42;
            lblClock.Text = "Reloj";
            // 
            // FormHeladera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Sin_título_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1784, 1055);
            Controls.Add(lblClock);
            Controls.Add(btnDelProductFromFridge);
            Controls.Add(lblErrorBack);
            Controls.Add(lblErrorNumber);
            Controls.Add(lblErrorEmptyCart);
            Controls.Add(lblErrorQuantityEmpty);
            Controls.Add(lblErrorSelectedProduct);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(lblClientsList);
            Controls.Add(lblErrorDeleteProduct);
            Controls.Add(label1);
            Controls.Add(btnReceiptsList);
            Controls.Add(btnDeleteProduct);
            Controls.Add(lblTotal);
            Controls.Add(btnBack);
            Controls.Add(lblCart);
            Controls.Add(lvCart);
            Controls.Add(btnAddToCart);
            Controls.Add(listClients);
            Controls.Add(dgvProductsGrid);
            Controls.Add(lblSelectedProduct);
            Controls.Add(btnSell);
            Controls.Add(nudKilos);
            Controls.Add(lblSelectQuantity);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 498);
            Name = "FormHeladera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Heladera";
            Load += FormHeladera_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilos).EndInit();
            gbAddNewCut.ResumeLayout(false);
            gbAddNewCut.PerformLayout();
            gbModifyProduct.ResumeLayout(false);
            gbModifyProduct.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductsGrid;
        private Label lblSelectedProduct;
        private NumericUpDown nudKilos;
        private Label lblSelectQuantity;
        private Button btnSell;
        private ListView listClients;
        private ColumnHeader cName;
        private ColumnHeader cOrder;
        private DataGridViewTextBoxColumn columnaCorte;
        private DataGridViewTextBoxColumn columnaStock;
        private DataGridViewTextBoxColumn columnaPrecio;
        private DataGridViewTextBoxColumn columnaDetalles;
        private Label lblChangeStock;
        private Label lblChangePrice;
        private Label lbNameNewCut;
        private TextBox txtbChangeStock;
        private TextBox txtbNameNewCut;
        private Button btnChangeStock;
        private Button btnAddCut;
        private ListView lvCart;
        private Label lblClientsList;
        private Label lblCart;
        private Button btnAddToCart;
        private ColumnHeader cCutName;
        private ColumnHeader cPrice;
        private TextBox txtbChangePrice;
        private Button btnChangePrice;
        private GroupBox gbAddNewCut;
        private TextBox txtbNewCutStock;
        private Label lblNewCutStock;
        private TextBox txtbNewCutPrice;
        private Label lblNewCutPrice;
        private TextBox txtbNewCutDetails;
        private Label lblNewCutDetails;
        private GroupBox gbModifyProduct;
        private Label lblTotal;
        private Label label1;
        private Button btnDeleteProduct;
        private Label lblErrorDeleteProduct;
        private Button btnBack;
        private Button btnReceiptsList;
        private GroupBox groupBox1;
        private Label label2;
        private Label lblErrorSelectedProduct;
        private Label lblErrorQuantityEmpty;
        private Label lblErrorEmptyCart;
        private Label lblErrorNumber;
        private Label lblErrorBack;
        private Button btnDelProductFromFridge;
        private Label lblClock;
    }
}