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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TrabajoPracticoPrimerParcial
{
    public partial class FormPaymentMethods : Form
    {
        bool isClient;
        Carniceria carniceria;
        SellersDBConnection sellerDBC;
        ClientsDBConnection clientDBC;

        public FormPaymentMethods(Carniceria carniceria, bool isClient)
        {
            InitializeComponent();
            ConfPosOfElements();
            this.carniceria = carniceria;
            this.isClient = isClient;
            this.sellerDBC = sellerDBC;
            this.clientDBC = clientDBC;
        }


        ////////////////////////EVENTOS\\\\\\\\\\\\\\\\\\\\\\
        /// <summary>
        /// Comprueba que opcion se esta seleccionando y llama a la funcion que verifica
        /// si el cliente puede pagar la compra, en caso positivo es derivado a la facturacion.
        /// En caso negativo se le avisa que no puede concretarse la compra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReady_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            foreach (Control control in gbPaymentMethods.Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                {
                    bool isPossible = carniceria.CurrentSeller.SaleIsPossible(radioButton.Text,carniceria.Cart,carniceria.CurrentClient,carniceria.Clients, isClient);
                    if (isPossible)
                    {
                        if (!isClient)
                        {
                            carniceria.Clients.Dequeue();
                        }
                        Receipt receipt = new Receipt(carniceria.Cart,
                                                        carniceria.CurrentSeller.CalculateSubTotal(carniceria.Cart),
                                                        carniceria.CurrentSeller.CalculateTotal(radioButton.Text,carniceria.Cart),
                                                        carniceria.CurrentSeller,
                                                        carniceria.CurrentClient,radioButton.Text);
                        CarniceriaDBConnection.InsertReceipt(receipt);
                        carniceria.ReceiptList.Add(receipt);
                        FormReceipt formreceipt = new FormReceipt(receipt,carniceria);
                        formreceipt.Show();
                        this.Close();
                    }
                    else
                    {
                        InvertScreen();
                    }
                }
            }
        }


        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            this.Close();
        }


        ////////////////////////FUNCIONES\\\\\\\\\\\\\\\\\\\\\\
        /// <summary>
        /// Cuando el formulario cambia su tamaño, se llama a una funcion que configura 
        /// la ubicacion de los elementos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPaymentMethods_Resize(object sender, EventArgs e)
        {
            ConfPosOfElements();
        }

        /// <summary>
        /// Configura la ubicacion de cada elemento del formulario
        /// </summary>
        private void ConfPosOfElements()
        {
            lblPaymentMethod.Left = (this.gbPaymentMethods.Width - lblPaymentMethod.Width) / 2;
            lblPaymentMethod.Top = ((this.gbPaymentMethods.Height - lblPaymentMethod.Height) * 10) / 100;

            rbtnDebit.Left = ((this.gbPaymentMethods.Width - rbtnDebit.Width) * 20) / 100;
            rbtnDebit.Top = ((this.gbPaymentMethods.Height - rbtnDebit.Height) * 30) / 100;

            rbtnCredit.Left = ((this.gbPaymentMethods.Width - rbtnCredit.Width) * 20) / 100;
            rbtnCredit.Top = ((this.gbPaymentMethods.Height - rbtnCredit.Height) * 80) / 100;

            rbtnCash.Left = ((this.gbPaymentMethods.Width - rbtnCash.Width) * 70) / 100;
            rbtnCash.Top = ((this.gbPaymentMethods.Height - rbtnCash.Height) * 30) / 100;

            rbtnMP.Left = ((this.gbPaymentMethods.Width - rbtnMP.Width) * 70) / 100;
            rbtnMP.Top = ((this.gbPaymentMethods.Height - rbtnMP.Height) * 80) / 100;

            btnReady.Left = (this.gbPaymentMethods.Width - btnReady.Width) / 2;
            btnReady.Top = ((this.gbPaymentMethods.Height - btnReady.Height) * 95) / 100;
        }

        /// <summary>
        /// Oculta ciertos elementos y hace visibles otros, para crear una sensacion de cambio de pantalla
        /// </summary>
        private void InvertScreen()
        {
            lblPaymentMethod.Visible = false;
            rbtnCash.Visible = false;
            rbtnCredit.Visible = false;
            rbtnDebit.Visible = false;
            rbtnMP.Visible = false;
            btnReady.Visible = false;
            lblNoMoney.Visible = true;
            btnBack.Visible = true;
        }
    }
}
