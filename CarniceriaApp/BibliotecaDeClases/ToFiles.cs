using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public static class ToFiles
    {
        //static XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
        static string jsonString;
        static string receiptsFiles= @"/Receipts.txt";
        static string xmlFiles = "Products.xml";
        static string jsonFiles= "Products.json";
        static StreamWriter streamWriter;
        static StreamReader streamReader;
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


        public static void SaveListOfProducts(List<Product> list)
        {
            try
            {
                
                        using (streamWriter = new StreamWriter(path+receiptsFiles))
                        {
                            streamWriter.WriteLine($"Fecha: {DateTime.Now.ToString()}");
                            foreach(Product product in list)
                            {
                                streamWriter.WriteLine($"{product.Name} | Stock a la fecha: {product.Stock} | Precio a la fecha: {product.Price}");
                            }
                        }
                    
            }
            catch (Exception ex) { }
            finally { }
        }


        public static void Write(List<Product> list)
        {

            //if (Directory.Exists(path+@"/sesos.txt"))
            //{

            //}
            try
            {
                using (StreamWriter sw = new StreamWriter(path + @"/sesos.txt"))
                {
                    sw.WriteLine("algo");
                }
            }
            catch
            {

            }
        }
    }
}
