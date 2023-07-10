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
    public partial class FormSellerMenu : Form
    {
        Carniceria carniceria;

        public FormSellerMenu(Carniceria carniceria)
        {
            InitializeComponent();
            this.carniceria = carniceria;
        }

        private void btnRefrigerator_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                btnRefrigerator.BackColor = Color.Green;
                Thread.Sleep(1500);
                btnRefrigerator.BackColor = Color.AntiqueWhite;
            });
            FormHeladera heladera = new FormHeladera(carniceria);
            heladera.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                btnStock.BackColor = Color.Green;
                Thread.Sleep(1500);
                btnStock.BackColor = Color.AntiqueWhite;
            });
            FormAddStock formAddStock = new FormAddStock(carniceria);
            formAddStock.ShowDialog();
        }

        private void btnProductsToTxt_Click(object sender, EventArgs e)
        {
            Task.Run(() => 
            { 
                btnProductsToTxt.BackColor = Color.Green;
                Thread.Sleep(1500);
                btnProductsToTxt.BackColor = Color.AntiqueWhite;
            });
            Sounds.PlayClickSound2();
            ToFiles.SaveReceiptsList(carniceria.ReceiptList);
            ToFiles.XmlSerializeProducts(carniceria.Products);
            ToFiles.JsonSerializeProducts(carniceria.Products);
            MessageBox.Show(ToFiles.XmlDeserializeProducts());
            MessageBox.Show(ToFiles.JsonDeserializeProducts()); 
        }
    }
}
