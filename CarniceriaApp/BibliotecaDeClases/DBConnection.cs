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
        public static void meterproducto()
        {
            List<Product> lista = new List<Product>();
            lista.Add(new Product("Asado", 1230, 12, "es asado"));
            lista.Add(new Product("Chorizo", 1530, 10, "es chorizo"));
            lista.Add(new Product("Molleja", 1110, 11, "es molleja"));
            lista.Add(new Product("bondiola", 3230, 5, "es bondiola"));
            lista.Add(new Product("roast beed", 1630, 22, "es rb"));
            foreach (Product p in lista)
            {
                DBConnection.InsertProduct(p);
            }
        }
    
        public static void Open()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public static Client ExtractClient(int id, string listType="Clients")
        {
            Client client = null;
            try
            {
                Open();
                command.CommandText = $"SELECT * FROM {listType} WHERE ID = {id}";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        client = new Client(dataReader["nombre"].ToString(),
                                            Convert.ToSingle(dataReader["cantidad dinero"]),
                                            dataReader["pedido"].ToString(),
                                            dataReader["email"].ToString(),
                                            dataReader["contraseña"].ToString(),
                                            (int)dataReader["ID"]);
                    }
                }
                return client;
            }
            catch { throw; }
            finally { connection.Close(); }
        }        


        public static Seller ExtractSeller(int id)
        {
            Seller seller = null;
            try
            {
                Open();
                command.CommandText = $"SELECT * FROM Sellers WHERE ID = {id}";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        seller = new Seller(dataReader["nombre"].ToString(),
                            dataReader["email"].ToString(),
                            dataReader["contraseña"].ToString(),
                            (int)dataReader["cantidad ventas"], 
                            (int)dataReader["ID"]);
                    }
                }
                return seller;
            }
            catch  { throw; }
            finally { connection.Close(); }
        }


        public static List<Receipt> ExtractReceiptsList()
        {
            List<Receipt> receipts = new List<Receipt>();
            List<int> IDList = new List<int>();
            try
            {
                Open();
                command.CommandText = "SELECT * FROM Receipts";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        IDList.Add((int)dataReader["ID"]);
                    }
                }
                for(int i = 0; i<IDList.Count(); i++)
                {
                    receipts.Add(ExtractReceipt(IDList[i]));
                }
                return receipts;
            }
            catch { throw; }
            finally { connection.Close(); }
        }

        public static Receipt ExtractReceipt(int id)
        {
            string paymentMethod = null;
            Seller seller = null;
            Client client = null;
            double subtotal = -1;
            double total = -1;

            try
            {
                List<Product> productsList = new List<Product>();
                command.Parameters.Clear();
                Open();
                command.CommandText = "SELECT * FROM Receipts WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        paymentMethod = dataReader["metodo pago"].ToString();
                        string[] productNameList = dataReader["productos"].ToString().Split(",");
                        subtotal = Convert.ToDouble(dataReader["subtotal"]);
                        total = Convert.ToDouble(dataReader["total"]);
                        int sellerID= (int)dataReader["ID vendedor"];
                        int clientID = (int)dataReader["ID cliente"];
                        dataReader.Close();
                        seller = ExtractSeller(sellerID);
                        client = ExtractClient(clientID,"ClientsHistory");
                        Open();
                        foreach (string productName in productNameList)
                        {
                            command.CommandText = $"SELECT * FROM Products WHERE nombre = '{productName}'";
                            using (SqlDataReader dataReader2 = command.ExecuteReader())
                            {
                                while (dataReader2.Read())
                                {
                                    productsList.Add(new Product(productName,
                                                                 Convert.ToDouble(dataReader2["precio kilo"]),
                                                                 Convert.ToDouble(dataReader2["stock kilos"]),
                                                                 dataReader2["detalles"].ToString(),
                                                                 (int)dataReader2["ID"]));
                                }
                            }
                        }
                        break;
                    }
                    return new Receipt(productsList,subtotal,total,seller,client,paymentMethod,id);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Client> ExtractClients()
        {
            List<Client> clients = new List<Client>();
            try
            {
                Open();
                command.CommandText = $"SELECT * FROM Clients";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        clients.Add(new Client(dataReader["nombre"].ToString(),
                                               Convert.ToSingle(dataReader["cantidad dinero"]), 
                                               dataReader["pedido"].ToString(),
                                               dataReader["email"].ToString(),
                                               dataReader["contraseña"].ToString(),
                                               (int)dataReader["ID"]));
                    }
                }
                return clients;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Product ExtractLastProduct(string listType = "Products")
        {
            Product product = null;
            try
            {
                Open();
                command.CommandText = $"SELECT TOP 1 * FROM {listType} ORDER BY ID DESC";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        product = new Product(dataReader["nombre"].ToString(),
                                                Convert.ToDouble(dataReader["precio kilo"]),
                                                Convert.ToDouble(dataReader["stock kilos"]),
                                                dataReader["detalles"].ToString(),
                                                (int)dataReader["ID"]);
                    }
                }
                return product;
            }
            catch {  throw; }
            finally { connection.Close(); }
        }

        public static List<Product> ExtractProducts(string listType = "Products")
        {
            List<Product> products = new List<Product>();
            try
            {
                Open();
                command.CommandText = $"SELECT * FROM {listType}";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        products.Add(new Product(dataReader["nombre"].ToString(),
                                                Convert.ToDouble(dataReader["precio kilo"]),
                                                Convert.ToDouble(dataReader["stock kilos"]),
                                                dataReader["detalles"].ToString(),
                                                (int)dataReader["ID"]));
                    }
                }
                return products;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Seller ExtractSeller(string email, string password)
        {
            Seller seller = null;
            try
            {
                Open();
                command.CommandText = $"SELECT * FROM Sellers WHERE email = '{email}'";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string name = dataReader["nombre"].ToString();
                        int cantidadVentas = (int)dataReader["cantidad ventas"];
                        seller = new Seller(name, email, password, cantidadVentas, (int)dataReader["ID"]);
                    }
                }
                return seller;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

        }

        public static Client ExtractClient(string email, string password, string listType = "Clients")
        {
            Client client = null;
            try
            {
                Open();
                command.CommandText = $"SELECT * FROM {listType} WHERE email = '{email}' and contraseña = '{password}'";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string name = dataReader["nombre"].ToString();
                        int cantidadDinero = (int)dataReader["cantidad dinero"];
                        string pedido = dataReader["pedido"].ToString();
                        client = new Client(name, cantidadDinero, pedido, email, password, (int)dataReader["ID"]);
                    }
                }
                return client;
            }
            catch 
            {
                throw;
            }
            finally
            {
                connection.Close();
            }     
        }

        public static bool Coincidence(string email, string password, string rol)
        {
            bool result = false;
            try
            {
                Open();
                command.CommandText = $"SELECT * FROM {rol} WHERE email = '{email}'";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        dataReader.Close();
                        command.CommandText = $"SELECT * FROM {rol} WHERE contraseña = '{password}'";
                        using(SqlDataReader dataReader2 = command.ExecuteReader())
                        {
                            while (dataReader2.Read())
                            {
                                result = true; break;
                            }
                        }
                        break;
                    }
                }
                return result;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        

        public static void InsertReceipt(Receipt receipt)
        {
            string prices = "";
            string products = "";
            foreach (Product product in receipt.ProductsList)
            {
                prices += $"{(int)product.Price},";
                products += $"{product.Name},";
            }
            try
            {
                Open();
                command.CommandText = $"INSERT INTO Receipts ([metodo pago],[ID vendedor],[ID cliente],productos,precios,subtotal,total)" +
                    $"VALUES ('{receipt.PaymentMethod}','{receipt.Seller.ID}','{receipt.Client.ID}','{products}','{prices}','{receipt.SubTotal}','{(int)receipt.Total}')";
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }


        public static void InsertHistoricalClient(Client client)
        {
            try
            {
                Open();
                command.CommandText = $"INSERT INTO ClientsHistory (ID,nombre,email,contraseña,[cantidad dinero],pedido) " +
                    $"VALUES ('{client.ID}','{client.Name}','{client.Mail}','{client.Password}','{(int)client.CantidadDinero}','{client.Pedido}')";
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }

        public static void InsertProduct(Product product, string listType="Products")
        {
            try
            {
                Open();
                command.CommandText = $"INSERT INTO {listType} (ID,nombre,[precio kilo],[stock kilos], detalles) " +
                                      $"VALUES ('{product.ID}','{product.Name}','{(int)product.Price}','{(int)product.Stock}','{product.Details}')";
                
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public static void UpdateClientMoney(int clientID, int total)
        {
            try
            {
                Open();
                command.CommandText = $"UPDATE Clients SET [cantidad dinero] = [cantidad dinero] - {total} WHERE ID = {clientID}";
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }

        public static void UpdateSales(int id, int quatityOfSales)
        {
            try
            {
                Open();
                command.CommandText = $"UPDATE Sellers SET [cantidad ventas] = {quatityOfSales} WHERE ID = {id}";
                command.ExecuteNonQuery();
            }
            catch { throw; }    
            finally { connection.Close(); } 
        }

        public static void UpdatePrice(int id, int newPrice)
        {
            try
            {
                Open();
                command.CommandText = $"UPDATE Products SET [precio kilo] = {newPrice} WHERE ID = {id}";
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }

        public static void UpdateStock(int id, int quantity, string mathOperator)
        {
            try
            {
                Open();
                command.CommandText = $"UPDATE Products SET [stock kilos] = [stock kilos] {mathOperator} {quantity} WHERE ID = {id}";
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }

        
        public static void DeleteProduct(int id, string listType = "Products")
        {
            try
            {
                Open();
                command.CommandText = $"DELETE FROM {listType} WHERE ID = {id}";
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }

        public static void DeleteClient(Client client)
        {
            InsertHistoricalClient(client);
            try
            {
                Open();
                command.CommandText = $"DELETE FROM Clients WHERE ID = {client.ID}";
                command.ExecuteNonQuery();
            }
            catch { throw; }    
            finally { connection.Close(); }
        }
    }
}
