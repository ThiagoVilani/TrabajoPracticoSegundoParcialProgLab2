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
        static DBConnection()
        {
        }

        //      ////////////////////////////////////////////////////////
        //      ////////////////////////////////////////////////////////
        //      ///////////////////////////////////////////////////////
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
                CarniceriaDBConnection.InsertProduct(p);
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
            lista.Add(new Seller("mario","mario@gmail.com","mario123",400));
            lista.Add(new Seller("Luciana", "luciana@gmail.com", "luciana123", 236));
            lista.Add(new Seller("DonBosco", "donbosco@gmail.com", "Donbosco123", 125));
            foreach (Seller seller in lista)
            {
                sellerDBC.InsertUser(seller);
            }
        }
    }
}
