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
    public partial class FormReceipt : Form
    {
        Carniceria carniceria;
        private Receipt receipt;
        public FormReceipt(Receipt receipt,Carniceria carniceria)
        {
            InitializeComponent();
            this.carniceria = carniceria;
            this.receipt = receipt;
            ConfigureListView();
            AddRowProducts(this.receipt.ProductsList);
        }

        ////////////////////////EVENTOS\\\\\\\\\\\\\\\\\\\\\\\\\
        private void btnReady_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            carniceria.Cart.Clear();
            this.Close();
        }

        ////////////////////////FUNCIONES\\\\\\\\\\\\\\\\\\\\\\\\\
        private void ConfigureListView()
        {
            lvTicket.Columns[0].Width = lvTicket.ClientSize.Width / 2;
            lvTicket.Columns[1].Width = lvTicket.ClientSize.Width / 2;

            lblSubtotal.Text += $" {this.receipt.SubTotal}";
            if (this.receipt.PaymentMethod == "Credito")
            {
                lblSurcharges.Text += " 5%";
            }
            lblTotal.Text += $" {this.receipt.Total}";
        }

        private void AddRowProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString());
                lvTicket.Items.Add(item);
            }
        }
    }
}
