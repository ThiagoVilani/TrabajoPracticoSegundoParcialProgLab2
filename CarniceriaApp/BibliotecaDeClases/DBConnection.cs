using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Runtime.CompilerServices;

namespace BibliotecaDeClases
{
    public static class DBConnection
    {
        private static string connectionString = "Data Source=.;Initial Catalog=Carniceria; Integrated Security=True";
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command;
        static DBConnection()
        {
            connection.ConnectionString = connectionString;
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }


        public static void Open()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public static void Close()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }


        public static void InsertProduct(Product product, bool isOutOfStock = false)
        {
            try
            {
                Open();
                command.Parameters.Clear();
                if (isOutOfStock)
                {
                    command.CommandText = $"INSERT INTO ProductsOutOfStock (ID,nombre,[precio kilo],[stock kilos], detalles) " +
                                          $"VALUES (@ID, @Name, @Price,@Stock,@Details)";
                }
                else
                {
                    command.CommandText = $"INSERT INTO Products (ID,nombre,[precio kilo],[stock kilos], detalles) " +
                                          $"VALUES (@ID, @Name, @Price,@Stock,@Details)";
                }
                command.Parameters.AddWithValue("@ID", product.ID);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                command.Parameters.AddWithValue("@Details", product.Details);
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { Close(); }
        }


        public static void meterproducto()
        {
            List<Product> lista = new List<Product>();
            lista.Add(new Product("Asado", 1230, 12, "Es un corte largo, plano y sin hueso del vientre"));
            lista.Add(new Product("Chorizo", 1530, 10, "Los chorizos tendrán una consistencia firme y compacta al tacto, serán de forma cilíndrica, más o menos regular, pudiendo tener diversas presentaciones"));
            lista.Add(new Product("Molleja", 1110, 11, "Se compone de una parte alargada, la garganta (no comestible), y de una parte redonda y muy sabrosa: la nuez"));
            lista.Add(new Product("Bondiola", 3230, 5, "Es tierna y jugosa gracias a la grasa que posee entre sus músculos"));
            lista.Add(new Product("Roast beef", 1630, 22, "Es un corte con abundante grasa en su veta, bien marmoleado"));
            lista.Add(new Product("paleta", 1260, 12, "Se obtiene del omoplato y el humero"));
            lista.Add(new Product("Nalga", 1000, 15, "Es la pieza más voluminosa y magra, y no tiene hueso"));
            lista.Add(new Product("Matabre", 1500, 10, "Es un corte largo, plano y sin hueso del vientre de la vaca"));
            lista.Add(new Product("Falda", 800, 12, "Combina carne magra, betas de grasa y fibra, tierno, jugosos y delicioso sabor, sin llegar a ser un corte duro."));
            foreach (Product p in lista)
            {
                InsertProduct(p);
            }
        }

        public static void meterclientes(ClientsDBConnection clientDBC)
        {
            List<Client> lista = new List<Client>();
            lista.Add(new Client("pepe", 12000, "1kg de asado", "pepe@gmail.com", "pepe123"));
            lista.Add(new Client("maria", 22000, "2kg de molleja", "maria@gmail.com", "maria123"));
            lista.Add(new Client("Jhon", 10000, "2kg de chorizo", "jhon@gmail.com", "jhon123"));
            lista.Add(new Client("alfred", 12000, "3kg de morcilla", "alfred@gmail.com", "alfred123"));
            lista.Add(new Client("godofredo", 5000, "4kg de roast beef", "godofredo@gmail.com", "godofredo123"));
            lista.Add(new Client("pancracio", 15000, "1kg de lengua", "pancracio@gmail.com", "pancracio123"));
            foreach (Client client in lista)
            {
                clientDBC.InsertUser(client);
            }
        }


        public static void metervendedores(SellersDBConnection sellerDBC)
        {
            List<Seller> lista = new List<Seller>();
            lista.Add(new Seller("mario", "mario@gmail.com", "mario123", 400));
            lista.Add(new Seller("Luciana", "luciana@gmail.com", "luciana123", 236));
            lista.Add(new Seller("DonBosco", "donbosco@gmail.com", "Donbosco123", 125));
            foreach (Seller seller in lista)
            {
                sellerDBC.InsertUser(seller);
            }
        }
    }
}
