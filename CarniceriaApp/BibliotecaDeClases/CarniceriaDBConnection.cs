using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class CarniceriaDBConnection
    {
        private static string connectionString = "Data Source=.;Initial Catalog=Carniceria; Integrated Security=True";
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command;

        static CarniceriaDBConnection()
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
            if(connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }


        public static List<Receipt> ExtractReceiptsList(SellersDBConnection sellerDBC, ClientsDBConnection clientDBC)
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
                for (int i = 0; i < IDList.Count(); i++)
                {
                    receipts.Add(ExtractReceipt(IDList[i],sellerDBC,clientDBC));
                }
                return receipts;
            }
            catch { throw; }
            finally { Close(); }
        }


        public static Receipt ExtractReceipt(int id, SellersDBConnection sellerDBC, ClientsDBConnection clientDBC)
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
                        int sellerID = (int)dataReader["ID vendedor"];
                        int clientID = (int)dataReader["ID cliente"];
                        dataReader.Close();
                        seller = sellerDBC.ExtractUser(sellerID);
                        client = clientDBC.ExtractUser(clientID);
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
                    return new Receipt(productsList, subtotal, total, seller, client, paymentMethod, id);
                }
            }
            catch { throw; }
            finally { Close(); }
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
            catch { throw; }
            finally { Close(); }
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
                Close();
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
            finally { Close(); }
        }


        public static void InsertProduct(Product product, string listType = "Products")
        {
            try
            {
                Open();
                command.CommandText = $"INSERT INTO {listType} (ID,nombre,[precio kilo],[stock kilos], detalles) " +
                                      $"VALUES ('{product.ID}','{product.Name}','{(int)product.Price}','{(int)product.Stock}','{product.Details}')";

                command.ExecuteNonQuery();
            }
            catch {  throw; }
            finally { Close(); }
        }


        public static void UpdatePrice(int id, int newPrice)
        {
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"UPDATE Products SET [precio kilo] = @NewPrice WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@NewPrice", newPrice);
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { Close(); }
        }

        public static void UpdateStock(int id, int quantity, string mathOperator)
        {
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"UPDATE Products SET [stock kilos] = [stock kilos] {mathOperator} @Quantity WHERE ID = @ID";
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { Close(); }
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
            finally { Close(); }
        }
    }
}
