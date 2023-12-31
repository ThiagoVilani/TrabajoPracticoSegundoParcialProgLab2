﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class CarniceriaExtension
    {
        private static string connectionString = "Data Source=.;Initial Catalog=Carniceria; Integrated Security=True";
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command;

        static CarniceriaExtension()
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


        public static List<Receipt> ExtractReceiptsListFromDB(this Carniceria carniceria, SellersDBConnection sellerDBC, ClientsDBConnection clientDBC)
        {
            List<Receipt> receipts = new List<Receipt>();
            List<int> IDList = new List<int>();
            try
            {
                Open();
                command.Parameters.Clear();
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
                    receipts.Add(carniceria.ExtractReceiptFromDB(IDList[i], sellerDBC, clientDBC));
                }
                return receipts;
            }
            catch { throw; }
            finally { Close(); }
        }


        public static Receipt ExtractReceiptFromDB(this Carniceria carniceria,int id, SellersDBConnection sellerDBC, ClientsDBConnection clientDBC)
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



        public static List<Product> ExtractProductsFromDB(this Carniceria carniceria,bool isOutOfStock = false)
        {
            List<Product> products = new List<Product>();
            try
            {
                Open();
                command.Parameters.Clear();
                if (isOutOfStock)
                {
                    command.CommandText = "SELECT * FROM ProductsOutOfStock";
                }
                else
                {
                    command.CommandText = "SELECT * FROM Products";
                }
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
            catch { throw; }
            finally { Close(); }
        }


        public static void InsertReceiptToDB(this Carniceria carniceria,Receipt receipt)
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
                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO Receipts ([metodo pago],[ID vendedor],[ID cliente],productos,precios,subtotal,total)" +
                    $"VALUES (@PaymentMethod,@Seller,@Client,@Products,@Prices,@Subtotal,@Total)";
                command.Parameters.AddWithValue("@PaymentMethod", receipt.PaymentMethod);
                command.Parameters.AddWithValue("@Seller", receipt.Seller.ID);
                command.Parameters.AddWithValue("@Client", receipt.Client.ID);
                command.Parameters.AddWithValue("@Products", products);
                command.Parameters.AddWithValue("@Prices", prices);
                command.Parameters.AddWithValue("@Subtotal", receipt.SubTotal);
                command.Parameters.AddWithValue("@Total", receipt.Total);
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { Close(); }
        }


        public static void InsertProductToDB(this Carniceria carniceria,Product product, bool isOutOfStock = false)
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


        public static void UpdatePriceInDB(this Carniceria carniceria,int id, int newPrice)
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

        public static void UpdateStockInDB(this Carniceria carniceria,int id, int quantity, bool isSubstraction = false)
        {
            try
            {
                Open();
                command.Parameters.Clear();
                if (isSubstraction)
                {
                    command.CommandText = $"UPDATE Products SET [stock kilos] = [stock kilos] - @Quantity WHERE ID = @ID";
                }
                else
                {
                    command.CommandText = $"UPDATE Products SET [stock kilos] = [stock kilos] + @Quantity WHERE ID = @ID";
                }
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { Close(); }
        }


        public static void DeleteProductInDB(this Carniceria carniceria, int id, bool isOutOfStock = false)
        {
            string strCommand;
            if (isOutOfStock)
            {
                strCommand = $"DELETE FROM ProductsOutOfStock WHERE ID = @ID";
            }
            else
            {
                strCommand = $"DELETE FROM Products WHERE ID = @ID";
            }
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = strCommand;
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { Close(); }
        }
    }
}
