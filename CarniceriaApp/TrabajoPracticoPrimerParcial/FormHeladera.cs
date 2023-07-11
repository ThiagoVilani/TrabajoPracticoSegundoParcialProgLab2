using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace TrabajoPracticoPrimerParcial
{

    /// <summary>
    /// Representa a la heladera de la carniceria, se ven todos los cortes y se puede modificarlos
    /// </summary>
    public partial class FormHeladera : Form
    {
        //          Atributos y Propiedades
        Carniceria carniceria;
        SellersDBConnection sellerDBC;
        ClientsDBConnection clientDBC;
        int indexItemSelected;
        private System.Windows.Forms.Timer timer;



        //          Constructor

        /// <summary>
        /// Agrega los productos a la tabla de productos, configura los elementos de del form e inicia unn reloj para actualizaciones
        /// </summary>
        /// <param name="carniceria">Recibe el objeto carniceria</param>
        public FormHeladera(Carniceria carniceria)
        {
            InitializeComponent();

            this.carniceria = carniceria;
            this.sellerDBC = new SellersDBConnection();
            this.clientDBC = new ClientsDBConnection();
            AddRow(carniceria.Products);
            ConfigureListView();
            AddRowClients();
            if (carniceria.Clients.Count > 0)
            {
                carniceria.CurrentClient = carniceria.Clients.Peek();
            }
            indexItemSelected = -1;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            carniceria.CurrentSeller.StockIncreasedPOOS += carniceria.StockExpansionPOOS;
            carniceria.CurrentSeller.StockIncreased += carniceria.StockExpansion;
        }



        ///////////////// EVENTOS \\\\\\\\\\\\\\\\\


        /// <summary>
        /// Se encarga de actualizar la vista del carrito cuando pasa un segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (carniceria.ChangeQuantityProducts())
            {

                UpdateLVCart();
                UpdateProductsGrid(carniceria.Products);
            }
            if (carniceria.ChangeQuantityClients())
            {
                UpdateLVClients();
            }


            if (carniceria.ChangesInStock())
            {
                UpdateProductsGrid(carniceria.Products);

            }
            if (EnableBtnAddNewCut())
            {
                Task.Run(() =>
                {
                    Invoke((MethodInvoker)delegate
                    {
                        btnAddCut.Enabled = true;
                        btnAddCut.BackColor = Color.Green;
                    });
                });
            }
        }

        /// <summary>
        /// Se encarga de tomar los datos del objeto seleccionado en la tabla de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sounds.PlayClickSound3();
            try
            { lblSelectedProduct.Text = carniceria.Products[dgvProductsGrid.CurrentRow.Index].Name; }
            catch { }

            nudKilos.Value = 0;

            try
            { nudKilos.Maximum = Convert.ToDecimal(carniceria.Products[dgvProductsGrid.CurrentRow.Index].Stock); }
            catch { }
        }

        /// <summary>
        /// Se encarga de sacar al cliente recien atendido, actualiza, deriba al form de metodos de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSell_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            if (carniceria.Clients.Count() > 0 && carniceria.Cart.Count() > 0)
            {
                lblErrorEmptyCart.Visible = false;
                UpdateAll();
                FormPaymentMethods formPaymentMethods = new FormPaymentMethods(carniceria, false);
                formPaymentMethods.Show();
            }
            else if (carniceria.Cart.Count() == 0)
            {
                lblErrorEmptyCart.Visible = true;
            }
        }


        /// <summary>
        /// Agrega la cantidad solicitada del elemento seleccionado al carrito y actuliza el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            int quantity = (int)nudKilos.Value;
            int prodcutIndex = dgvProductsGrid.CurrentRow.Index;
            if (lblSelectedProduct.Text != "Sin seleccion" && quantity != 0)
            {
                Task.Run(() =>
                {
                    btnAddToCart.BackColor = Color.Green;
                    Thread.Sleep(1500);
                    btnAddToCart.BackColor = Color.LightCoral;
                });
                carniceria.CurrentSeller.AddToCart(prodcutIndex, quantity, carniceria.Products, carniceria.Cart);
                lblTotal.Text = $"Total:  {carniceria.CurrentSeller.CalculateSubTotal(carniceria.Cart)}";
                UpdateAll();
                lblErrorSelectedProduct.Visible = false;
            }
            else
            {
                if (lblSelectedProduct.Text == "Sin seleccion")
                {
                    lblErrorQuantityEmpty.Visible = false;
                    lblErrorSelectedProduct.Visible = true;
                }
                else if (quantity == 0)
                {
                    lblErrorSelectedProduct.Visible = false;
                    lblErrorQuantityEmpty.Visible = true;
                }
            }
        }

        /// <summary>
        /// Llama a otro metodo para añadir stock de un producto y actualiza el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeStock_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            if (lblSelectedProduct.Text != "Sin seleccion")
            {
                Task.Run(() =>
                {
                    btnChangeStock.BackColor = Color.Green;
                    Thread.Sleep(1000);
                    btnChangeStock.BackColor = Color.LightCoral;
                });
                lblErrorNumber.Visible = false;
                AddStock();
            }
            else
            {
                lblErrorNumber.Visible = true;
            }
            UpdateAll();
            txtbChangeStock.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            if (lblSelectedProduct.Text != "Sin seleccion")
            {
                Task.Run(() =>
                {
                    btnChangePrice.BackColor = Color.Green;
                    Thread.Sleep(1000);
                    btnChangePrice.BackColor = Color.LightCoral;
                });
                lblErrorNumber.Visible = false;
                ChangePrice();
                UpdateAll();
                txtbChangePrice.Text = "";
            }
            else
            {
                lblErrorNumber.Visible = true;
            }

        }

        /// <summary>
        /// Llama al metodo que agrega un nuevo corte a la carniceria y actualiza el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCut_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            AddNewCut();
            txtbNewCutDetails.Text = "";
            txtbNewCutPrice.Text = "";
            txtbNewCutStock.Text = "";
            txtbNameNewCut.Text = "";
            btnAddCut.Enabled = false;
            UpdateAll();
        }

        /// <summary>
        /// Elimina el producto seleccionado del carrito y lo devuelve al stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            foreach (ListViewItem item in lvCart.SelectedItems)
            {
                try
                {
                    indexItemSelected = item.Index;
                }
                catch (System.ArgumentOutOfRangeException) { }
            }
            if (indexItemSelected != -1)
            {
                Task.Run(() =>
                {
                    btnDeleteProduct.BackColor = Color.Green;
                    Thread.Sleep(1000);
                    btnDeleteProduct.BackColor = Color.LightCoral;
                });
                int pcount = carniceria.Products.Count();
                int count = 0;
                bool flagBreak = false;

                lblErrorDeleteProduct.Visible = false;
                while (!flagBreak && count < pcount)
                {
                    if (carniceria.Products[count].Name == carniceria.Cart[indexItemSelected].Name)
                    {
                        carniceria.CurrentSeller.AlertStockIncrease(count);
                    }
                    else
                    {
                        for (int i = 0; i < carniceria.ProductsOutOfStock.Count(); i++)
                        {
                            if (carniceria.ProductsOutOfStock[i].Name == carniceria.Cart[indexItemSelected].Name)
                            {
                                carniceria.CurrentSeller.AlertStockIncreasePOOS(i);
                                flagBreak = true;
                                break;
                            }
                        }
                    }
                    count++;
                }
                carniceria.Cart.RemoveAt(indexItemSelected);
                indexItemSelected = -1;
            }
            else
            {
                lblErrorDeleteProduct.Visible = true;
            }
            lblTotal.Text = $"Total:  {carniceria.CurrentSeller.CalculateSubTotal(carniceria.Cart)}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound();
            if (carniceria.Cart.Count == 0)
            {
                lblErrorBack.Visible = false;
                FormSellerMenu fsm = new FormSellerMenu(this.carniceria);
                fsm.Show();
                this.Close();
            }
            else
            {
                lblErrorBack.Visible = true;
            }
        }

        private void btnReceiptsList_Click(object sender, EventArgs e)
        {
            FormReceiptHistory frh = new FormReceiptHistory(carniceria);
            frh.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAddStock formAddStock = new FormAddStock(carniceria);
            formAddStock.ShowDialog();
        }


        private void btnDelProductFromFridge_Click(object sender, EventArgs e)
        {

        }

        /////////////////// FUNCIONES \\\\\\\\\\\\\\\\\\\\
        /// <summary>
        /// Agrega una nueva fila a la tabla de productos, poniendo cada dato en la columna adecuada
        /// </summary>
        /// <param name="productsList">Recibe la lista de los producto de la carniceria</param>
        private void UpdateProductsGrid(List<Product> productsList)
        {
            dgvProductsGrid.Rows.Clear();
            AddRow(productsList);
            IsOutOfStock();
        }

        /// <summary>
        /// Actualiza la listview del carrito
        /// </summary>
        private void UpdateLVCart()
        {
            lvCart.Items.Clear();
            AddRowProducts();
        }

        /// <summary>
        /// Agrega una nueva fila a la DataGridView de los productos, estableciendo el valor de cada columna
        /// </summary>
        /// <param name="productsList"></param>
        public void AddRow(List<Product> productsList)
        {
            dgvProductsGrid.AllowUserToAddRows = false;
            for (int i = 0; i < productsList.Count(); i++)
            {
                try
                {
                    int n = dgvProductsGrid.Rows.Add();
                    dgvProductsGrid.Rows[n].Cells[0].Value = productsList[i].Name;
                    dgvProductsGrid.Rows[n].Cells[2].Value = productsList[i].Price;
                    dgvProductsGrid.Rows[n].Cells[1].Value = productsList[i].Stock;
                    dgvProductsGrid.Rows[n].Cells[3].Value = productsList[i].Details;
                }
                catch (Exception ex)
                {
                    //throw new CargarDataGridViewException("Error cargando el DataGridView");
                    MessageBox.Show(ex.Message);
                }
            }
        }


        /// <summary>
        /// Configura las tablas que muestran a los clientes y la de los productos en el carrito
        /// </summary>
        private void ConfigureListView()
        {
            listClients.Columns[0].Width = listClients.ClientSize.Width / 2;
            listClients.Columns[1].Width = listClients.ClientSize.Width / 2;

            lvCart.Columns[0].Width = lvCart.ClientSize.Width / 2;
            lvCart.Columns[1].Width = lvCart.ClientSize.Width / 2;
        }
        /// <summary>
        /// Agrega una fila mas a la tabla de clientes colocando los datos en la columna correspondiente
        /// </summary>
        private void AddRowClients()
        {
            foreach (Client client in carniceria.Clients)
            {
                ListViewItem item = new ListViewItem(client.Name);
                item.SubItems.Add(client.Pedido);
                listClients.Items.Add(item);
            }
        }

        /// <summary>
        /// Se encarga de actualizar todos los elementos del form
        /// </summary>
        private void UpdateAll()
        {
            //if (carniceria.Clients.Count > 0)
            //{
            //    carniceria.CurrentClient = carniceria.Clients.Peek();
            //}
            UpdateLVClients();
            listClients.Items.Clear();
            UpdateProductsGrid(carniceria.Products);
            ConfigureListView();
            AddRowClients();
            lblSelectedProduct.Text = "Sin seleccion";
            nudKilos.Value = 0;
        }

        /// <summary>
        /// Actualiza la listView de los clientes
        /// </summary>
        private void UpdateLVClients()
        {
            listClients.Items.Clear();
            AddRowClients();
        }

        /// <summary>
        /// Agrega una fila a la tabla de los productos en el carrito
        /// </summary>
        private void AddRowProducts()
        {
            foreach (Product product in carniceria.Cart)
            {
                ListViewItem item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString());
                lvCart.Items.Add(item);
            }
        }

        /// <summary>
        /// Agrega la cantidad de stock solicitada al producto indicado
        /// </summary>
        private void AddStock()
        {
            if (int.TryParse(txtbChangeStock.Text, out int stock))
            {
                if (stock > 0)
                {
                    carniceria.CurrentSeller.AddStock(carniceria.Products, dgvProductsGrid.CurrentRow.Index, stock);
                }
                else
                {
                    lblErrorNumber.Visible = true;
                }
            }
            else
            {
                lblErrorNumber.Visible = true;
            }
        }

        /// <summary>
        /// Cambia el preico al producto seleccionado
        /// </summary>
        private void ChangePrice()
        {
            if (int.TryParse(txtbChangePrice.Text, out int newPrice))
            {
                if (newPrice > 0)
                {
                    carniceria.CurrentSeller.ChangePrice(carniceria.Products, dgvProductsGrid.CurrentRow.Index, newPrice);
                    //carniceria.Products[dgvProductsGrid.CurrentRow.Index].Price = newPrice;
                }
                else
                {
                    lblErrorNumber.Visible = true;
                }
            }
            else
            {
                lblErrorNumber.Visible = true;
            }
        }

        private bool EnableBtnAddNewCut()
        {
            if (!string.IsNullOrEmpty(txtbNameNewCut.Text) && txtbNameNewCut.Text.All(c => char.IsLetter(c))
                && !string.IsNullOrEmpty(txtbNewCutDetails.Text) && txtbNewCutDetails.Text.All(c => char.IsLetter(c))
                && !string.IsNullOrEmpty(txtbNewCutPrice.Text) && txtbNewCutPrice.Text.All(c => char.IsDigit(c))
                && !string.IsNullOrEmpty(txtbNewCutStock.Text) && txtbNewCutStock.Text.All(c => char.IsDigit(c)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        /// <summary>
        /// Agrega un nuevo producto a la lista tabla de lista de productos y llama al metodo de la carniceria para agregarlo a su stock 
        /// </summary>
        private void AddNewCut()
        {
            string name = txtbNameNewCut.Text;
            string details = txtbNewCutDetails.Text;
            double price = double.Parse(txtbNewCutPrice.Text);
            double stock = double.Parse(txtbNewCutStock.Text);
            if (price > 0 && stock > 0)
            {
                Product product = new Product(name, price, stock, details);
                CarniceriaDBConnection.InsertProduct(product);
                carniceria.Products.Add(product);
                UpdateAll();
            }
        }

        /// <summary>
        /// Comprueba que producto esta sin stock y lo vuelve invisble ante el usuario
        /// </summary>
        private async void IsOutOfStock()
        {
            for (int i = 0; i < carniceria.Products.Count; i++)
            {
                if (carniceria.Products[i].Stock == 0)
                {
                    carniceria.NewProductOutOfStock(i);
                    carniceria.Products.RemoveAt(i);
                    UpdateProductsGrid(carniceria.Products);
                    break;
                }
            }
        }
    }
}
