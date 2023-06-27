using BibliotecaDeClases;

namespace TrabajoPracticoPrimerParcial
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainScreen(new Carniceria()));

            //Seller seller = new Seller("thiago", "thiago@mail.com", "algo");
            //Client client = new Client("cliente", 13000, "algo rico", "mail.com", "algodificil");
            //MessageBox.Show($"{seller.ShowInfo()}\n\n\n{client.ShowInfo()}");
        }
    }
}