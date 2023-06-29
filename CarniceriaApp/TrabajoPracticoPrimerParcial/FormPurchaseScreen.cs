using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoPrimerParcial
{
    public partial class FormPurchaseScreen : Form
    {
        private System.Windows.Forms.Timer timer;
        int indexItemSelected;
        Carniceria carniceria;
        public FormPurchaseScreen(Carniceria carniceria)
        {
            InitializeComponent();
            this.carniceria = carniceria;
            AddRowOfProducts(DBConnection.ExtractProducts());
//            AddRowOfProducts(carniceria.Products);
            ConfigureListView();
            indexItemSelected = -1;
            lblRemainingMoney.Text = $"Dinero restante: {carniceria.CurrentClient.CantidadDinero}";

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }


        ////////////////////////EVENTOS\\\\\\\\\\\\\\\\\\\\\\
        /// <summary>
        /// Cada 1 segundo pregunta si hubo algun cambio en el carrito y actualiza ciertos elementos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (carniceria.ChangeQuantityProducts())
            {
                UpdateLVCart();
                UpdateProductsGrid(carniceria.Products);
                lblRemainingMoney.Text = $"Dinero restante: {carniceria.CurrentClient.CantidadDinero - carniceria.CurrentSeller.CalculateSubTotal(carniceria.Cart)}";
                if (carniceria.CurrentClient.CantidadDinero - carniceria.CurrentSeller.CalculateSubTotal(carniceria.Cart) < 0)
                {
                    lblRemainingMoney.Text = "Dinero restante: 0";
                }
            }
        }

        /// <summary>
        /// Añade al carrito la cantidad solicitada del producto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            int quantity = (int)nudKilos.Value;
            int prodcutIndex = -1;

            if (dgvProductsGrid.Rows.Count > 0)
            {
                prodcutIndex = dgvProductsGrid.CurrentRow.Index;
                if (lblSelectedProduct.Text != "Sin seleccion")
                {
                    lblErrorSelection.Visible = false;
                    carniceria.CurrentSeller.AddToCart(prodcutIndex, quantity, carniceria.Products, carniceria.Cart);
                    UpdateProductsGrid(carniceria.Products);
                }
                else
                {
                    lblErrorSelection.Visible = true;
                }
            }
            else
            {
                lblErrorSelection.Visible = true;
            }
            nudKilos.Value = 0;
            lblSelectedProduct.Text = "Sin seleccion";
        }



        /// <summary>
        /// Retorna la fila a color blanca en caso de que haya sido pintada de rojo para su destaque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            UpdateProductsGrid(carniceria.Products);
            //foreach (DataGridViewRow row in dgvProductsGrid.Rows)
            //{
            //    row.DefaultCellStyle.BackColor = Color.White;
            //}
        }

        /// <summary>
        /// Elimina el producto del carrito y lo devuelve a su stock original
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
                catch (System.ArgumentOutOfRangeException)
                {

                }
            }
            if (indexItemSelected != -1)
            {
                lblErrorCart.Visible = false;
                int pcount = carniceria.Products.Count();
                int count = 0;
                bool flagBreak = false;

                while (!flagBreak && count < pcount)
                {
                    if (carniceria.Products[count].Name == carniceria.Cart[indexItemSelected].Name)
                    {
                        carniceria.Products[count].Stock++;
                        DBConnection.UpdateStock(carniceria.Products[count].ID, 1, "+");
                    }
                    else
                    {
                        for (int i = 0; i < carniceria.ProductsOutOfStock.Count(); i++)
                        {
                            if (carniceria.ProductsOutOfStock[i].Name == carniceria.Cart[indexItemSelected].Name)
                            {
                                carniceria.ProductsOutOfStock[i].Stock++;
                                DBConnection.UpdateStock(carniceria.ProductsOutOfStock[i].ID, 1, "+");

                                carniceria.Products.Add(carniceria.ProductsOutOfStock[i]);
                                DBConnection.InsertProduct(carniceria.ProductsOutOfStock[i]);

                                DBConnection.DeleteProduct(carniceria.ProductsOutOfStock[i].ID, "ProductsOutOfStock");
                                carniceria.ProductsOutOfStock.RemoveAt(i);
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
                lblErrorCart.Visible = true;
            }
            lblTotal.Text = $"Total:  {carniceria.CurrentSeller.CalculateSubTotal(carniceria.Cart)}";
        }

        /// <summary>
        /// Busca las filas que contengan un nombre que coincida con el input del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> filteredList = new List<Product>();
            Sounds.PlayClickSound3();
            if (txtbFilter.Text != "")
            {
                foreach (DataGridViewRow row in dgvProductsGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ((cell.Value.ToString().ToUpper()).IndexOf(txtbFilter.Text.ToUpper()) == 0)
                        {
                            filteredList.Add(carniceria.Products[row.Index]);
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
                UpdateProductsGrid(filteredList);
            }
            else
            {
                Update();
            }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            if (carniceria.Cart.Count > 0)
            {
                FormPaymentMethods PMScreen = new FormPaymentMethods(carniceria, true);
                PMScreen.Show();
            }
        }
        private void dgvProductsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sounds.PlayClickSound3();
            lblSelectedProduct.Text = carniceria.Products[dgvProductsGrid.CurrentRow.Index].Name;
            nudKilos.Value = 0;
            nudKilos.Maximum = Convert.ToDecimal(carniceria.Products[dgvProductsGrid.CurrentRow.Index].Stock);

        }



        ////////////////////////FUNCIONES\\\\\\\\\\\\\\\\\\\\\\
        private void IsOutOfStock()
        {
            for (int i = 0; i < carniceria.Products.Count; i++)
            {
                if (carniceria.Products[i].Stock == 0)
                {
                    //carniceria.NewProductOutOfStock(i);
                    carniceria.olli(i);

                    carniceria.Products.RemoveAt(i);
                    UpdateProductsGrid(carniceria.Products);
                    break;
                }
            }
        }

        private void UpdateProductsGrid(List<Product> productsList)
        {
            dgvProductsGrid.Rows.Clear();
            AddRowOfProducts(productsList);
            IsOutOfStock();
        }

        private void UpdateLVCart()
        {
            lvCart.Items.Clear();
            AddRowOfProductsToCart();
        }

        public void AddRowOfProducts(List<Product> productsList)
        {
            dgvProductsGrid.AllowUserToAddRows = false;
            for (int i = 0; i < productsList.Count(); i++)
            {
                int n = dgvProductsGrid.Rows.Add();
                dgvProductsGrid.Rows[n].Cells[0].Value = productsList[i].Name;
                dgvProductsGrid.Rows[n].Cells[2].Value = productsList[i].Price;
                dgvProductsGrid.Rows[n].Cells[1].Value = productsList[i].Stock;
                dgvProductsGrid.Rows[n].Cells[3].Value = productsList[i].Details;
            }
        }

        private void ConfigureListView()
        {
            lvCart.Columns[0].Width = lvCart.ClientSize.Width / 2;
            lvCart.Columns[1].Width = lvCart.ClientSize.Width / 2;
        }

        private void AddRowOfProductsToCart()
        {
            foreach (Product product in carniceria.Cart)
            {
                ListViewItem item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString());
                lvCart.Items.Add(item);
            }
        }

        private void Update()
        {
            lvCart.Items.Clear();
            dgvProductsGrid.Rows.Clear();
            AddRowOfProducts(carniceria.Products);
            ConfigureListView();
            AddRowOfProductsToCart();
            lblSelectedProduct.Text = "Sin seleccion";
            lblTotal.Text = $"Total: {carniceria.CurrentSeller.CalculateSubTotal(carniceria.Cart).ToString()}";
            indexItemSelected = -1;
            if (carniceria.Cart.Count > 0)
            {
                lblTotal.Text = "Total: 0";
            }
        }
    }
}
