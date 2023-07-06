using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public static class ToFiles
    {
        static XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Receipt>));
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


        public static void XmlSerializeReceipts(List<Receipt> receipts)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (streamWriter = new StreamWriter(path + @"/Receipts_serialized.xml"))
                {
                    try
                    {
                        xmlSerializer.Serialize(streamWriter, receipts);
                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Hubo un error al serializar los productos.");

                    }

                }
            }
            catch { }
        }


        public static string XmlDeserializeReceipts()
        {
            List<Receipt> receipts= new List<Receipt>();
            string receiptsList= string.Empty;
            receiptsList+="Lista de Recibos\n";

            try
            {
                using (streamReader = new StreamReader(path + @"/Receipts_serialized.xml"))
                {
                    receipts= xmlSerializer.Deserialize(streamReader) as List<Receipt>;
                }
            }
            catch { } 

            foreach (Receipt receipt in receipts)
            {
                receiptsList+=$"ID: {receipt.ID}\nMetodo de pago: {receipt.PaymentMethod}\nVendedor: {receipt.Seller}\nCliente: {receipt.Client}\nProductos:\n";
                foreach(Product product in receipt.ProductsList)
                {
                    receiptsList += $"{product.Name}\n";
                }
                receiptsList += $"\nSubtotal: {receipt.SubTotal}\nTotal: {receipt.Total}";
            }

            return receiptsList;
        }
    }
}