using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Receipt
    {
        private static int IDCount = 1000;
        public int ID { get; private set; }
        public string PaymentMethod { get; }
        public Seller Seller { get; }
        public Client Client { get;}
        private List<Product> productsList = new List<Product>();
        public List<Product> ProductsList { get { return productsList;}}
        
        public double SubTotal { get; }
        public double Total { get; }



        public Receipt(List<Product> productsList,double subTotal,double total,Seller seller,Client client,string paymentMethod) 
        {
            foreach(Product product in productsList)
            {
                ProductsList.Add(product);
            }
            this.SubTotal = subTotal;
            this.Total = total;
            this.Seller = seller;
            this.Client = client;
            this.PaymentMethod = paymentMethod;
            IDCount++;
            this.ID = IDCount;
        }
        public Receipt(List<Product> productsList, double subTotal, double total, Seller seller, Client client, string paymentMethod,int ID)
        {
            foreach (Product product in productsList)
            {
                ProductsList.Add(product);
            }
            this.SubTotal = subTotal;
            this.Total = total;
            this.Seller = seller;
            this.Client = client;
            this.PaymentMethod = paymentMethod;
            this.ID = ID;
        }

        public int GetID()
        {
            return ID;
        }
    }
}
