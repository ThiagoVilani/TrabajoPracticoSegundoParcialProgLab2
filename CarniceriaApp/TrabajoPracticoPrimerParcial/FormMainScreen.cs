using BibliotecaDeClases;
using System.Media;
using System.Net.PeerToPeer.Collaboration;

namespace TrabajoPracticoPrimerParcial
{
    public partial class FormMainScreen : Form
    {
        public Carniceria carniceria;
        public SellersDBConnection sellerDBC;
        public ClientsDBConnection clientDBC;

        public FormMainScreen(Carniceria carniceria)
        {
            InitializeComponent();
            this.clientDBC = new ClientsDBConnection();
            this.sellerDBC = new SellersDBConnection();  
            this.carniceria = carniceria;
        }


        /// <summary>
        /// Redirige al usuario al formulario de Ingreso 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                btnVendedor.BackColor = Color.Green;
                Thread.Sleep(1500);
                btnVendedor.BackColor = Color.AntiqueWhite;
            });
            Sounds.PlayClickSound3();
            if(carniceria.sellersDBC.ValidateCredentials(txtbMail.Text.ToLower(),txtbPassword.Text))
            {
                carniceria.CurrentSeller = carniceria.sellersDBC.ExtractUser(txtbMail.Text.ToLower(), txtbPassword.Text);
                FormHeladera frmHeladera = new FormHeladera(carniceria);
                frmHeladera.Show();
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
            Task.Run(() =>
            {
                btnCliente.BackColor = Color.Green;
                Thread.Sleep(1500);
                btnCliente.BackColor = Color.AntiqueWhite;
            });
            Sounds.PlayClickSound3();
            if(carniceria.clientsDBC.ValidateCredentials(txtbMail.Text.ToLower(),txtbPassword.Text))
            {
                carniceria.CurrentSeller = this.sellerDBC.ExtractUser(1001);   // Cambiar el ID
                carniceria.CurrentClient = this.clientDBC.ExtractUser(txtbMail.Text.ToLower(), txtbPassword.Text);
                if(carniceria.CurrentClient == null)
                {
                    carniceria.CurrentClient = this.clientDBC.ExtractUser(txtbMail.Text.ToLower(), txtbPassword.Text);
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
            txtbMail.Text = "mario@gmail.com";
            txtbPassword.Text = "mario123";
        }


        /// <summary>
        /// AutoCompletado para prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ACC_Click(object sender, EventArgs e)
        {
            Sounds.PlayClickSound3();
            txtbMail.Text = "alfred@gmail.com";
            txtbPassword.Text = "alfred123";
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