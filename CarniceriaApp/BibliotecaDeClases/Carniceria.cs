using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{


    ///////////////////////////       Palabra clave para eliminar las listas     \\\\\\\\\\\\\\\\\\\\\\\\\\
    ///////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ///////////////////////////////                 STANLEY                     \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\




    /// <summary>
    /// Se encarga de administrar los clientes, los vendedores, los productos y sus precios, stock etc.
    /// </summary>
    public class Carniceria
    {
        //Atributos y Propiedades
        private int currentQuantProductsOOS;
        private List<Product> productsOutOfStock;
        public List<Product> ProductsOutOfStock {  get { return productsOutOfStock; } }
        private List<Receipt> receiptList = new List<Receipt>();
        public List<Receipt> ReceiptList { get { return receiptList; } }
        private int CurrentQuantityClients { get; set; }
        private int CurrentQuantityOfProductsInCart { get; set; }
        private Queue<Client> clients = new Queue<Client>();
        private List<Client> originalClientsList;
        private List<Product> products;
        private List<Product> cart = new List<Product> { };
        public Client CurrentClient { get; set; }
        public Seller CurrentSeller { get; set; }

        public List<Product> Cart { get { return cart; } }
        public List<Product> Products { get { return products; } }
       
        public Queue<Client> Clients
                {
                    get
                    {
                        return clients;
                    }
                }


        // Constructor
        /// <summary>
        /// Agrega todos los clientes a la cola de clientes
        /// Crea y agrega todos los cortes de carne a la lista de cortes
        /// </summary>
        public Carniceria()
        {
            originalClientsList = new List<Client>(DBConnection.ExtractClients());
            foreach (Client client in originalClientsList)
            {
                clients.Enqueue(client);
            }
            products = new List<Product>(DBConnection.ExtractProducts());
            productsOutOfStock = new List<Product>(DBConnection.ExtractProducts("ProductsOutOfStock"));
            CurrentQuantityOfProductsInCart = 0;
            CurrentQuantityClients = Clients.Count();
            currentQuantProductsOOS = 0;
        }


        //||||||||||||||||||FUNCIONES|||||||||||||||||||

        /// <summary>
        /// Agrega un producto que se haya quedado sin stock a la lista de productos
        /// que no tienen stock
        /// </summary>
        /// <param name="productIndex"></param>
        public void NewProductOutOfStock(int productIndex)
        {
            if(productIndex < 0)
            {
                throw new NumeroNegativoException($"El indice ingresado es negativo ({productIndex}). El indice debe ser siempre positivo");
            }
            this.productsOutOfStock.Add(this.products[productIndex]);   // STANLEY
            DBConnection.InsertProduct(this.products[productIndex], "ProductsOutOfStock");
            DBConnection.DeleteProduct(this.Products[productIndex].ID);
        }

        /// <summary>
        /// Actualiza el registro de la cantidad de productos fuera de stock
        /// </summary>
        /// <returns>Retorna true si algun producto volvio a tener stock o false si no lo hizo</returns>
        public bool ChangesInStock()
        {
            if (currentQuantProductsOOS != this.productsOutOfStock.Count())
            {
                currentQuantProductsOOS = this.productsOutOfStock.Count(); //STANLEY (en realidad esta parte hay que cambiarla si decido eliminar las listas para siempre)
                return true;
            }
            else { return false; }
        }


        /// <summary>
        /// Actualiza el registro de la cantidad de productos en stock
        /// </summary>
        /// <returns>Retorna true si vario la cantidad o false si no lo hizo</returns>
        public bool ChangeQuantityProducts()
        {   
            if(this.cart.Count()!=CurrentQuantityOfProductsInCart)
            {
                CurrentQuantityOfProductsInCart = this.Cart.Count();
                return true;
            }
            else {  return false; }
        }
        

        /// <summary>
        /// Actualiza el registro de la cantidad de clientes en la cola
        /// </summary>
        /// <returns>retorna true si vario la cantidad o false si hubo variaciones</returns>
        public bool ChangeQuantityClients()
        {
            if (CurrentQuantityClients != this.Clients.Count())
            {
                CurrentQuantityClients = this.Clients.Count();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
