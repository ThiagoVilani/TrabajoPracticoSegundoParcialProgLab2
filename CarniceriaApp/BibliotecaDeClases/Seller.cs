using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    /// <summary>
    /// Representa la identidad de un vendedor de la carniceria
    /// </summary>
    public sealed class Seller:User
    {
        TypesOfEmployees role;
        MonthlySalary salary;
        public int QuantityOfSales { get; set; }
        private static int IDCount = 1000;
        public int ID { get; private set; }



        /// <summary>
        /// Inicializa su nombre, mail y contraseña
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mail"></param>
        /// <param name="password"></param>
        public Seller(string name, string mail, string password,int quantityOfSales) : base(name, mail, password)
        {
            this.role = TypesOfEmployees.Vendedor;
            this.salary = MonthlySalary.FourthLevel;
            this.QuantityOfSales = quantityOfSales;
            IDCount++;
            this.ID = IDCount;
        }
        public Seller(string name, string mail, string password, int quantityOfSales,int id) : base(name, mail, password)
        {
            this.ID = id;
        }


        //DELEGADO
        public delegate void StockExpansionPOOS(int index); //  POOS: Products out of Stock
        public event StockExpansionPOOS StockIncreasedPOOS;

        //EVENTO
        public void AlertStockIncreasePOOS(int index)
        {
            if (StockIncreasedPOOS != null)
            {
                StockIncreasedPOOS.Invoke(index); //Con el Invoke()
            }
        }

        //DELEGADO
        public delegate void StockExpansion(int index);
        public event StockExpansion StockIncreased;


        //EVENTO
        public void AlertStockIncrease(int index)
        {
            if (StockIncreased!= null)
            {
                StockIncreased(index);
            }
        }

        /// <summary>
        /// Compara un mail con el mail de un Objeto del tipo Seller
        /// </summary>
        /// <param name="input">Recibe un mail</param>
        /// <param name="seller">Recibe el atributo mail de un Objeto Seller</param>
        /// <returns>Devuelve true si son iguales o false si no lo son</returns>
        public static bool operator ==(string input, Seller seller)
        {
            return input.ToLower() == seller.Mail.ToLower();
        }



        /// <summary>
        /// Compara un mail con el mail de un Objeto del tipo Seller
        /// </summary>
        /// <param name="input">Recibe un mail</param>
        /// <param name="seller">Recibe el atributo mail de un Objeto Seller</param>
        /// <returns>Devuelve true si son diferentes o false si no lo son</returns>
        public static bool operator !=(string input, Seller seller)
        {
            return !(input == seller);
        }


        public override string ShowInfo()
        {
            return base.ShowInfo() +
                   $"Rol: {this.role}\n" +
                   $"Salario: {Convert.ToInt32(this.salary)}\n" +
                   $"Cantidad de Ventas: {this.QuantityOfSales}";
        }

        public void ChangePrice(List<Product> products, int index, int newPrice)
        {
            if (index < 0)
            {
                throw new NumeroNegativoException($"El indice ingresado es negativo ({index}). El indice debe ser siempre positivo");
            }
            products[index].Price = newPrice;
            CarniceriaDBConnection.UpdatePrice(products[index].ID, newPrice);
        }

        public void AddStock(List<Product> products, int index, int stock)
        {
            if (index < 0)
            {
                throw new NumeroNegativoException($"El indice ingresado es negativo ({index}). El indice debe ser siempre positivo");
            }
            products[index].Stock += stock;
            CarniceriaDBConnection.UpdateStock(products[index].ID, stock, true);
        }

       

        public void AddToCart(int productIndex, int quantity,List<Product> products,List<Product> cart)
        {
            if (productIndex < 0)
            {
                throw new NumeroNegativoException($"El indice ingresado es negativo ({productIndex}). El indice debe ser siempre positivo");
            }
            CarniceriaDBConnection.UpdateStock(products[productIndex].ID, quantity,true);
            products[productIndex].Stock -= quantity; 
            for (int i = 0; i < quantity; i++)
            {
                cart.Add(products[productIndex]);
            }
        }

        public double CalculateSubTotal(List<Product> cart)
        {
            double total = 0;
            foreach (Product product in cart)
            {
                total += product.Price;
            }
            return total;
        }

        public double CalculateTotal(string paymentMethod, List<Product> cart)
        {
            if (paymentMethod == "Credito")
            {
                double st = CalculateSubTotal(cart);
                return st + (st * 0.05);
            }
            else
            {
                return CalculateSubTotal(cart);
            }
        }

        public bool SaleIsPossible(string paymentMethod, List<Product> cart, Client client, Queue<Client> Clients, bool isClient=false)
        {
            double total = CalculateTotal(paymentMethod,cart);
            if (client.CantidadDinero > total)
            {
                if (!isClient)
                {
                    Clients.Peek().CantidadDinero -= total; 
                    if (Clients.Count() > 0)
                    {
                        client = Clients.Peek();
                    }
                    this.QuantityOfSales++;
                    SellersDBConnection.UpdateSales(this.ID, this.QuantityOfSales);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
