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
    public partial class FormReceiptHistory : Form
    {
        Carniceria carniceria;
        public FormReceiptHistory(Carniceria carniceria)
        {
            InitializeComponent();
            this.carniceria = carniceria;
            ConfigureListView();
            AddRowProducts(CarniceriaDBConnection.ExtractReceiptsList(carniceria.sellersDBC, carniceria.clientsDBC));
        }
        private void ConfigureListView()
        {
            lvReceiptHistory.Columns[0].Width = lvReceiptHistory.ClientSize.Width / 4;
            lvReceiptHistory.Columns[1].Width = lvReceiptHistory.ClientSize.Width / 4;
            lvReceiptHistory.Columns[2].Width = lvReceiptHistory.ClientSize.Width / 4;
            lvReceiptHistory.Columns[3].Width = lvReceiptHistory.ClientSize.Width / 4;
        }



        private void AddRowProducts(List<Receipt> receiptsList)
        {
            if (receiptsList != null)
            {
                foreach (Receipt receipt in receiptsList)
                {
                    ListViewItem item = new ListViewItem(receipt.GetID().ToString());
                    item.SubItems.Add(receipt.Seller.Name);
                    item.SubItems.Add(receipt.Client.Name);
                    item.SubItems.Add(receipt.Total.ToString());
                    lvReceiptHistory.Items.Add(item);
                }
            }
        }

        private void lvReceiptHistory_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = lvReceiptHistory.SelectedIndices[0];
            FormReceipt receipt = new FormReceipt(CarniceriaDBConnection.ExtractReceipt(int.Parse(lvReceiptHistory.Items[rowIndex].SubItems[0].Text),carniceria.sellersDBC,carniceria.clientsDBC),carniceria);
            receipt.ShowDialog();
        }
    }
}
