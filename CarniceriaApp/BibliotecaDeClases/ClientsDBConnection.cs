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
                command.CommandText = $"SELECT * FROM Clients WHERE ID = {id}";
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
                command.CommandText = $"SELECT * FROM Clients WHERE email = '{email}' and contraseña = '{password}'";
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
                command.CommandText = $"SELECT * FROM Clients WHERE email = '{email}'";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        dataReader.Close();
                        command.CommandText = $"SELECT * FROM Clients WHERE contraseña = '{password}'";
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
                command.CommandText = $"INSERT INTO Clients (ID,nombre,email,contraseña,[cantidad dinero],pedido) " +
                                      $"VALUES ('{client.ID}','{client.Name}','{client.Mail}','{client.Password}','{(int)client.CantidadDinero}','{client.Pedido}')";
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
                command.CommandText = $"UPDATE Clients SET [cantidad dinero] = {total} WHERE ID = {clientID}";
                command.ExecuteNonQuery();
            }
            catch { throw; }
            finally { connection.Close(); }
        }
    }
}
