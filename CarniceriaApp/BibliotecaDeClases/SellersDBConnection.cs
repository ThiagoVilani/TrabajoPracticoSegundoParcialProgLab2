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


        public void InsertUser(Seller seller)
        {
            try
            {
                Open();
                command.CommandText = $"INSERT INTO Sellers (ID,nombre,email,contraseña,[cantidad ventas]) " +
                                      $"VALUES ('{seller.ID}','{seller.Name}','{seller.Mail}','{seller.Password}','{(int)seller.QuantityOfSales}')";
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }

        public Seller ExtractUser(int id)
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
            catch { throw; }
            finally { connection.Close(); }
        }


        public Seller ExtractUser(string email, string password)
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
            catch { throw; }
            finally { connection.Close(); }
        }

        public bool ValidateCredentials(string email, string password)
        {
            bool result = false;
            try
            {
                Open();
                command.CommandText = $"SELECT * FROM Sellers WHERE email = '{email}'";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        dataReader.Close();
                        command.CommandText = $"SELECT * FROM Sellers WHERE contraseña = '{password}'";
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
                connection.Close();
            }
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
    }
}