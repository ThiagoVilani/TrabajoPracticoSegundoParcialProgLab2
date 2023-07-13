using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class SellersDBConnection : IConnection<Seller>
    {
        private static string connectionString = "Data Source=.;Initial Catalog=Carniceria; Integrated Security=True";
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command;

        public SellersDBConnection()
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


        public void InsertUser(Seller seller)
        {
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO Sellers (ID,nombre,email,contraseña,[cantidad ventas]) " +
                                      $"VALUES (@ID,@Name,@Mail,@Password,@QuantityOfSales)";
                command.Parameters.AddWithValue("@ID", seller.ID);
                command.Parameters.AddWithValue("@Name", seller.Name);
                command.Parameters.AddWithValue("@Mail", seller.Mail);
                command.Parameters.AddWithValue("@Password", seller.Password);
                command.Parameters.AddWithValue("@QuantityOfSales", seller.QuantityOfSales);
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { Close(); }
        }


        public Seller ExtractUser(int id)
        {
            Seller seller = null;
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"SELECT * FROM Sellers WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
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
            catch { throw; }
            finally { Close(); }
        }


        public Seller ExtractUser(string email, string password)
        {
            Seller seller = null;
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"SELECT * FROM Sellers WHERE email = @Email";
                command.Parameters.AddWithValue("@Email", email);
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
            catch { throw; }
            finally { Close(); }
        }

        public bool ValidateCredentials(string email, string password)
        {
            bool result = false;
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"SELECT * FROM Sellers WHERE email = @Email";
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        dataReader.Close();
                        command.CommandText = $"SELECT * FROM Sellers WHERE contraseña = @Password";
                        using (SqlDataReader dataReader2 = command.ExecuteReader())
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
                Close();
            }
        }

        public static void UpdateSales(int id, int quatityOfSales)
        {
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"UPDATE Sellers SET [cantidad ventas] = @QuantityOfSales WHERE ID = @ID";
                command.Parameters.AddWithValue("@QuantityOfSales", quatityOfSales);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
            catch { throw; }
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


        public static void UpdateStock(int id, int quantity, bool isSubstraction = false)
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
    }
}