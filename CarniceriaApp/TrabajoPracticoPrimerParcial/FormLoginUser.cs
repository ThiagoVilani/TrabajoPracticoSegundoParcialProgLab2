using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TrabajoPracticoPrimerParcial
{
    public partial class FormLoginUser : Form
    {
        Carniceria carniceria;
        SellersDBConnection sellerDBC;
        ClientsDBConnection clientDBC;
        public FormLoginUser(Carniceria carniceria)
        {
            InitializeComponent();
            this.carniceria = carniceria;
            this.sellerDBC = sellerDBC;
            this.clientDBC = clientDBC;
            ConfPosOfElements();
        }


        ////////////////////////EVENTOS\\\\\\\\\\\\\\\\\\\\\\
        
        /// <summary>
        /// Compurbea que el dato ingresado sea correcto y deriva al usuario a la pantalla de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInputMoney_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            if (!(string.IsNullOrEmpty(txtbInputMoney.Text)))
            {
                bool b = int.TryParse(txtbInputMoney.Text, out int amount);
                if (b && amount > 0)
                {
                    carniceria.CurrentClient.CantidadDinero = amount;
                    FormPurchaseScreen purchaseScreen = new FormPurchaseScreen(carniceria);
                    purchaseScreen.Show();
                    this.Hide();
                }
                else
                {
                    txtbInputMoney.Text = string.Empty;
                    txtbInputMoney.PlaceholderText = "Ingrese un numero mayor a cero";
                    lblIncorrectInput.Visible = true;
                }
            }
        }


        ////////////////////////FUNCIONES\\\\\\\\\\\\\\\\\\\\\\
        /// <summary>
        /// Configura la posicion de los elementos en la pàntalla
        /// </summary>
        private void ConfPosOfElements()
        {
            lblInputMoney.Left = (this.ClientSize.Width - lblInputMoney.Width) / 2;
            lblInputMoney.Top = ((this.ClientSize.Height - lblInputMoney.Height) * 25) / 100;

            txtbInputMoney.Left = (this.ClientSize.Width - txtbInputMoney.Width) / 2;
            txtbInputMoney.Top = ((this.ClientSize.Height - txtbInputMoney.Height) * 45) / 100;

            lblIncorrectInput.Left = (this.ClientSize.Width - lblIncorrectInput.Width) / 2;
            lblIncorrectInput.Top = ((this.ClientSize.Height - lblIncorrectInput.Height) * 50) / 100;

            btnInputMoney.Left = (this.ClientSize.Width - btnInputMoney.Width) / 2;
            btnInputMoney.Top = ((this.ClientSize.Height - btnInputMoney.Height) * 56) / 100;
        }
    }
}
