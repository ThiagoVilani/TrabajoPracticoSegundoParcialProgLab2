namespace BibliotecaDeClases
{
    /// <summary>
    /// Representa la entidad de un cliente
    /// </summary>
    public sealed class Client:User
    {
        public double CantidadDinero { get; set; }
        public string Pedido { get;}

        private static int IDCount = 1000;
        public int ID { get; private set; }
        /// <summary>
        /// Inicializa los atributos de dinero y toma el pedido
        /// </summary>
        /// <param name="name">Recibe el nombre del cliente</param>
        /// <param name="cantidadDinero">Recibe la cantidad de dinero que el cliente tiene para comprar</param>
        /// <param name="pedido">Recibe la solicitud de productos del cliente</param>
        /// <param name="mail">Recib el mail del cliente</param>
        /// <param name="password">Recibe la contraseña del cliente</param>
        public Client(string name, float cantidadDinero, string pedido, string mail, string password) : base(name, mail, password)
        {
            this.CantidadDinero = cantidadDinero;
            this.Pedido = pedido;
            IDCount++;
            this.ID = IDCount;
        }
        public Client(string name, float cantidadDinero, string pedido, string mail, string password,int ID) : base(name, mail, password)
        {
            this.CantidadDinero = cantidadDinero;
            this.Pedido = pedido;
            this.ID = ID;
        }

        /// <summary>
        /// Compara un mail con el mail de un Objeto del tipo Client
        /// </summary>
        /// <param name="input">Recibe un mail</param>
        /// <param name="seller">Recibe el atributo mail de un Objeto Client</param>
        /// <returns>Devuelve true si son iguales o false si no lo son</returns>
        public static bool operator ==(string input, Client client)
        {
            return input.ToLower() == client.Mail.ToLower();
        }
        /// <summary>
        /// Compara un mail con el mail de un Objeto del tipo Seller
        /// </summary>
        /// <param name="input">Recibe un mail</param>
        /// <param name="seller">Recibe el atributo mail de un Objeto Seller</param>
        /// <returns>Devuelve true si son diferentes o false si no lo son</returns>
        public static bool operator !=(string input, Client client)
        {
            return !(input == client);
        }

        public override string ShowInfo()
        {
            return base.ShowInfo()+
                   $"Dinero para comprar: {this.CantidadDinero}\n" +
                   $"Pedido: {this.Pedido}";
        }

        public void CalculateRemainingMoney(Product product, int quantity)
        {
            this.CantidadDinero -= (product.Price * quantity);
        }
    }
}