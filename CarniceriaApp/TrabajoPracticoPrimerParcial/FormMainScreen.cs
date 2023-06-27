using BibliotecaDeClases;
using System.Media;
using System.Net.PeerToPeer.Collaboration;

namespace TrabajoPracticoPrimerParcial
{
    public partial class FormMainScreen : Form
    {
        public Carniceria carniceria;


        public FormMainScreen(Carniceria carniceria)
        {
            InitializeComponent();
            this.carniceria = carniceria;//Harcodeo la cantidad de clientes incial
        }


        /// <summary>
        /// Redirige al usuario al formulario de Ingreso 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            if(DBConnection.Coincidence(txtbMail.Text.ToLower(),txtbPassword.Text,"Sellers"))
            {
                carniceria.CurrentSeller = DBConnection.ExtractSeller(txtbMail.Text.ToLower(), txtbPassword.Text);
                FormSellerMenu menu = new FormSellerMenu(this.carniceria);
                menu.Show();
                this.Hide();
            }
            else
            {
                txtbMail.Text = "";
                txtbPassword.Text = "";
                lblIncorrect.Visible = true;
            }
        }

        /// <summary>
        /// Redirige al usuario al formulario de ingreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCliente_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            if(DBConnection.Coincidence(txtbMail.Text.ToLower(),txtbPassword.Text,"Clients")||DBConnection.Coincidence(txtbMail.Text.ToLower(), txtbPassword.Text, "ClientsHistory"))
            {
                carniceria.CurrentSeller = DBConnection.ExtractSeller(2);
                carniceria.CurrentClient = DBConnection.ExtractClient(txtbMail.Text.ToLower(), txtbPassword.Text);
                if(carniceria.CurrentClient == null)
                {
                    carniceria.CurrentClient = DBConnection.ExtractClient(txtbMail.Text.ToLower(), txtbPassword.Text,"ClientsHistory");
                }
                FormLoginUser formLoginUser = new FormLoginUser(carniceria);
                formLoginUser.Show();
                this.Hide();
            }
            else
            {
                txtbMail.Text = "";
                txtbPassword.Text = "";
                lblIncorrect.Visible = true;
            }
        }

        /// <summary>
        /// AutoCompletado para prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ACS_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            txtbMail.Text = "pipo@gmail.com";
            txtbPassword.Text = "pipo123";
        }


        /// <summary>
        /// AutoCompletado para prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ACC_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            txtbMail.Text = "mario@gmail.com";
            txtbPassword.Text = "mario123";
        }


        /// <summary>
        /// Hace visible la contraseña que se ingresa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMostrarPass_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            pbMostrarPass.Visible = false;
            pbOcultarPass.Visible = true;
            txtbPassword.PasswordChar = '\0';
        }

        /// <summary>
        /// Hace invisible la contraseña que se ingresa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbOcultarPass_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            pbOcultarPass.Visible = false;
            pbMostrarPass.Visible = true;
            txtbPassword.PasswordChar = '*';
        }
    }
}