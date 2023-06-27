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
        public int ID { get;}



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
        }
        public Seller(string name, string mail, string password, int quantityOfSales,int id) : base(name, mail, password)
        {
            this.ID = id;
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
            DBConnection.UpdatePrice(products[index].ID, newPrice);
        }

        public void AddStock(List<Product> products, int index, int stock)
        {
            if (index < 0)
            {
                throw new NumeroNegativoException($"El indice ingresado es negativo ({index}). El indice debe ser siempre positivo");
            }
            products[index].Stock += stock;
            DBConnection.UpdateStock(products[index].ID, stock, "+");
        }

        public void AddToCart(int productIndex, int quantity,List<Product> products,List<Product> cart)
        {
            if (productIndex < 0)
            {
                throw new NumeroNegativoException($"El indice ingresado es negativo ({productIndex}). El indice debe ser siempre positivo");
            }
            DBConnection.UpdateStock(products[productIndex].ID, quantity,"-");
            products[productIndex].Stock -= quantity;  // STANLEY
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
                    DBConnection.UpdateClientMoney(Clients.Peek().ID, (int)total);
                    Clients.Peek().CantidadDinero -= total; // STANLEY
                    if (Clients.Count() > 0)
                    {
                        client = Clients.Peek();
                    }
                    else
                    {
                        this.QuantityOfSales++;
                        DBConnection.UpdateSales(this.ID, this.QuantityOfSales);
                    }
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
