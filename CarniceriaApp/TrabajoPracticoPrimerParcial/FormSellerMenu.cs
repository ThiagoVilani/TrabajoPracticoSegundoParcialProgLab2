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
            FormHeladera heladera = new FormHeladera(carniceria);
            heladera.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormAddStock formAddStock = new FormAddStock(carniceria);
            formAddStock.ShowDialog();
        }
    }
}
