using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public static class ToFiles
    {
        static XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
        static string jsonString;
        static StreamWriter streamWriter;
        static StreamReader streamReader;
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


        public static void SaveProductsList(List<Product> list)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (streamWriter = new StreamWriter(path + @"/Receipts.txt"))
                {
                    streamWriter.WriteLine($"Fecha: {DateTime.Now.ToString()}");
                    foreach (Product product in list)
                    {
                        streamWriter.WriteLine($"{product.Name} | Stock a la fecha: {product.Stock} | Precio a la fecha: {product.Price}");
                    }
                }

            }
            catch { throw new Exception($"Error al intentar guardar el archivo"); }
        }


        public static string ReadProductsList()
        {
            try
            {
                string productsList = string.Empty;
                if (Directory.Exists(path))
                {
                    using (streamReader = new StreamReader(path + @"/Receipts.txt"))
                    {
                        productsList = streamReader.ReadToEnd();

                    }
                }
                return productsList;
            }
            catch
            {
                throw new Exception($"Error al intentar leer el archivo");
            }
        }


        public static void XmlSerializeProducts(List<Product> products)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (streamWriter = new StreamWriter(path + @"/Products_serialized.xml"))
                {
                    try
                    {
                        xmlSerializer.Serialize(streamWriter, products);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Hubo un error al serializar los productos.");
                    }
                }
            }
            catch { }
        }


        public static string XmlDeserializeProducts()
        {
            List<Product> products = new List<Product>();
            string productsList= string.Empty;
            productsList+="Lista de Productos\n";

            try
            {
                using (streamReader = new StreamReader(path + @"/Products_serialized.xml"))
                {
                    products = xmlSerializer.Deserialize(streamReader) as List<Product>;
                }
            }
            catch { } 

            foreach (Product product in products)
            {
                productsList +=$"ID: {product.ID}\nPrecio: {product.Price}\nNombre: {product.Name}\nStock: {product.Stock}\nDetalles:{product.Details}\n";
            }

            return productsList;
        }


        public static void JsonSerializeProducts(List<Product> products)
        {

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            try
            {
                jsonString = JsonSerializer.Serialize(products, options);

                using (streamWriter = new StreamWriter(path + @"/Products_serialized.json"))
                {
                    streamWriter.Write(jsonString);
                }
            }
            catch
            {
                throw new Exception("Hubo un error al serializar los productos.");
            }
        }

        public static string JsonDeserializeProducts()
        {
            List<Product> products = new List<Product>();
            string productsList = string.Empty;
            productsList += "Lista de productos deserializada en JSON\n";

            try
            {
                using (streamReader = new StreamReader(path + @"/Products_serialized.json"))
                {
                    products = JsonSerializer.Deserialize<List<Product>>(jsonString);
                }
            }
            catch
            {
                throw new Exception("Hubo un error al deserializar los productos.");
            }
            foreach (Product product in products)
            {
                productsList += $"ID: {product.ID}\nPrecio: {product.Price}\nNombre: {product.Name}\nStock: {product.Stock}\nDetalles:{product.Details}\n";
            }
            return productsList;
        }
    }
}