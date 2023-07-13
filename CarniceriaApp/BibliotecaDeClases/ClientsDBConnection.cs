using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ClientsDBConnection:IConnection<Client>
    {
        private static string connectionString = "Data Source=.;Initial Catalog=Carniceria; Integrated Security=True";
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command;
        
        public ClientsDBConnection()
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

        public Client ExtractUser(int id)
        {
            Client client = null;
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"SELECT * FROM Clients WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
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


        public Client ExtractUser(string email, string password)
        {
            Client client = null;
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"SELECT * FROM Clients WHERE email = @Email and contraseña = @Password";
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
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
            catch{throw;}
            finally { connection.Close(); }
        }


        public List<Client> ExtractList()
        {
            List<Client> clients = new List<Client>();
            try
            {
                Open();
                command.Parameters.Clear();
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
            catch { throw; }
            finally { connection.Close(); }
        }


        public bool ValidateCredentials(string email, string password)
        {
            bool result = false;
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"SELECT * FROM Clients WHERE email = @Email";
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        dataReader.Close();
                        command.CommandText = $"SELECT * FROM Clients WHERE contraseña = @Password";
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
            catch { throw; }
            finally { connection.Close(); }
        }


        public void InsertUser(Client client)

        {
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO Clients (ID,nombre,email,contraseña,[cantidad dinero],pedido) " +
                                      $"VALUES (@ID,@Name,@Email,@Password,@MoneyAvailable,@Pedido)";
                command.Parameters.AddWithValue("@ID", client.ID);
                command.Parameters.AddWithValue("@Name", client.Name);
                command.Parameters.AddWithValue("@Email", client.Mail);
                command.Parameters.AddWithValue("@Password", client.Password);
                command.Parameters.AddWithValue("@MoneyAvailable", client.CantidadDinero);
                command.Parameters.AddWithValue("@Pedido", client.Pedido);
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }


        public static void UpdateClientMoney(int clientID, int total)
        {
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"UPDATE Clients SET [cantidad dinero] = @TOTAL WHERE ID = @ID";
                command.Parameters.AddWithValue("@TOTAL", total);
                command.Parameters.AddWithValue("@ID", clientID);
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }
    }
}
