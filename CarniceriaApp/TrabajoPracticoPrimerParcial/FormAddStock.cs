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
    public partial class FormAddStock : Form
    {
        Carniceria carniceria;
        int indexItemSelected = -1;
        public FormAddStock(Carniceria carniceria)
        {
            InitializeComponent();
            this.carniceria = carniceria;
            AddRows();
        }


        private void UpdateLVProducts()
        {
            lvProducts.Items.Clear();
            AddRows();
        }

        private void AddRows()
        {
            lvProducts.Columns[0].Width = lvProducts.ClientSize.Width;
            foreach (Product product in carniceria.ProductsOutOfStock)
            {
                ListViewItem item = new ListViewItem(product.Name);
                lvProducts.Items.Add(item);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound();
            foreach (ListViewItem item in lvProducts.SelectedItems)
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
                if (nudKilos.Value > 0)
                {
                    carniceria.ProductsOutOfStock[indexItemSelected].Stock = (double)nudKilos.Value;
                    carniceria.Products.Add(carniceria.ProductsOutOfStock[indexItemSelected]);
                    CarniceriaDBConnection.InsertProduct(carniceria.ProductsOutOfStock[indexItemSelected]);
                    CarniceriaDBConnection.DeleteProduct(carniceria.ProductsOutOfStock[indexItemSelected].ID,true);
                    carniceria.ProductsOutOfStock.RemoveAt(indexItemSelected);
                    indexItemSelected = -1;
                    UpdateLVProducts();
                    nudKilos.Value = 0;
                    lblError.Visible = false;
                }
            }
            else if (nudKilos.Value == 0)
            {
                lblError.Visible = true;
            }
        }
    }
}
